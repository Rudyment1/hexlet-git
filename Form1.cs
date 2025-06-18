using System.Windows.Forms;

namespace Scoreboard
{
    public partial class Form1 : Form
    {   // ��������� ������ ��� ���������� ����������� �������������� ������
        private int _previousBlueWarning = 0;
        private int _previousRedWarning = 0;
        // ���������� �������� ��������� �����
        private int _remainingSeconds = 300;
        private int _retentionBlueSecond = 0;
        private int _retentionRedSecond = 0;
        private const int STARTTIME = 300;
        // ������������� �� ������
        private bool _isInternalChange = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void IncreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == button1 ? textBox1 : textBox2;
            ModifyScore(associatedTextBox, 1);
        }

        private void DecreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == button2 ? textBox1 : textBox2;
            ModifyScore(associatedTextBox, -1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWarningScore(comboBox1, ref _previousRedWarning, textBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWarningScore(comboBox2, ref _previousBlueWarning, textBox2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(ContractionTimer, button6, textBox3, ref _remainingSeconds, "�����");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RebootTimer(ContractionTimer, textBox3, STARTTIME, ref _remainingSeconds);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int difference = STARTTIME - _remainingSeconds;
            string time = $"{(difference / 60)}:{(difference % 60):D2}";
            MessageBox.Show($"����� � ������ �������: {time}");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer1, button10, textBox4, ref _retentionRedSecond, "�����");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer2, button11, textBox5, ref _retentionBlueSecond, "�����");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RebootTimer(timer1, textBox4, 0, ref _retentionRedSecond);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            RebootTimer(timer2, textBox5, 0, ref _retentionBlueSecond);
        }

        private void ContractionTimer_Tick(object sender, EventArgs e)
        {
            OnContractionTimerTick(ContractionTimer, ref _remainingSeconds, textBox3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTicker(textBox4, ref _retentionRedSecond);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timerTicker(textBox5, ref _retentionBlueSecond);
        }






        private void timerTicker(TextBox txtBox, ref int _retentionSecond)
        {
            _retentionSecond++;
            txtBox.Text = $"{(_retentionSecond / 60)}:{(_retentionSecond % 60):D2}";
        }
        private void RebootTimer(System.Windows.Forms.Timer timer, TextBox timeBox, int starttime, ref int time)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                time = starttime;
                timeBox.Text = $"{(time / 60)}:{(time % 60):D2}";
            }
            else
            {
                time = starttime;
                timeBox.Text = $"{(time / 60)}:{(time % 60):D2}";
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(textBox5, ref _retentionBlueSecond);
            }
            finally
            {
                _isInternalChange = false;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(textBox4, ref _retentionRedSecond);
            }
            finally
            {
                _isInternalChange = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(textBox3, ref _remainingSeconds);
            }
            finally
            {
                _isInternalChange = false;
            }
        }

        private void FormatText(TextBox txtBox, ref int timer)
        {
            _isInternalChange = true;
            string originalText = txtBox.Text;
            int originalCursor = txtBox.SelectionStart;
            string digits = new string(originalText.Where(c => char.IsDigit(c)).ToArray());


            string formatted = "_:__";

            if (digits.Length >= 1)
                formatted = digits[0] + ":__";
            if (digits.Length >= 2)
                formatted = digits[0] + ":" + digits[1] + "_";
            if (digits.Length >= 3)
                formatted = digits[0] + ":" + digits[1] + digits[2];

            txtBox.Text = formatted;

            if (!formatted.Contains('_'))
            {
                int minutes = int.Parse(formatted[0].ToString());
                int seconds = int.Parse(formatted.Substring(2, 2));
                timer = minutes * 60 + seconds;
            }

            int nextCursor = formatted.IndexOf('_');
            if (nextCursor == -1) nextCursor = formatted.Length;

            txtBox.SelectionStart = nextCursor;
        }
        private void StartStopContractionTimer(System.Windows.Forms.Timer timer, Button button, TextBox timeBox, ref int timeInSeconds, string message)
        {
            if (!timer.Enabled && !timeBox.Text.Contains('_'))
            {
                timer.Start();
                button.Text = "����";
            }
            else if (timer.Enabled)
            {
                timer.Stop();
                if (timer == ContractionTimer)
                    StopAllTimer();
                button.Text = message;
            }
            else
            {
                MessageBox.Show("������� ����� ��������� � ������� m:ss");
            }
        }


        private void OnContractionTimerTick(System.Windows.Forms.Timer timer, ref int timeInSeconds, TextBox txtBox)
        {
            if (_remainingSeconds > 0)
            {
                _remainingSeconds--;


                txtBox.Text = $"{(_remainingSeconds / 60)}:{(_remainingSeconds % 60):D2}";
            }
            else
            {
                timer.Stop();
                System.Media.SystemSounds.Beep.Play();
            }
        }


        private void UpdateWarningScore(ComboBox warningComboBox, ref int previousWarning, TextBox scoreBox)
        {
            int currentScore = int.TryParse(scoreBox.Text, out int n) ? n : 0;

            if (int.TryParse(warningComboBox.SelectedItem?.ToString(), out int selectedWarning))
            {
                int delta = selectedWarning - previousWarning;
                currentScore += delta;
                previousWarning = selectedWarning;
            }
            else
            {
                currentScore -= previousWarning;
                previousWarning = 0;
            }

            scoreBox.Text = Math.Max(0, currentScore).ToString();
        }


        private void StopAllTimer()
        {
            timer1.Stop();
            button10.Text = "�����";
        }

        private void ModifyScore(TextBox textBox, int change)
        {
            if (int.TryParse(textBox.Text, out int currentScore))
            {
                int newScore = Math.Max(0, currentScore + change);
                textBox.Text = newScore.ToString();
            }
        }




        private void validateInputDigitsAndColon(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }


        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ������ ����� � ������ 
            if (e.KeyChar == '.' || !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
               e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            /* ��� ����������
             � ��� ������� e.Key ��� �������� ������ � ���� �� �� �������� ������������
            ������� �� �� ��������� ���� ��� �� �� �����������(e.Handled = true) */
        }

      
    }
}
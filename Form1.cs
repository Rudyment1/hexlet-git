using System.Windows.Forms;

namespace Scoreboard
{
    public partial class Form1 : Form
    {   // Перменная нужная для сохранения предыдущего предупреждения синего
        private int _previousBlueWarning = 0;
        private int _previousRedWarning = 0;
        // Переменная хранящее начальное время
        private int _remainingSeconds = 300;
        private int _retentionBlueSecond = 0;
        private int _retentionRedSecond = 0;
        private const int STARTTIME = 300;
        // Редактируется ли таймер
        private bool _isInternalChange = false;
        private Button _holdIsOn;
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
            StartStopContractionTimer(ContractionTimer, button6, textBox3, ref _remainingSeconds, "Старт");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RebootTimer(ContractionTimer, textBox3, STARTTIME, ref _remainingSeconds);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int difference = STARTTIME - _remainingSeconds;
            string time = $"{(difference / 60)}:{(difference % 60):D2}";
            MessageBox.Show($"Время с начала схватки: {time}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer1, button9, textBox4, ref _retentionRedSecond, "Болевой");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer1, button10, textBox4, ref _retentionRedSecond, "Удерж");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer2, button11, textBox5, ref _retentionBlueSecond, "Удерж");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            StartStopContractionTimer(timer2, button12, textBox5, ref _retentionBlueSecond, "Болевой");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            RebootTimer(timer1, textBox4, 0, ref _retentionRedSecond);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            RebootTimer(timer2, textBox5, 0, ref _retentionBlueSecond);
        }
        private void button16_Click(object sender, EventArgs e)
        {

        }
        private void ContractionTimer_Tick(object sender, EventArgs e)
        {
            OnContractionTimerTick(ContractionTimer, ref _remainingSeconds, textBox3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTicker(textBox4, ref _retentionRedSecond, textBox1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimerTicker(textBox5, ref _retentionBlueSecond, textBox2);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
        }





        private void TimerTicker(TextBox txtBox, ref int _retentionSecond, TextBox score)
        {

            _retentionSecond++;

            if (_retentionSecond == 10 || _retentionSecond == 20)
                ModifyScore(score, 2);

            txtBox.Text = $"{(_retentionSecond / 60)}:{(_retentionSecond % 60):D2}";
        }
        private void RebootTimer(System.Windows.Forms.Timer timer, TextBox timeBox, int starttime, ref int time)
        {
            if (timer.Enabled) timer.Stop();
            time = starttime;
            timeBox.Text = $"{(time / 60)}:{(time % 60):D2}";
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
        private void StartStopContractionTimer(System.Windows.Forms.Timer timer, Button button,
            TextBox timeBox, ref int timeInSeconds, string message)
        {
            if (!timer.Enabled && !timeBox.Text.Contains('_'))
            {

                _holdIsOn = button;
                timer.Start();
                button.Text = "Стоп";
            }
            else if (timer.Enabled)
            {
                if (button.Text == "Стоп")
                {
                    timer.Stop();
                    if (timer == ContractionTimer)
                        StopAllTimer();
                    button.Text = message;
                }
                else
                {
                    RebootTimer(timer, timeBox, 0, ref timeInSeconds);
                    if (button.Text == "Болевой")
                    {
                        _holdIsOn.Text = "Удерж";
                        button.Text = "Стоп";
                        timer.Start();

                    }
                    else
                    {
                        _holdIsOn.Text = "Болевой";
                        button.Text = "Стоп";
                        timer.Start();

                    }
                }
            }
            else
            {
                MessageBox.Show("Введите время полностью в формате m:ss");
            }
        }


        private void OnContractionTimerTick(System.Windows.Forms.Timer timer, ref int timeInSeconds, TextBox txtBox)
        {
            if (timeInSeconds > 0)
            {
                timeInSeconds--;


                txtBox.Text = $"{(timeInSeconds / 60)}:{(timeInSeconds % 60):D2}";
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
            button10.Text = "Удерж";
            timer2.Stop();
            button11.Text = "Удерж";
        }

        private void ModifyScore(TextBox textBox, int change)
        {
            if (int.TryParse(textBox.Text, out int currentScore))
            {
                int newScore = Math.Max(0, currentScore + change);
                textBox.Text = newScore.ToString();
            }
        }




        private void ValidateInputDigitsAndColon(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }


        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Фильтр ввода в оценки 
            if (e.KeyChar == '.' || !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
               e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            /* Как происходит
             У нас имеется e.Key это вводимый символ и если он не является предсталеным
            случаям то он вводиться если нет то он пропускаеся(e.Handled = true) */
        }


    }
}
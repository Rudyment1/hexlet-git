using System.Windows.Forms;

namespace Scoreboard
{
    public partial class Form1 : Form
    {   // Перменная нужная для сохранения предыдущего предупреждения синего
        private int _previousBlueWarning = 0;
        private int _previousRedWarning = 0;
        // Переменная хранящее начальное время
        private int _remainingSeconds = 180;
        // Запущен ли таймер
        private bool _isInternalChange = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Фильтр ввода в счет
            if (e.KeyChar == '.' || !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
               e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }


        private void ModifyScore(TextBox textBox, int change)
        {
            if (int.TryParse(textBox.Text, out int currentScore))
            {
                int newScore = Math.Max(0, currentScore + change);
                textBox.Text = newScore.ToString();
            }
        }

        private void IncreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == button1 || button == button2 ? textBox1 : textBox2;
            ModifyScore(associatedTextBox, 1);
        }
        private void DecreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == button1 || button == button2 ? textBox1 : textBox2;
            ModifyScore(associatedTextBox, -1);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentScore = int.TryParse(textBox1.Text, out int n) ? n : 0;

            if (int.TryParse(comboBox1.SelectedItem?.ToString(), out int selectedWarning))
            {
                int delta = selectedWarning - _previousBlueWarning;
                currentScore += delta;
                _previousBlueWarning = selectedWarning;
            }
            else
            {
                currentScore -= _previousBlueWarning;
                _previousBlueWarning = 0;
            }

            textBox1.Text = Math.Max(0, currentScore).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!ContractionTimer.Enabled && !textBox3.Text.Contains('_'))
            {
                ContractionTimer.Start();
                button6.Text = "Стоп";
            }
            else if (ContractionTimer.Enabled)
            {
                ContractionTimer.Stop();
                button6.Text = "Старт";
            }
            else
            {
                MessageBox.Show("Введите время полностью в формате m:ss");
            }
        }

        private void ContractionTimer_Tick(object sender, EventArgs e)
        {
            if (_remainingSeconds > 0)
            {
                _remainingSeconds--;


                textBox3.Text = $"{(_remainingSeconds / 60)}:{(_remainingSeconds % 60):D2}";
            }
            else
            {
                ContractionTimer.Stop();
                System.Media.SystemSounds.Beep.Play();
            }
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                _isInternalChange = true;
                string originalText = textBox3.Text;
                int originalCursor = textBox3.SelectionStart;
                string digits = new string(originalText.Where(c => char.IsDigit(c)).ToArray());


                string formatted = "_:__";

                if (digits.Length >= 1)
                    formatted = digits[0] + ":__";
                if (digits.Length >= 2)
                    formatted = digits[0] + ":" + digits[1] + "_";
                if (digits.Length >= 3)
                    formatted = digits[0] + ":" + digits[1] + digits[2];

                textBox3.Text = formatted;

                if (!formatted.Contains('_'))
                {
                    int minutes = int.Parse(formatted[0].ToString());
                    int seconds = int.Parse(formatted.Substring(2, 2));
                    _remainingSeconds = minutes * 60 + seconds;
                }

                int nextCursor = formatted.IndexOf('_');
                if (nextCursor == -1) nextCursor = formatted.Length;

                textBox3.SelectionStart = nextCursor;
            }
            finally
            {
                _isInternalChange = false;
            }
        }

    }
}
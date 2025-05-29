namespace Scoreboard
{
    public partial class Form1 : Form
    {
        int previousWarning = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int _number = int.Parse(textBox1.Text);
            _number++;
            textBox1.Text = _number.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int _number = int.Parse(textBox1.Text);

            if (_number == 0)
            {
                return;
            }
            else
            {
                _number--;
                textBox1.Text = _number.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int _number = int.Parse(textBox2.Text);
            _number++;
            textBox2.Text = _number.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int _number = int.Parse(textBox2.Text);

            if (_number == 0)
            {
                return;
            }
            else
            {
                _number--;
                textBox2.Text = _number.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int _selectedState))
            {
                if (_selectedState == 0 && previousWarning == 1 || _selectedState == 1 && previousWarning == 2)
                {
                    previousWarning = _selectedState;
                    int _number = int.Parse(textBox1.Text);
                    if (_number != 0)
                    {
                        _number--;
                        textBox1.Text = _number.ToString();
                    }
                }
                else if (previousWarning == 0 && _selectedState == 1)
                {
                    previousWarning = _selectedState;
                    int _number = int.Parse(textBox1.Text);
                    _number++;
                    textBox1.Text = _number.ToString();
                }
                else if (previousWarning == 1 && _selectedState == 2)
                {
                    previousWarning = _selectedState;
                    int _number = int.Parse(textBox1.Text);
                    _number++;
                    textBox1.Text = _number.ToString();
                }
                else if (previousWarning == 0 && _selectedState == 2)
                {
                    previousWarning = _selectedState;
                    int _number = int.Parse(textBox1.Text);
                    _number += 2;
                    textBox1.Text = _number.ToString();
                }
                else if (previousWarning == 2 && _selectedState == 0)
                {
                    previousWarning = _selectedState;
                    int _number = int.Parse(textBox1.Text);
                    if (_number != 0)
                    {
                        _number -= 2;
                        textBox1.Text = _number.ToString();
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

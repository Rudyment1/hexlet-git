

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
        private int _medicalTimeRed = 0;
        private int _medicalTimeBlue = 0;
        private const int STARTTIME = 300;
        // Редактируется ли таймер
        private bool _isInternalChange = false;
        private Form2 viewerForm;
        private string folder = "participants";
        private Size _originalFormSize;
        private Dictionary<Control, (Rectangle Bounds, float FontSize)> _originalControls;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(folder);
            viewerForm = new Form2();
            viewerForm.Show();
            UpdateAutoComplete();
            _originalFormSize = this.Size;
            _originalControls = new Dictionary<Control, (Rectangle, float)>();

            foreach (Control ctrl in this.Controls)
            {
                _originalControls[ctrl] = (ctrl.Bounds, ctrl.Font.Size);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeAllControls();
        }
        private void ResizeAllControls()
        {
            float xRatio = (float)this.Width / _originalFormSize.Width;
            float yRatio = (float)this.Height / _originalFormSize.Height;

            foreach (Control ctrl in this.Controls)
            {
                if (!_originalControls.ContainsKey(ctrl)) continue;

                var (originalBounds, originalFontSize) = _originalControls[ctrl];

                ctrl.Bounds = new Rectangle(
                    (int)(originalBounds.X * xRatio),
                    (int)(originalBounds.Y * yRatio),
                    (int)(originalBounds.Width * xRatio),
                    (int)(originalBounds.Height * yRatio)
                );

                ctrl.Font = new Font(ctrl.Font.FontFamily, originalFontSize * Math.Min(xRatio, yRatio), ctrl.Font.Style);
            }
        }


        private void IncreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == IncreaseRed ? ScoreRed : ScoreBlue;
            ModifyScore(associatedTextBox, 1);
        }

        private void DecreaseScore_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var associatedTextBox = button == DecreaseRed ? ScoreRed : ScoreBlue;
            ModifyScore(associatedTextBox, -1);
        }

        private void WarningSelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;
            ref var previousWarning = ref (cmb == BlueWarning ? ref _previousBlueWarning : ref _previousRedWarning);
            var scoreBox = cmb == BlueWarning ? ScoreRed : ScoreBlue;
            UpdateWarningScore(cmb, ref previousWarning, scoreBox);
        }

        private void BtnStartStopMainClick(object sender, EventArgs e)
        {
            StartStopContractionTimer(ContractionTimer, BtnStartStopMain, MainTime, ref _remainingSeconds, "Старт");
        }

        private void BtnResetMainTimeClick(object sender, EventArgs e)
        {
            BtnStartStopMain.Text = "Старт";
            RebootTimer(ContractionTimer, MainTime, STARTTIME, ref _remainingSeconds);
            viewerForm.SetMainTime(MainTime.Text);
            viewerForm.SetMainForeColor(false);
        }

        private void BtnShowTimeElapsedClick(object sender, EventArgs e)
        {
            int difference = STARTTIME - _remainingSeconds;
            string time = $"{(difference / 60)}:{(difference % 60):D2}";
            MessageBox.Show($"Время с начала схватки: {time}");
        }

        private void BtnRetentionRedClick(object sender, EventArgs e)
        {
            BtnRetentionRed.Text = "Удерж";
            StartStopContractionTimer(RedRetentionTimer, BtnPainfulHoldRed, TxtBoxRetentionRed, ref _retentionRedSecond, "Болевой");
        }

        private void BtnPainfulHoldRedClick(object sender, EventArgs e)
        {
            BtnPainfulHoldRed.Text = "Болевой";
            StartStopContractionTimer(RedRetentionTimer, BtnRetentionRed, TxtBoxRetentionRed, ref _retentionRedSecond, "Удерж");
        }

        private void BtnPainfulHoldBlueClick(object sender, EventArgs e)
        {
            BtnPainfulHoldBlue.Text = "Болевой";
            StartStopContractionTimer(BlueRetentionTimer, BtnRetentionBlue, TxtBoxRetentionBlue, ref _retentionBlueSecond, "Удерж");
        }

        private void BtnRetentionBlueClick(object sender, EventArgs e)
        {
            BtnRetentionBlue.Text = "Удерж";
            StartStopContractionTimer(BlueRetentionTimer, BtnPainfulHoldBlue, TxtBoxRetentionBlue, ref _retentionBlueSecond, "Болевой");
        }
        private void BtnStartStopMedicalTimeRedClick(object sender, EventArgs e)
        {
            StartStopContractionTimer(RedTimeMedical, BtnStartStopMedicalTimeRed, TxtBoxMedicalRed, ref _medicalTimeRed, "Старт");
        }
        private void BtnStartStopMedicalTimeBlueClick(object sender, EventArgs e)
        {
            StartStopContractionTimer(BlueTimeMedical, BtnStartStopMedicalTimeBlue, TxtBoxMedicalRed, ref _medicalTimeBlue, "Старт");
        }
        private void BtnResetRetentionRedClick(object sender, EventArgs e)
        {
            BtnRetentionRed.Text = "Удерж";
            BtnPainfulHoldRed.Text = "Болевой";
            RebootTimer(RedRetentionTimer, TxtBoxRetentionRed, 0, ref _retentionRedSecond);
            viewerForm.SetHoldRed("");
        }
        private void BtnResetRetentionBlueClick(object sender, EventArgs e)
        {
            BtnPainfulHoldBlue.Text = "Болевой";
            BtnRetentionBlue.Text = "Удерж";
            RebootTimer(BlueRetentionTimer, TxtBoxRetentionBlue, 0, ref _retentionBlueSecond);
            viewerForm.SetHoldBlue("");
        }
        private void BtnResetMedicalTimeRedClick(object sender, EventArgs e)
        {
            BtnStartStopMedicalTimeRed.Text = "Старт";
            RebootTimer(RedTimeMedical, TxtBoxMedicalRed, 0, ref _medicalTimeRed);
        }

        private void BtnResetMedicalTimeBlueClick(object sender, EventArgs e)
        {
            BtnStartStopMedicalTimeBlue.Text = "Старт";
            RebootTimer(BlueTimeMedical, TxtBoxMedicalBlue, 0, ref _medicalTimeBlue);
        }
        private void BtnFullScreenClick(object sender, EventArgs e)
        {
            viewerForm.SetFullScreen();
        }
        private void ContractionTimerTick(object sender, EventArgs e)
        {
            OnContractionTimerTick(ContractionTimer, ref _remainingSeconds, MainTime);
            viewerForm.SetMainTime(MainTime.Text);
        }

        private void RedRetentionTimerTick(object sender, EventArgs e)
        {
            TimerTicker(TxtBoxRetentionRed, ref _retentionRedSecond, ScoreRed);
            viewerForm.SetHoldRed(TxtBoxRetentionRed.Text);
        }
        private void BlueRetentionTimerTick(object sender, EventArgs e)
        {
            TimerTicker(TxtBoxRetentionBlue, ref _retentionBlueSecond, ScoreBlue);
            viewerForm.SetHoldBlue(TxtBoxRetentionBlue.Text);
        }
        private void RedTimeMedicalTick(object sender, EventArgs e)
        {
            TimerTickerTwo(TxtBoxMedicalRed, ref _medicalTimeRed);
        }
        private void BlueTimeMedicalTick(object sender, EventArgs e)
        {
            TimerTickerTwo(TxtBoxMedicalBlue, ref _medicalTimeBlue);
        }




        private void TimerTicker(TextBox txtBox, ref int _retentionSecond, TextBox? score = null)
        {

            _retentionSecond++;

            if ((_retentionSecond == 20 && BtnRetentionRed.Text == "Стоп" || _retentionSecond == 20 && BtnRetentionBlue.Text == "Стоп")
                || (_retentionSecond == 10 && BtnRetentionRed.Text == "Стоп" || _retentionSecond == 10 && BtnRetentionBlue.Text == "Стоп"))
            {
                ModifyScore(score, 2);
            }

            txtBox.Text = $"{(_retentionSecond / 60)}:{(_retentionSecond % 60):D2}";
        }
        private void TimerTickerTwo(TextBox txtBox, ref int _retentionSecond)
        {
            _retentionSecond++;
            txtBox.Text = $"{(_retentionSecond / 60)}:{(_retentionSecond % 60):D2}";
        }
        private void RebootTimer(System.Windows.Forms.Timer timer, TextBox timeBox, int starttime, ref int time)
        {
            if (timer.Enabled) timer.Stop();
            time = starttime;
            timeBox.Text = $"{(time / 60)}:{(time % 60):D2}";

        }
        private void TxtBoxRetentionBlueTextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(TxtBoxRetentionBlue, ref _retentionBlueSecond);

            }
            finally
            {
                _isInternalChange = false;
            }
        }
        private void TxtBoxRetentionRedTextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(TxtBoxRetentionRed, ref _retentionRedSecond);
            }
            finally
            {
                _isInternalChange = false;
            }
        }

        private void MainTimeTextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(MainTime, ref _remainingSeconds);

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
      TextBox timeBox, ref int timeInSeconds, string mode)
        {
            if (!timer.Enabled && !timeBox.Text.Contains('_'))
            {
                StopHoldTimer(timer);
                timer.Start();
                button.Text = "Стоп";
                if (timer == ContractionTimer)
                    viewerForm.SetMainForeColor(true);
            }
            else if (timer.Enabled && button.Text == "Стоп")
            {
                timer.Stop();
                if (timer == ContractionTimer)
                {
                    StopAllTimer();
                    viewerForm.SetMainForeColor(false);
                }
                button.Text = mode;
            }
            else if (timer.Enabled && button.Text != "Стоп")
            {
                StopHoldTimer(timer);
                RebootTimer(timer, timeBox, 0, ref timeInSeconds);
                timer.Start();
                button.Text = "Стоп";
            }
            else
            {
                MessageBox.Show("Введите время полностью в формате m:ss");
            }
        }



        private void StopHoldTimer(System.Windows.Forms.Timer activeTimer)
        {
            if (activeTimer == RedRetentionTimer)
            {
                RedRetentionTimer.Stop();
                BtnRetentionRed.Text = "Удерж";
                BtnPainfulHoldRed.Text = "Болевой";
            }
            else if (activeTimer == BlueRetentionTimer)
            {
                BlueRetentionTimer.Stop();
                BtnRetentionBlue.Text = "Удерж";
                BtnPainfulHoldBlue.Text = "Болевой";
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
            bool nothing = false;
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
                nothing = true;
            }

            int score = Math.Max(0, currentScore);
            _isInternalChange = true;
            scoreBox.Text = score.ToString();
            _isInternalChange = false;
            if (scoreBox == ScoreBlue)
            {
                viewerForm?.SetBlueScore(score);
                viewerForm?.SetPreviousRedWarning(nothing ? -1 : previousWarning);
            }
            else if (scoreBox == ScoreRed)
            {
                viewerForm?.SetRedScore(score);
                viewerForm?.SetPreviousBlueWarning(nothing ? -1 : previousWarning);
               
            }
        }


        private void StopAllTimer()
        {
            ContractionTimer.Stop();
            RedRetentionTimer.Stop();
            BlueRetentionTimer.Stop();

            BtnStartStopMain.Text = "Старт";
            BtnPainfulHoldRed.Text = "Болевой";
            BtnRetentionRed.Text = "Удерж";
            BtnRetentionBlue.Text = "Удерж";
            BtnPainfulHoldBlue.Text = "Болевой";

        }

        private void ModifyScore(TextBox textBox, int change)
        {
            if (int.TryParse(textBox.Text, out int currentScore))
            {
                int newScore = Math.Max(0, currentScore + change);
                textBox.Text = newScore.ToString();
                if (textBox == ScoreBlue)
                    viewerForm.SetBlueScore(newScore);
                else if (textBox == ScoreRed)
                    viewerForm.SetRedScore(newScore);
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

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' ||
                (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                 e.KeyChar != (char)Keys.Delete && e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
               e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

       


        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            viewerForm.SetCategory(TxtBoxCategory.Text);
        }
        private string GetFilePathForCategory()
        {
            string category = TxtBoxCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(category))
                category = "default";

            string fileName = category.Replace(" ", "").Replace("кг", "kg") + ".txt";
            return Path.Combine(folder, fileName);
        }

        private void UpdateAutoComplete()
        {
            string path = GetFilePathForCategory();
            if (!File.Exists(path)) File.Create(path).Close();

            string[] names = File.ReadAllLines(path);
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(names);

            SetupTextBoxAutoComplete(TxtBoxSurnameRed, autoComplete);
            SetupTextBoxAutoComplete(TxtBoxSurnameBlue, autoComplete);

            TxtBoxSurnameRed.PlaceholderText = "Фамилия красного участника";
            TxtBoxSurnameBlue.PlaceholderText = "Фамилия синего участника";
        }
        private void SetupTextBoxAutoComplete(TextBox textBox, AutoCompleteStringCollection source)
        {
            textBox.AutoCompleteCustomSource = source;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SaveNameIfNew(string name)
        {
            string path = GetFilePathForCategory();
            name = name.Trim();
            if (string.IsNullOrWhiteSpace(name)) return;

            var existing = File.ReadAllLines(path);
            if (!existing.Contains(name, StringComparer.OrdinalIgnoreCase))
            {
                File.AppendAllText(path, name + Environment.NewLine);
            }
        }

        private void TxtBoxSurnameRedTextChanged(object sender, EventArgs e)
        {
            viewerForm.SetRedName(TxtBoxSurnameRed.Text);
        }

        private void TxtBoxSurnameBlueTextChanged(object sender, EventArgs e)
        {
            viewerForm.SetBlueName(TxtBoxSurnameBlue.Text);
        }





        private void textBoxCategory_Leave(object sender, EventArgs e)
        {
            UpdateAutoComplete();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            BtnResetMainTimeClick(sender, e);
            BtnResetRetentionRedClick(sender, e);
            BtnResetRetentionBlueClick(sender, e);
            BtnResetMedicalTimeRedClick(sender, e);
            BtnResetMedicalTimeBlueClick(sender, e);
            RedWarning.SelectedIndex = 0;
            BlueWarning.SelectedIndex = 0;
            UpdateWarningScore(BlueWarning, ref _previousBlueWarning, ScoreBlue);
            UpdateWarningScore(RedWarning, ref _previousRedWarning, ScoreRed);
            ScoreRed.Text = "0";
            ScoreBlue.Text = "0";
            viewerForm.SetBlueScore(0);
            viewerForm.SetRedScore(0);
            TxtBoxSurnameRed.Text = "";
            TxtBoxSurnameBlue.Text = "";
            TxtBoxSurnameRedTextChanged(sender, e);
            TxtBoxSurnameBlueTextChanged(sender, e);
        }

        private void TxtBoxGenderTextChanged(object sender, EventArgs e)
        {
            viewerForm.SetGender(TxtBoxGender.Text);
        }

        private void TxtBoxMedicalRedTextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(TxtBoxMedicalRed, ref _medicalTimeRed);
            }
            finally
            {
                _isInternalChange = false;
            }
        }

        private void TxtBoxMedicalBlueTextChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;

            try
            {
                FormatText(TxtBoxMedicalBlue, ref _medicalTimeBlue);
            }
            finally
            {
                _isInternalChange = false;
            }
        }

        private void textBoxRed_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveNameIfNew(TxtBoxSurnameRed.Text);
            UpdateAutoComplete();
        }

        private void textBoxBlue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveNameIfNew(TxtBoxSurnameBlue.Text);
            UpdateAutoComplete();
        }

        private void ScoreRed_TextChanged(object sender, EventArgs e)
        {
            ModifyScore(ScoreRed, 0);
        }

        private void ScoreBlueTextChanged(object sender, EventArgs e)
        {
            ModifyScore(ScoreBlue, 0);
        }
    }
}
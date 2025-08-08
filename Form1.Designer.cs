namespace Scoreboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ScoreRed = new TextBox();
            IncreaseRed = new Button();
            DecreaseRed = new Button();
            DecreaseBlue = new Button();
            IncreaseBlue = new Button();
            ScoreBlue = new TextBox();
            BtnFullScreen = new Button();
            RedWarning = new ComboBox();
            BlueWarning = new ComboBox();
            ContractionTimer = new System.Windows.Forms.Timer(components);
            MainTime = new TextBox();
            BtnStartStopMain = new Button();
            BtnResetMainTime = new Button();
            BtnShowTimeElapsed = new Button();
            TxtBoxRetentionRed = new TextBox();
            RedRetentionTimer = new System.Windows.Forms.Timer(components);
            BtnPainfulHoldRed = new Button();
            BtnRetentionRed = new Button();
            BtnRetentionBlue = new Button();
            BtnPainfulHoldBlue = new Button();
            TxtBoxRetentionBlue = new TextBox();
            BtnResetRetentionRed = new Button();
            BtnResetRetentionBlue = new Button();
            BlueRetentionTimer = new System.Windows.Forms.Timer(components);
            BtnResetMedicalTimeRed = new Button();
            BtnStartStopMedicalTimeRed = new Button();
            TxtBoxMedicalRed = new TextBox();
            BtnResetMedicalTimeBlue = new Button();
            BtnStartStopMedicalTimeBlue = new Button();
            TxtBoxMedicalBlue = new TextBox();
            RedTimeMedical = new System.Windows.Forms.Timer(components);
            TxtBoxSurnameRed = new TextBox();
            TxtBoxSurnameBlue = new TextBox();
            BlueTimeMedical = new System.Windows.Forms.Timer(components);
            TxtBoxCategory = new TextBox();
            BtnResetAll = new Button();
            TxtBoxGender = new TextBox();
            SuspendLayout();
            // 
            // ScoreRed
            // 
            ScoreRed.AccessibleRole = AccessibleRole.None;
            ScoreRed.AutoCompleteMode = AutoCompleteMode.Suggest;
            ScoreRed.Font = new Font("Segoe UI", 45F);
            ScoreRed.Location = new Point(537, 44);
            ScoreRed.MaxLength = 2;
            ScoreRed.Name = "ScoreRed";
            ScoreRed.Size = new Size(73, 87);
            ScoreRed.TabIndex = 0;
            ScoreRed.TabStop = false;
            ScoreRed.Text = "0";
            ScoreRed.TextAlign = HorizontalAlignment.Center;
            ScoreRed.TextChanged += ScoreRed_TextChanged;
            ScoreRed.KeyPress += NumericTextBox_KeyPress;
            // 
            // IncreaseRed
            // 
            IncreaseRed.BackgroundImage = (Image)resources.GetObject("IncreaseRed.BackgroundImage");
            IncreaseRed.BackgroundImageLayout = ImageLayout.Zoom;
            IncreaseRed.Cursor = Cursors.Hand;
            IncreaseRed.FlatStyle = FlatStyle.Popup;
            IncreaseRed.Location = new Point(616, 44);
            IncreaseRed.Name = "IncreaseRed";
            IncreaseRed.Size = new Size(75, 41);
            IncreaseRed.TabIndex = 1;
            IncreaseRed.TabStop = false;
            IncreaseRed.UseVisualStyleBackColor = true;
            IncreaseRed.Click += IncreaseScore_Click;
            // 
            // DecreaseRed
            // 
            DecreaseRed.BackgroundImage = (Image)resources.GetObject("DecreaseRed.BackgroundImage");
            DecreaseRed.BackgroundImageLayout = ImageLayout.Zoom;
            DecreaseRed.Cursor = Cursors.Hand;
            DecreaseRed.FlatStyle = FlatStyle.Popup;
            DecreaseRed.Location = new Point(616, 91);
            DecreaseRed.Name = "DecreaseRed";
            DecreaseRed.Size = new Size(75, 40);
            DecreaseRed.TabIndex = 2;
            DecreaseRed.TabStop = false;
            DecreaseRed.UseVisualStyleBackColor = true;
            DecreaseRed.Click += DecreaseScore_Click;
            // 
            // DecreaseBlue
            // 
            DecreaseBlue.BackgroundImage = (Image)resources.GetObject("DecreaseBlue.BackgroundImage");
            DecreaseBlue.BackgroundImageLayout = ImageLayout.Zoom;
            DecreaseBlue.Cursor = Cursors.Hand;
            DecreaseBlue.FlatStyle = FlatStyle.Popup;
            DecreaseBlue.Location = new Point(616, 388);
            DecreaseBlue.Name = "DecreaseBlue";
            DecreaseBlue.Size = new Size(75, 40);
            DecreaseBlue.TabIndex = 5;
            DecreaseBlue.TabStop = false;
            DecreaseBlue.UseVisualStyleBackColor = true;
            DecreaseBlue.Click += DecreaseScore_Click;
            // 
            // IncreaseBlue
            // 
            IncreaseBlue.BackgroundImage = (Image)resources.GetObject("IncreaseBlue.BackgroundImage");
            IncreaseBlue.BackgroundImageLayout = ImageLayout.Zoom;
            IncreaseBlue.Cursor = Cursors.Hand;
            IncreaseBlue.FlatStyle = FlatStyle.Popup;
            IncreaseBlue.Location = new Point(616, 341);
            IncreaseBlue.Name = "IncreaseBlue";
            IncreaseBlue.Size = new Size(75, 42);
            IncreaseBlue.TabIndex = 4;
            IncreaseBlue.TabStop = false;
            IncreaseBlue.UseVisualStyleBackColor = true;
            IncreaseBlue.Click += IncreaseScore_Click;
            // 
            // ScoreBlue
            // 
            ScoreBlue.AccessibleRole = AccessibleRole.None;
            ScoreBlue.AutoCompleteMode = AutoCompleteMode.Suggest;
            ScoreBlue.Font = new Font("Segoe UI", 45F);
            ScoreBlue.Location = new Point(537, 341);
            ScoreBlue.MaxLength = 2;
            ScoreBlue.Name = "ScoreBlue";
            ScoreBlue.Size = new Size(73, 87);
            ScoreBlue.TabIndex = 3;
            ScoreBlue.TabStop = false;
            ScoreBlue.Text = "0";
            ScoreBlue.TextAlign = HorizontalAlignment.Center;
            ScoreBlue.TextChanged += ScoreBlueTextChanged;
            ScoreBlue.KeyPress += ValidateInputDigitsAndColon;
            // 
            // BtnFullScreen
            // 
            BtnFullScreen.Location = new Point(12, 449);
            BtnFullScreen.Name = "BtnFullScreen";
            BtnFullScreen.Size = new Size(75, 23);
            BtnFullScreen.TabIndex = 6;
            BtnFullScreen.Text = "Scoreboard";
            BtnFullScreen.UseVisualStyleBackColor = true;
            BtnFullScreen.Click += BtnFullScreenClick;
            // 
            // RedWarning
            // 
            RedWarning.DropDownStyle = ComboBoxStyle.DropDownList;
            RedWarning.FormattingEnabled = true;
            RedWarning.Items.AddRange(new object[] { "Нет", "0", "1", "2" });
            RedWarning.Location = new Point(537, 141);
            RedWarning.Name = "RedWarning";
            RedWarning.Size = new Size(73, 23);
            RedWarning.TabIndex = 7;
            RedWarning.SelectedIndexChanged += WarningSelectedIndexChanged;
            // 
            // BlueWarning
            // 
            BlueWarning.DropDownStyle = ComboBoxStyle.DropDownList;
            BlueWarning.FormattingEnabled = true;
            BlueWarning.Items.AddRange(new object[] { "Нет", "0", "1", "2" });
            BlueWarning.Location = new Point(537, 312);
            BlueWarning.Name = "BlueWarning";
            BlueWarning.Size = new Size(73, 23);
            BlueWarning.TabIndex = 8;
            BlueWarning.SelectedIndexChanged += WarningSelectedIndexChanged;
            // 
            // ContractionTimer
            // 
            ContractionTimer.Interval = 1000;
            ContractionTimer.Tick += ContractionTimerTick;
            // 
            // MainTime
            // 
            MainTime.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainTime.Location = new Point(173, 166);
            MainTime.Name = "MainTime";
            MainTime.Size = new Size(235, 135);
            MainTime.TabIndex = 9;
            MainTime.Text = "5:00";
            MainTime.TextAlign = HorizontalAlignment.Center;
            MainTime.TextChanged += MainTimeTextChanged;
            MainTime.KeyPress += ValidateInputDigitsAndColon;
            // 
            // BtnStartStopMain
            // 
            BtnStartStopMain.Location = new Point(426, 166);
            BtnStartStopMain.Name = "BtnStartStopMain";
            BtnStartStopMain.Size = new Size(75, 40);
            BtnStartStopMain.TabIndex = 10;
            BtnStartStopMain.Text = "Старт";
            BtnStartStopMain.UseVisualStyleBackColor = true;
            BtnStartStopMain.Click += BtnStartStopMainClick;
            // 
            // BtnResetMainTime
            // 
            BtnResetMainTime.Location = new Point(426, 222);
            BtnResetMainTime.Name = "BtnResetMainTime";
            BtnResetMainTime.Size = new Size(75, 40);
            BtnResetMainTime.TabIndex = 11;
            BtnResetMainTime.Text = "Сброс";
            BtnResetMainTime.UseVisualStyleBackColor = true;
            BtnResetMainTime.Click += BtnResetMainTimeClick;
            // 
            // BtnShowTimeElapsed
            // 
            BtnShowTimeElapsed.Location = new Point(426, 277);
            BtnShowTimeElapsed.Name = "BtnShowTimeElapsed";
            BtnShowTimeElapsed.Size = new Size(75, 23);
            BtnShowTimeElapsed.TabIndex = 12;
            BtnShowTimeElapsed.Text = "Время";
            BtnShowTimeElapsed.UseVisualStyleBackColor = true;
            BtnShowTimeElapsed.Click += BtnShowTimeElapsedClick;
            // 
            // TxtBoxRetentionRed
            // 
            TxtBoxRetentionRed.BackColor = SystemColors.Window;
            TxtBoxRetentionRed.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TxtBoxRetentionRed.ForeColor = SystemColors.WindowText;
            TxtBoxRetentionRed.Location = new Point(525, 170);
            TxtBoxRetentionRed.Multiline = true;
            TxtBoxRetentionRed.Name = "TxtBoxRetentionRed";
            TxtBoxRetentionRed.Size = new Size(85, 50);
            TxtBoxRetentionRed.TabIndex = 13;
            TxtBoxRetentionRed.Text = "0:00";
            TxtBoxRetentionRed.TextChanged += TxtBoxRetentionRedTextChanged;
            // 
            // RedRetentionTimer
            // 
            RedRetentionTimer.Interval = 1000;
            RedRetentionTimer.Tick += RedRetentionTimerTick;
            // 
            // BtnPainfulHoldRed
            // 
            BtnPainfulHoldRed.Location = new Point(616, 141);
            BtnPainfulHoldRed.Name = "BtnPainfulHoldRed";
            BtnPainfulHoldRed.Size = new Size(75, 23);
            BtnPainfulHoldRed.TabIndex = 14;
            BtnPainfulHoldRed.Text = "Болевой";
            BtnPainfulHoldRed.UseVisualStyleBackColor = true;
            BtnPainfulHoldRed.Click += BtnRetentionRedClick;
            // 
            // BtnRetentionRed
            // 
            BtnRetentionRed.Location = new Point(616, 168);
            BtnRetentionRed.Name = "BtnRetentionRed";
            BtnRetentionRed.Size = new Size(75, 23);
            BtnRetentionRed.TabIndex = 15;
            BtnRetentionRed.Text = "Удерж";
            BtnRetentionRed.UseVisualStyleBackColor = true;
            BtnRetentionRed.Click += BtnPainfulHoldRedClick;
            // 
            // BtnRetentionBlue
            // 
            BtnRetentionBlue.Location = new Point(616, 283);
            BtnRetentionBlue.Name = "BtnRetentionBlue";
            BtnRetentionBlue.Size = new Size(75, 23);
            BtnRetentionBlue.TabIndex = 18;
            BtnRetentionBlue.Text = "Удерж";
            BtnRetentionBlue.UseVisualStyleBackColor = true;
            BtnRetentionBlue.Click += BtnPainfulHoldBlueClick;
            // 
            // BtnPainfulHoldBlue
            // 
            BtnPainfulHoldBlue.Location = new Point(616, 311);
            BtnPainfulHoldBlue.Name = "BtnPainfulHoldBlue";
            BtnPainfulHoldBlue.Size = new Size(75, 23);
            BtnPainfulHoldBlue.TabIndex = 17;
            BtnPainfulHoldBlue.Text = "Болевой";
            BtnPainfulHoldBlue.UseVisualStyleBackColor = true;
            BtnPainfulHoldBlue.Click += BtnRetentionBlueClick;
            // 
            // TxtBoxRetentionBlue
            // 
            TxtBoxRetentionBlue.BackColor = SystemColors.Window;
            TxtBoxRetentionBlue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TxtBoxRetentionBlue.Location = new Point(525, 256);
            TxtBoxRetentionBlue.Multiline = true;
            TxtBoxRetentionBlue.Name = "TxtBoxRetentionBlue";
            TxtBoxRetentionBlue.Size = new Size(85, 50);
            TxtBoxRetentionBlue.TabIndex = 16;
            TxtBoxRetentionBlue.Text = "0:00";
            TxtBoxRetentionBlue.TextChanged += TxtBoxRetentionBlueTextChanged;
            // 
            // BtnResetRetentionRed
            // 
            BtnResetRetentionRed.Location = new Point(616, 197);
            BtnResetRetentionRed.Name = "BtnResetRetentionRed";
            BtnResetRetentionRed.Size = new Size(75, 23);
            BtnResetRetentionRed.TabIndex = 19;
            BtnResetRetentionRed.Text = "Сброс";
            BtnResetRetentionRed.UseVisualStyleBackColor = true;
            BtnResetRetentionRed.Click += BtnResetRetentionRedClick;
            // 
            // BtnResetRetentionBlue
            // 
            BtnResetRetentionBlue.Location = new Point(616, 256);
            BtnResetRetentionBlue.Name = "BtnResetRetentionBlue";
            BtnResetRetentionBlue.Size = new Size(75, 23);
            BtnResetRetentionBlue.TabIndex = 20;
            BtnResetRetentionBlue.Text = "Сброс";
            BtnResetRetentionBlue.UseVisualStyleBackColor = true;
            BtnResetRetentionBlue.Click += BtnResetRetentionBlueClick;
            // 
            // BlueRetentionTimer
            // 
            BlueRetentionTimer.Interval = 1000;
            BlueRetentionTimer.Tick += BlueRetentionTimerTick;
            // 
            // BtnResetMedicalTimeRed
            // 
            BtnResetMedicalTimeRed.Location = new Point(388, 91);
            BtnResetMedicalTimeRed.Name = "BtnResetMedicalTimeRed";
            BtnResetMedicalTimeRed.Size = new Size(75, 23);
            BtnResetMedicalTimeRed.TabIndex = 23;
            BtnResetMedicalTimeRed.Text = "Сброс";
            BtnResetMedicalTimeRed.UseVisualStyleBackColor = true;
            BtnResetMedicalTimeRed.Click += BtnResetMedicalTimeRedClick;
            // 
            // BtnStartStopMedicalTimeRed
            // 
            BtnStartStopMedicalTimeRed.Location = new Point(388, 62);
            BtnStartStopMedicalTimeRed.Name = "BtnStartStopMedicalTimeRed";
            BtnStartStopMedicalTimeRed.Size = new Size(75, 23);
            BtnStartStopMedicalTimeRed.TabIndex = 22;
            BtnStartStopMedicalTimeRed.Text = "Старт";
            BtnStartStopMedicalTimeRed.UseVisualStyleBackColor = true;
            BtnStartStopMedicalTimeRed.Click += BtnStartStopMedicalTimeRedClick;
            // 
            // TxtBoxMedicalRed
            // 
            TxtBoxMedicalRed.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TxtBoxMedicalRed.Location = new Point(228, 44);
            TxtBoxMedicalRed.Multiline = true;
            TxtBoxMedicalRed.Name = "TxtBoxMedicalRed";
            TxtBoxMedicalRed.Size = new Size(144, 91);
            TxtBoxMedicalRed.TabIndex = 21;
            TxtBoxMedicalRed.Text = "0:00";
            TxtBoxMedicalRed.TextChanged += TxtBoxMedicalRedTextChanged;
            // 
            // BtnResetMedicalTimeBlue
            // 
            BtnResetMedicalTimeBlue.Location = new Point(388, 388);
            BtnResetMedicalTimeBlue.Name = "BtnResetMedicalTimeBlue";
            BtnResetMedicalTimeBlue.Size = new Size(75, 23);
            BtnResetMedicalTimeBlue.TabIndex = 26;
            BtnResetMedicalTimeBlue.Text = "Сброс";
            BtnResetMedicalTimeBlue.UseVisualStyleBackColor = true;
            BtnResetMedicalTimeBlue.Click += BtnResetMedicalTimeBlueClick;
            // 
            // BtnStartStopMedicalTimeBlue
            // 
            BtnStartStopMedicalTimeBlue.Location = new Point(388, 359);
            BtnStartStopMedicalTimeBlue.Name = "BtnStartStopMedicalTimeBlue";
            BtnStartStopMedicalTimeBlue.Size = new Size(75, 23);
            BtnStartStopMedicalTimeBlue.TabIndex = 25;
            BtnStartStopMedicalTimeBlue.Text = "Старт";
            BtnStartStopMedicalTimeBlue.UseVisualStyleBackColor = true;
            BtnStartStopMedicalTimeBlue.Click += BtnStartStopMedicalTimeBlueClick;
            // 
            // TxtBoxMedicalBlue
            // 
            TxtBoxMedicalBlue.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TxtBoxMedicalBlue.Location = new Point(228, 341);
            TxtBoxMedicalBlue.Multiline = true;
            TxtBoxMedicalBlue.Name = "TxtBoxMedicalBlue";
            TxtBoxMedicalBlue.Size = new Size(144, 87);
            TxtBoxMedicalBlue.TabIndex = 24;
            TxtBoxMedicalBlue.Text = "0:00";
            TxtBoxMedicalBlue.TextChanged += TxtBoxMedicalBlueTextChanged;
            // 
            // RedTimeMedical
            // 
            RedTimeMedical.Interval = 1000;
            RedTimeMedical.Tick += RedTimeMedicalTick;
            // 
            // TxtBoxSurnameRed
            // 
            TxtBoxSurnameRed.Font = new Font("Segoe UI", 20F);
            TxtBoxSurnameRed.Location = new Point(12, 62);
            TxtBoxSurnameRed.MaxLength = 12;
            TxtBoxSurnameRed.Name = "TxtBoxSurnameRed";
            TxtBoxSurnameRed.Size = new Size(200, 43);
            TxtBoxSurnameRed.TabIndex = 27;
            TxtBoxSurnameRed.Text = "Красный";
            TxtBoxSurnameRed.TextChanged += TxtBoxSurnameRedTextChanged;
            TxtBoxSurnameRed.Validating += textBoxRed_Validating;
            // 
            // TxtBoxSurnameBlue
            // 
            TxtBoxSurnameBlue.Font = new Font("Segoe UI", 20F);
            TxtBoxSurnameBlue.Location = new Point(12, 352);
            TxtBoxSurnameBlue.MaxLength = 12;
            TxtBoxSurnameBlue.Name = "TxtBoxSurnameBlue";
            TxtBoxSurnameBlue.Size = new Size(200, 43);
            TxtBoxSurnameBlue.TabIndex = 28;
            TxtBoxSurnameBlue.Text = "Синий";
            TxtBoxSurnameBlue.TextChanged += TxtBoxSurnameBlueTextChanged;
            TxtBoxSurnameBlue.Validating += textBoxBlue_Validating;
            // 
            // BlueTimeMedical
            // 
            BlueTimeMedical.Interval = 1000;
            BlueTimeMedical.Tick += BlueTimeMedicalTick;
            // 
            // TxtBoxCategory
            // 
            TxtBoxCategory.Font = new Font("Segoe UI", 20F);
            TxtBoxCategory.Location = new Point(12, 222);
            TxtBoxCategory.MaxLength = 4;
            TxtBoxCategory.Name = "TxtBoxCategory";
            TxtBoxCategory.Size = new Size(75, 43);
            TxtBoxCategory.TabIndex = 29;
            TxtBoxCategory.Text = "64";
            TxtBoxCategory.TextAlign = HorizontalAlignment.Center;
            TxtBoxCategory.TextChanged += textBoxCategory_TextChanged;
            TxtBoxCategory.KeyPress += Numeric_KeyPress;
            TxtBoxCategory.Leave += textBoxCategory_Leave;
            // 
            // BtnResetAll
            // 
            BtnResetAll.Location = new Point(623, 449);
            BtnResetAll.Name = "BtnResetAll";
            BtnResetAll.Size = new Size(75, 23);
            BtnResetAll.TabIndex = 30;
            BtnResetAll.Text = "Сброс";
            BtnResetAll.UseVisualStyleBackColor = true;
            BtnResetAll.Click += Reset_Click;
            // 
            // TxtBoxGender
            // 
            TxtBoxGender.Font = new Font("Segoe UI", 20F);
            TxtBoxGender.Location = new Point(102, 222);
            TxtBoxGender.MaxLength = 1;
            TxtBoxGender.Name = "TxtBoxGender";
            TxtBoxGender.Size = new Size(36, 43);
            TxtBoxGender.TabIndex = 31;
            TxtBoxGender.Text = "М";
            TxtBoxGender.TextAlign = HorizontalAlignment.Center;
            TxtBoxGender.TextChanged += TxtBoxGenderTextChanged;
            // 
            // Form1
            // 
            AcceptButton = BtnFullScreen;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(710, 484);
            Controls.Add(TxtBoxGender);
            Controls.Add(BtnResetAll);
            Controls.Add(TxtBoxCategory);
            Controls.Add(TxtBoxSurnameBlue);
            Controls.Add(TxtBoxSurnameRed);
            Controls.Add(BtnResetMedicalTimeBlue);
            Controls.Add(BtnStartStopMedicalTimeBlue);
            Controls.Add(TxtBoxMedicalBlue);
            Controls.Add(BtnResetMedicalTimeRed);
            Controls.Add(BtnStartStopMedicalTimeRed);
            Controls.Add(TxtBoxMedicalRed);
            Controls.Add(BtnResetRetentionBlue);
            Controls.Add(BtnResetRetentionRed);
            Controls.Add(BtnRetentionBlue);
            Controls.Add(BtnPainfulHoldBlue);
            Controls.Add(TxtBoxRetentionBlue);
            Controls.Add(BtnRetentionRed);
            Controls.Add(BtnPainfulHoldRed);
            Controls.Add(TxtBoxRetentionRed);
            Controls.Add(BtnShowTimeElapsed);
            Controls.Add(BtnResetMainTime);
            Controls.Add(BtnStartStopMain);
            Controls.Add(MainTime);
            Controls.Add(BlueWarning);
            Controls.Add(RedWarning);
            Controls.Add(BtnFullScreen);
            Controls.Add(DecreaseBlue);
            Controls.Add(IncreaseBlue);
            Controls.Add(ScoreBlue);
            Controls.Add(DecreaseRed);
            Controls.Add(IncreaseRed);
            Controls.Add(ScoreRed);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ScoreRed;
        private Button DecreaseRed;
        private Button DecreaseBlue;
        private Button IncreaseBlue;
        private TextBox ScoreBlue;
        private Button BtnFullScreen;
        private ComboBox RedWarning;
        private ComboBox BlueWarning;
        private System.Windows.Forms.Timer ContractionTimer;
        private TextBox MainTime;
        private Button BtnStartStopMain;
        private Button BtnResetMainTime;
        private Button BtnShowTimeElapsed;
        private TextBox TxtBoxRetentionRed;
        private System.Windows.Forms.Timer RedRetentionTimer;
        private Button BtnPainfulHoldRed;
        private Button BtnRetentionRed;
        private Button BtnRetentionBlue;
        private Button BtnPainfulHoldBlue;
        private TextBox TxtBoxRetentionBlue;
        private Button BtnResetRetentionRed;
        private Button BtnResetRetentionBlue;
        private System.Windows.Forms.Timer BlueRetentionTimer;
        private Button BtnResetMedicalTimeRed;
        private Button BtnStartStopMedicalTimeRed;
        private TextBox TxtBoxMedicalRed;
        private Button BtnResetMedicalTimeBlue;
        private Button BtnStartStopMedicalTimeBlue;
        private TextBox TxtBoxMedicalBlue;
        private System.Windows.Forms.Timer RedTimeMedical;
        private TextBox TxtBoxSurnameRed;
        private TextBox TxtBoxSurnameBlue;
        private System.Windows.Forms.Timer BlueTimeMedical;
        private TextBox TxtBoxCategory;
        private Button BtnResetAll;
        private TextBox TxtBoxGender;
        private Button IncreaseRed;
    }
}

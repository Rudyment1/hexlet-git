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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ContractionTimer = new System.Windows.Forms.Timer(components);
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox4 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            textBox5 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            button15 = new Button();
            button16 = new Button();
            textBox6 = new TextBox();
            button17 = new Button();
            button18 = new Button();
            textBox7 = new TextBox();
            timer3 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.None;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Font = new Font("Segoe UI", 45F);
            textBox1.Location = new Point(537, 44);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 87);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += NumericTextBox_KeyPress;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(616, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += IncreaseScore_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(616, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += DecreaseScore_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(616, 388);
            button4.Name = "button4";
            button4.Size = new Size(75, 40);
            button4.TabIndex = 5;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += DecreaseScore_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(616, 341);
            button3.Name = "button3";
            button3.Size = new Size(75, 42);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += IncreaseScore_Click;
            // 
            // textBox2
            // 
            textBox2.AccessibleRole = AccessibleRole.None;
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.Font = new Font("Segoe UI", 45F);
            textBox2.Location = new Point(537, 341);
            textBox2.MaxLength = 2;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 87);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += ValidateInputDigitsAndColon;
            // 
            // button5
            // 
            button5.Location = new Point(22, 405);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Нет", "0", "1", "2" });
            comboBox1.Location = new Point(537, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(73, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Нет", "0", "1", "2" });
            comboBox2.Location = new Point(537, 312);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(73, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // ContractionTimer
            // 
            ContractionTimer.Interval = 1000;
            ContractionTimer.Tick += ContractionTimer_Tick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(173, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 135);
            textBox3.TabIndex = 9;
            textBox3.Text = "5:00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += ValidateInputDigitsAndColon;
            // 
            // button6
            // 
            button6.Location = new Point(426, 166);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Старт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(426, 222);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Сброс";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(426, 277);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 12;
            button8.Text = "Время";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(525, 170);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(85, 50);
            textBox4.TabIndex = 13;
            textBox4.Text = "0:00";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button9
            // 
            button9.Location = new Point(616, 141);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 14;
            button9.Text = "Болевой";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(616, 168);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 15;
            button10.Text = "Удерж";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(616, 283);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 18;
            button11.Text = "Удерж";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(616, 311);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 17;
            button12.Text = "Болевой";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(525, 256);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 50);
            textBox5.TabIndex = 16;
            textBox5.Text = "0:00";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button13
            // 
            button13.Location = new Point(616, 197);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 19;
            button13.Text = "Сброс";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(616, 256);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 20;
            button14.Text = "Сброс";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button15
            // 
            button15.Location = new Point(388, 91);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 23;
            button15.Text = "Сброс";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(388, 62);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 22;
            button16.Text = "Старт";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(228, 44);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 91);
            textBox6.TabIndex = 21;
            textBox6.Text = "0:00";
            // 
            // button17
            // 
            button17.Location = new Point(388, 388);
            button17.Name = "button17";
            button17.Size = new Size(75, 23);
            button17.TabIndex = 26;
            button17.Text = "Сброс";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(388, 359);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 25;
            button18.Text = "Удерж";
            button18.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(228, 341);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(144, 87);
            textBox7.TabIndex = 24;
            textBox7.Text = "0:00";
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AcceptButton = button5;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(710, 455);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(textBox7);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(textBox6);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(textBox5);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(textBox4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button2;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Button button5;
        internal Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private System.Windows.Forms.Timer ContractionTimer;
        private TextBox textBox3;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox textBox5;
        private Button button13;
        private Button button14;
        private System.Windows.Forms.Timer timer2;
        private Button button15;
        private Button button16;
        private TextBox textBox6;
        private Button button17;
        private Button button18;
        private TextBox textBox7;
        private System.Windows.Forms.Timer timer3;
    }
}

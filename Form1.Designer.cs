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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.None;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Font = new Font("Segoe UI", 45F);
            textBox1.Location = new Point(535, 52);
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
            button1.Location = new Point(614, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
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
            button2.Location = new Point(614, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 48);
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
            button4.Location = new Point(614, 392);
            button4.Name = "button4";
            button4.Size = new Size(75, 48);
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
            button3.Location = new Point(614, 349);
            button3.Name = "button3";
            button3.Size = new Size(75, 48);
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
            textBox2.Location = new Point(535, 349);
            textBox2.MaxLength = 2;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 87);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.Location = new Point(20, 413);
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
            comboBox1.Location = new Point(535, 149);
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
            comboBox2.Location = new Point(535, 320);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(73, 23);
            comboBox2.TabIndex = 8;
            // 
            // ContractionTimer
            // 
            ContractionTimer.Interval = 1000;
            ContractionTimer.Tick += ContractionTimer_Tick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(178, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 135);
            textBox3.TabIndex = 9;
            textBox3.Text = "3:00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // button6
            // 
            button6.Location = new Point(431, 181);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Старт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(431, 237);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(431, 292);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 12;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = button5;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(710, 455);
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
    }
}

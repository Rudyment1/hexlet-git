namespace Scoreboard
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            Warning2Red = new Label();
            lblRedName = new Label();
            Warning1Red = new Label();
            HoldTimeRed = new Label();
            Warning0Red = new Label();
            lblRedScore = new Label();
            panel2 = new Panel();
            Warning2Blue = new Label();
            Warning1Blue = new Label();
            Warning0Blue = new Label();
            lblBlueName = new Label();
            HoldTimeBlue = new Label();
            lblBlueScore = new Label();
            panel3 = new Panel();
            label1 = new Label();
            WeightСategory = new Label();
            lblMainTime = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(Warning2Red);
            panel1.Controls.Add(lblRedName);
            panel1.Controls.Add(Warning1Red);
            panel1.Controls.Add(HoldTimeRed);
            panel1.Controls.Add(Warning0Red);
            panel1.Controls.Add(lblRedScore);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 180);
            panel1.TabIndex = 0;
            // 
            // Warning2Red
            // 
            Warning2Red.AutoSize = true;
            Warning2Red.BackColor = Color.Yellow;
            Warning2Red.Font = new Font("Segoe UI", 25F);
            Warning2Red.ForeColor = SystemColors.InactiveCaptionText;
            Warning2Red.Location = new Point(446, 9);
            Warning2Red.Name = "Warning2Red";
            Warning2Red.Size = new Size(38, 46);
            Warning2Red.TabIndex = 10;
            Warning2Red.Text = "2";
            Warning2Red.Visible = false;
            // 
            // lblRedName
            // 
            lblRedName.AutoSize = true;
            lblRedName.Font = new Font("Segoe UI", 50F);
            lblRedName.ForeColor = SystemColors.Window;
            lblRedName.Location = new Point(3, 5);
            lblRedName.Name = "lblRedName";
            lblRedName.Size = new Size(307, 89);
            lblRedName.TabIndex = 3;
            lblRedName.Text = "Красный";
            // 
            // Warning1Red
            // 
            Warning1Red.AutoSize = true;
            Warning1Red.BackColor = Color.Yellow;
            Warning1Red.Font = new Font("Segoe UI", 25F);
            Warning1Red.ForeColor = SystemColors.InactiveCaptionText;
            Warning1Red.Location = new Point(490, 9);
            Warning1Red.Name = "Warning1Red";
            Warning1Red.Size = new Size(38, 46);
            Warning1Red.TabIndex = 9;
            Warning1Red.Text = "1";
            Warning1Red.Visible = false;
            // 
            // HoldTimeRed
            // 
            HoldTimeRed.AutoSize = true;
            HoldTimeRed.Font = new Font("Segoe UI", 50F);
            HoldTimeRed.ForeColor = SystemColors.Window;
            HoldTimeRed.Location = new Point(370, 95);
            HoldTimeRed.Name = "HoldTimeRed";
            HoldTimeRed.Size = new Size(0, 89);
            HoldTimeRed.TabIndex = 2;
            // 
            // Warning0Red
            // 
            Warning0Red.AutoSize = true;
            Warning0Red.BackColor = Color.Yellow;
            Warning0Red.Font = new Font("Segoe UI", 25F);
            Warning0Red.ForeColor = SystemColors.InactiveCaptionText;
            Warning0Red.Location = new Point(534, 9);
            Warning0Red.Name = "Warning0Red";
            Warning0Red.Size = new Size(38, 46);
            Warning0Red.TabIndex = 8;
            Warning0Red.Text = "0";
            Warning0Red.Visible = false;
            // 
            // lblRedScore
            // 
            lblRedScore.Font = new Font("Segoe UI", 90F);
            lblRedScore.ForeColor = SystemColors.Window;
            lblRedScore.Location = new Point(581, 0);
            lblRedScore.Name = "lblRedScore";
            lblRedScore.Size = new Size(200, 181);
            lblRedScore.TabIndex = 1;
            lblRedScore.Text = "0";
            lblRedScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(Warning2Blue);
            panel2.Controls.Add(Warning1Blue);
            panel2.Controls.Add(Warning0Blue);
            panel2.Controls.Add(lblBlueName);
            panel2.Controls.Add(HoldTimeBlue);
            panel2.Controls.Add(lblBlueScore);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 180);
            panel2.TabIndex = 1;
            // 
            // Warning2Blue
            // 
            Warning2Blue.AutoSize = true;
            Warning2Blue.BackColor = Color.Yellow;
            Warning2Blue.Font = new Font("Segoe UI", 25F);
            Warning2Blue.ForeColor = SystemColors.InactiveCaptionText;
            Warning2Blue.Location = new Point(446, 118);
            Warning2Blue.Name = "Warning2Blue";
            Warning2Blue.Size = new Size(38, 46);
            Warning2Blue.TabIndex = 7;
            Warning2Blue.Text = "2";
            Warning2Blue.Visible = false;
            // 
            // Warning1Blue
            // 
            Warning1Blue.AutoSize = true;
            Warning1Blue.BackColor = Color.Yellow;
            Warning1Blue.Font = new Font("Segoe UI", 25F);
            Warning1Blue.ForeColor = SystemColors.InactiveCaptionText;
            Warning1Blue.Location = new Point(490, 118);
            Warning1Blue.Name = "Warning1Blue";
            Warning1Blue.Size = new Size(38, 46);
            Warning1Blue.TabIndex = 6;
            Warning1Blue.Text = "1";
            Warning1Blue.Visible = false;
            // 
            // Warning0Blue
            // 
            Warning0Blue.AutoSize = true;
            Warning0Blue.BackColor = Color.Yellow;
            Warning0Blue.Font = new Font("Segoe UI", 25F);
            Warning0Blue.ForeColor = SystemColors.InactiveCaptionText;
            Warning0Blue.Location = new Point(534, 118);
            Warning0Blue.Name = "Warning0Blue";
            Warning0Blue.Size = new Size(38, 46);
            Warning0Blue.TabIndex = 5;
            Warning0Blue.Text = "0";
            Warning0Blue.Visible = false;
            // 
            // lblBlueName
            // 
            lblBlueName.AutoSize = true;
            lblBlueName.Font = new Font("Segoe UI", 50F);
            lblBlueName.ForeColor = SystemColors.Window;
            lblBlueName.Location = new Point(0, 82);
            lblBlueName.Name = "lblBlueName";
            lblBlueName.Size = new Size(235, 89);
            lblBlueName.TabIndex = 4;
            lblBlueName.Text = "Синий";
            // 
            // HoldTimeBlue
            // 
            HoldTimeBlue.AutoSize = true;
            HoldTimeBlue.Font = new Font("Segoe UI", 50F);
            HoldTimeBlue.ForeColor = SystemColors.Window;
            HoldTimeBlue.Location = new Point(370, -8);
            HoldTimeBlue.Name = "HoldTimeBlue";
            HoldTimeBlue.Size = new Size(0, 89);
            HoldTimeBlue.TabIndex = 3;
            // 
            // lblBlueScore
            // 
            lblBlueScore.Font = new Font("Segoe UI", 90F);
            lblBlueScore.ForeColor = SystemColors.Window;
            lblBlueScore.Location = new Point(581, 0);
            lblBlueScore.Name = "lblBlueScore";
            lblBlueScore.Size = new Size(203, 180);
            lblBlueScore.TabIndex = 0;
            lblBlueScore.Text = "0";
            lblBlueScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(WeightСategory);
            panel3.Controls.Add(lblMainTime);
            panel3.Location = new Point(0, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 162);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 72);
            label1.TabIndex = 2;
            label1.Text = "М";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeightСategory
            // 
            WeightСategory.Font = new Font("Segoe UI", 35F);
            WeightСategory.ForeColor = SystemColors.Window;
            WeightСategory.Location = new Point(0, 78);
            WeightСategory.Name = "WeightСategory";
            WeightСategory.Size = new Size(137, 67);
            WeightСategory.TabIndex = 1;
            WeightСategory.Text = "64";
            WeightСategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainTime
            // 
            lblMainTime.AutoSize = true;
            lblMainTime.Font = new Font("Segoe UI", 90F);
            lblMainTime.ForeColor = Color.Yellow;
            lblMainTime.Location = new Point(129, 0);
            lblMainTime.Name = "lblMainTime";
            lblMainTime.Size = new Size(288, 159);
            lblMainTime.TabIndex = 0;
            lblMainTime.Text = "5:00";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 361);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Табло";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblMainTime;
        private Label WeightСategory;
        private Label lblBlueScore;
        private Label label1;
        private Label lblRedScore;
        private Label HoldTimeRed;
        private Label HoldTimeBlue;
        private Label lblRedName;
        private Label lblBlueName;
        private Label Warning2Red;
        private Label Warning1Red;
        private Label Warning0Red;
        private Label Warning2Blue;
        private Label Warning1Blue;
        private Label Warning0Blue;
    }
}
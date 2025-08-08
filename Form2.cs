using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{

    public partial class Form2 : Form
    {
        private Size _originalFormSize;
        private Dictionary<Control, (Rectangle Bounds, float FontSize)> _originalControls;
        public Form2()
        {
            InitializeComponent();
            _originalFormSize = this.Size;
            _originalControls = new Dictionary<Control, (Rectangle, float)>();

            foreach (Control ctrl in this.Controls)
                SaveControlRecursive(ctrl);

        }

        private void SaveControlRecursive(Control control)
        {
            _originalControls[control] = (control.Bounds, control.Font.Size);
            foreach (Control child in control.Controls)
                SaveControlRecursive(child);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeAllControls();
        }

        private void ResizeAllControls()
        {
            if (_originalControls == null || _originalControls.Count == 0)
                return;

            float xRatio = (float)this.Width / _originalFormSize.Width;
            float yRatio = (float)this.Height / _originalFormSize.Height;

            foreach (var pair in _originalControls)
            {
                Control ctrl = pair.Key;
                if (ctrl == null) continue;

                var (originalBounds, originalFontSize) = pair.Value;
                const int verticalOffset = 5;
                ctrl.Bounds = new Rectangle(
                    (int)(originalBounds.X * xRatio),
                    (int)(originalBounds.Y * yRatio + verticalOffset * yRatio), 
                    (int)(originalBounds.Width * xRatio),
                    (int)(originalBounds.Height * yRatio)
                );

                ctrl.Font = new Font(ctrl.Font.FontFamily, originalFontSize * Math.Min(xRatio, yRatio), ctrl.Font.Style);
            }
            panel1.Height = (this.ClientSize.Height) / 2;
            panel2.Height = (this.ClientSize.Height) / 2;
        }


        public void SetCategory(string weight) => WeightСategory.Text = weight;
        public void SetRedName(string name) => lblRedName.Text = name;
        public void SetBlueName(string name) => lblBlueName.Text = name;

        public void SetRedScore(int score) => lblRedScore.Text = score.ToString();
        public void SetBlueScore(int score) => lblBlueScore.Text = score.ToString();

        public void SetMainTime(string time) => lblMainTime.Text = time;

        public void SetMainForeColor(bool onOff)
        {
            if (onOff){ lblMainTime.ForeColor = Color.White; }
            else { lblMainTime.ForeColor = Color.Yellow; }
        }
        public void SetGender(string MF) => label1.Text = MF;

        public void SetHoldRed(string hold) => HoldTimeRed.Text = hold;
        public void SetHoldBlue(string hold) => HoldTimeBlue.Text = hold;

        public void SetPreviousBlueWarning(int warning)
        {
            if (warning == -1)
            {
                Warning0Blue.Visible = false;
                Warning1Blue.Visible = false;
                Warning2Blue.Visible = false;
            }
            else if (warning == 0)
            {
                Warning0Blue.Visible = true;
                Warning1Blue.Visible = false;
                Warning2Blue.Visible = false;
            }
            else if (warning == 1)
            {
                Warning0Blue.Visible = true;
                Warning1Blue.Visible = true;
                Warning2Blue.Visible = false;
            }
            else if (warning == 2)
            {
                Warning0Blue.Visible = true;
                Warning1Blue.Visible = true;
                Warning2Blue.Visible = true;
            }
        }
        public void SetPreviousRedWarning(int warning)
        {
            if (warning == -1)
            {
                Warning0Red.Visible = false;
                Warning1Red.Visible = false;
                Warning2Red.Visible = false;
            }
            else if (warning == 0)
            {
                Warning0Red.Visible = true;
                Warning1Red.Visible = false;
                Warning2Red.Visible = false;
            }
            else if (warning == 1)
            {
                Warning0Red.Visible = true;
                Warning1Red.Visible = true;
                Warning2Red.Visible = false;
            }
            else if (warning == 2)
            {
                Warning0Red.Visible = true;
                Warning1Red.Visible = true;
                Warning2Red.Visible = true;
            }
        }
        
        public void SetFullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

    }
}

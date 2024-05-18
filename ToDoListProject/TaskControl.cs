using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ToDoListProject
{
    
    public class TaskControl : Control
    {

        public string Name { get; set; }
        public string[] TextLines { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }

        public CheckBox checkBox;

        public TaskControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(275, 40);
            Font = new Font("Verdana", 11F, FontStyle.Regular);
            BackColor = Color.White;

            checkBox = new CheckBox();
            checkBox.Size = new Size(16, 16);
            checkBox.Location = new Point(5, (Height - checkBox.Height) / 2);
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            Controls.Add(checkBox);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle(new Point(0, 0), Size);
            gr.DrawRectangle(new Pen(BackColor), rect);
            gr.FillRectangle(new SolidBrush(BackColor), rect);
            gr.DrawString(Text, Font, new SolidBrush(ForeColor), 50, 10);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Completed = checkBox.Checked;
        }
        public void ShowTask(Panel panel)
        {
            Dock = DockStyle.Top;
            panel.Controls.Add(this);
            BringToFront();
            AdjustLayout(panel);
            Show();
        }
        public void AdjustLayout(Panel container)
        {
            int totalHeight = 0;
            foreach (Control control in container.Controls)
            {
                totalHeight += control.Height;
            }

            if (totalHeight > container.Height)
            {
                container.AutoScroll = true;
            }
            else
            {
                container.AutoScroll = false;
            }
        }
    }
}

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

    public class ModifiedButton : Control
    {
        public int CountTasks { get; set; }
        public Image Image { get; set; }
        public TextBox textBox;

        public ModifiedButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(275, 40);
            Font = new Font("Verdana", 11F, FontStyle.Regular);
            BackColor = Color.White;
            CountTasks = 0;

            textBox = new TextBox();
            textBox.Size = new Size(Width - 80, Height);
            textBox.Location = new Point(50, 7);
            textBox.Enabled = false;
            textBox.TextChanged += TextBox_TextChanged;
            Controls.Add(textBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle(new Point(0, 0), Size);
            gr.DrawRectangle(new Pen(BackColor), rect);
            gr.FillRectangle(new SolidBrush(BackColor), rect);
            Image = Image.FromFile(@"C:\Users\User\Downloads\images.png");
            if (Image != null)
            {
                gr.DrawImage(Image, 0, 0);
            }
            textBox.Text = Text;
            gr.DrawString(CountTasks.ToString(), Font, new SolidBrush(ForeColor), Width - 25, 10);
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Text = textBox.Text;
            Invalidate();
        }
    }
}

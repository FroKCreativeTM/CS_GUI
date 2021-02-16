using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnShown(e);

            //using (Graphics g = this.CreateGraphics())
            //{
            //    g.DrawLine(Pens.Black, 0, 0, 100, 100);
            //}

            //using (Graphics g = this.CreateGraphics())
            //{
            //    using (Pen bluePen = new Pen(Brushes.Blue, 10))
            //    {
            //        g.DrawLine(bluePen, 0, 0, 100, 100);
            //    }
            //}

            //using (Graphics g = this.CreateGraphics())
            //{
            //    using (Brush brush = new SolidBrush(Color.Brown))
            //    using (Pen pen = new Pen(brush, 10))
            //    {
            //        g.DrawLine(pen, 0, 0, 100, 100);
            //    }
            //}

            using (Graphics g = this.CreateGraphics())
            {
                Color color = Color.FromArgb(0x0f, 0xf0, 0x10);
                using (Brush brush = new SolidBrush(color))
                using (Pen pen = new Pen(brush, 10))
                {
                    g.DrawLine(pen, 0, 0, 100, 100);
                }
            }
        }
    }
}

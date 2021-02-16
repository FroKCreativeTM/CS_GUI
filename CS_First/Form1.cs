using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Click += (s, e) =>
            //{
            //    MessageBox.Show("마우스 눌림", "짜잔~");
            //};
        }

        //void Form1_Click(object sender, System.EventArgs e)
        //{
        //    MessageBox.Show("마우스 눌림", "짜잔~");
        //}

        protected override void OnClick(System.EventArgs e)
        {
            base.OnClick(e);

            MessageBox.Show("마우스 눌림");
        }
    }
}

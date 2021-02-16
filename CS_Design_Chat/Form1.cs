using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Design_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string oldTxt = txtView.Text;

            string newTxt = string.Format("You said : {0}{1}",
                txtChat.Text, Environment.NewLine);
            txtView.Text = oldTxt + newTxt;
            txtChat.Text = "";
        }
    }
}

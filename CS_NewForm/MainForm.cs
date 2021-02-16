using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_NewForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            SubForm subForm = new SubForm();
            if (subForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.lblName.Text = subForm.Result;
            }
        }
    }
}

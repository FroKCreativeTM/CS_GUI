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
    public partial class SubForm : Form
    {
        public string Result { get; private set; }

        public SubForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Result = this.txtName.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

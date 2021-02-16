using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_MyDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 이벤트 처리기를 추가한다.
            this.fileChooser1.FileSelected += fileChooser_FileSelected;
        }

        void fileChooser_FileSelected(object sender, EventArgs e)
        {
            // 파일이 선택되었음을 통지받아 처리한다.
            MessageBox.Show(this.fileChooser1.SelectedFilePath);
        }
    }
}

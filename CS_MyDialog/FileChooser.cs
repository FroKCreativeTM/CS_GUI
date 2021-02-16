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
    public partial class FileChooser : UserControl
    {
        public event EventHandler FileSelected;

        // 외부에서 선택된 파일 경로를 가져갈 수 있게 읽기 속성을 제공
        string _selectedFilePath;

        public string SelectedFilePath
        {
            get
            {
                return _selectedFilePath;
            }
        }

        public FileChooser()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtFileName.Text = ofd.FileName;
                    this._selectedFilePath = ofd.FileName;

                    if(FileSelected != null)
                    {
                        // 외부에서 이벤트를 걸어뒀다면 파일이 선택되었음을 통보한다.
                        FileSelected(this, EventArgs.Empty);
                    }
                }
            }
        }
    }
}

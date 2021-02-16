using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 기본적으로 제공되는 다이얼로그 공부입니다.

            // 파일 열기 다이얼로그
            //using (OpenFileDialog openDlg = new OpenFileDialog())
            //{
            //    if (openDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MessageBox.Show("선택한 파일 " + openDlg.FileName);
            //    }
            //}

            // 파일 저장 다이얼로그
            //using (SaveFileDialog openDlg = new SaveFileDialog())
            //{
            //    if (openDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MessageBox.Show("선택한 파일 " + openDlg.FileName);
            //    }
            //}

            // 파일 저장 다이얼로그
            //using (FolderBrowserDialog openDlg = new FolderBrowserDialog())
            //{
            //    if (openDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MessageBox.Show("선택한 파일 " + openDlg.SelectedPath);
            //    }
            //}

            // 폰트 지정 대화상자
            //using (FontDialog fontDlg = new FontDialog())
            //{
            //    if (fontDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        using (Graphics g = this.CreateGraphics())
            //        {
            //            g.DrawString("This is text", fontDlg.Font, Brushes.NavajoWhite, 0, 0);
            //        }
            //    }
            //}

            // 컬러 대화상자
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = this.BackColor;

                if (colorDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.BackColor = colorDlg.Color;
                }
            }
        }
    }
}

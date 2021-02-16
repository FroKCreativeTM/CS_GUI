using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_MenuBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            // 마우스 오른 버튼이 눌린 경우
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // 컨텍스트 메뉴 객체를 만들고
                ContextMenu ctxMenu = new ContextMenu();

                // 컨텍스트 메뉴에 들어갈 2개의 MenuItem을 생성하여 추가
                MenuItem menuItem = new MenuItem("새로 고침");
                menuItem.Click += menuRefresh_click;
                ctxMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("종료");
                menuItem.Click += menuExit_click;
                ctxMenu.MenuItems.Add(menuItem);

                ctxMenu.Show(this, e.Location);
            }
        }

        private void menuExit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRefresh_click(object sender, EventArgs e)
        {
            MessageBox.Show("새로고침 버튼 눌림");
        }
    }
}

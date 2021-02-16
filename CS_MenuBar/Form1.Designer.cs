
namespace CS_MenuBar
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolbarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolbarStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolbarStrip
            // 
            this.FileToolbarStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh_Click,
            this.menuExit_Click});
            this.FileToolbarStrip.Name = "FileToolbarStrip";
            this.FileToolbarStrip.Size = new System.Drawing.Size(43, 20);
            this.FileToolbarStrip.Text = "파일";
            // 
            // menuRefresh_Click
            // 
            this.menuRefresh_Click.Name = "menuRefresh_Click";
            this.menuRefresh_Click.Size = new System.Drawing.Size(180, 22);
            this.menuRefresh_Click.Text = "새로 고침";
            this.menuRefresh_Click.Click += new System.EventHandler(this.menuRefresh_click);
            // 
            // menuExit_Click
            // 
            this.menuExit_Click.Name = "menuExit_Click";
            this.menuExit_Click.Size = new System.Drawing.Size(180, 22);
            this.menuExit_Click.Text = "종료";
            this.menuExit_Click.Click += new System.EventHandler(this.menuExit_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolbarStrip;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh_Click;
        private System.Windows.Forms.ToolStripMenuItem menuExit_Click;
    }
}


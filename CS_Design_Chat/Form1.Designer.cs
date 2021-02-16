
namespace CS_Design_Chat
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
            this.txtView = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(13, 13);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtView.Size = new System.Drawing.Size(775, 357);
            this.txtView.TabIndex = 0;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(13, 377);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(652, 21);
            this.txtChat.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(671, 376);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(117, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtView);
            this.Name = "Form1";
            this.Text = "채팅 클라이언트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnInput;
    }
}


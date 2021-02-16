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
    public partial class DottedBoxLabel : Control
    {
        public DottedBoxLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // System.Windows.Forms 어셈블리에는 기본 동작에 필요한 기능들을 제공한다.

            // 컨트롤 크기를 ClientRectangle 속성으로 구한다.
            Rectangle rectArea = this.ClientRectangle;

            // Inflate 메서드를 이용해서 Rectangle의 크기를 조정한다.
            // width나 height는 -1로 지정되어있기 때문에, 사각형의 크기가 1씩 줄어든다.
            // 이렇게 하는 이유는 선을 그리기 위한 영역으로 1픽셀씩 차지하기 때문이다.
            rectArea.Inflate(-1, -1);

            using (Pen dottedPen  = new Pen(Brushes.Black, 1))
            {
                // Pen의 선 스타일을 Dot으로 바꾼다.
                dottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                pe.Graphics.DrawRectangle(dottedPen, rectArea);
            }

            // 문자열을 그린다.
            using (Font normalFont = new Font(FontFamily.GenericSansSerif, 10))
            {
                // 정교한 출력을 위한 과정
                // 지정된 폰트로 출력될 텍스트의 크기를 먼저 계산한다.
                SizeF outputSize = pe.Graphics.MeasureString(this.Text, normalFont);

                // 사각형 중간에 출력하자
                PointF pt = new PointF();
                pt.X = (rectArea.Width - outputSize.Width) / 2;
                pt.Y = (rectArea.Height - outputSize.Height) / 2;

                // 문자열을 점선으로 그려진 사각형 내부에 출력한다.
                pe.Graphics.DrawString(this.Text, normalFont, Brushes.Black, pt);
            }
        }
    }
}

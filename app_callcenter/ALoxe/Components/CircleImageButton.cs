using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Components
{
    public class CircleImageButton : Button
    {
        public CircleImageButton()
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Size = new System.Drawing.Size(50, 50);
            Margin = new System.Windows.Forms.Padding(0);
            Padding = new System.Windows.Forms.Padding(0);
            UseVisualStyleBackColor = false;
            //vô hiệu hóa sự kiện rê chuột vào button thì bị đổi màu
            MouseEnter += (s, e) => { };
            MouseLeave += (s, e) => { };



        }

        //thêm thuộc tính image cho button
        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.Description("Image")]
        public System.Drawing.Image Image
        {
            get { return BackgroundImage; }
            set { BackgroundImage = value; }
        }
        //vẽ lại button  hình tròn có thể thêm hình ảnh
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath grPath = new System.Drawing.Drawing2D.GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);

            //vẽ lại hình ảnh nếu có
            if (Image != null)
            {
                e.Graphics.DrawImage(Image, 0, 0, Width, Height);
            }
            //vẽ thêm viền cho button 

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
            e.Graphics.DrawEllipse(pen, 0, 0, ClientSize.Width, ClientSize.Height);

        }

    }
}

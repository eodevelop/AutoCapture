using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCapture
{
    public partial class AutoCapture : Form
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint L_DOWN = 0x0002;
        private const uint L_UP = 0x0004;

        public AutoCapture()
        {
            InitializeComponent();
        }
        
        public Bitmap ScreenCapture()
        {
            try
            {
                int startX = int.Parse(txtStartX.Text.ToString());
                int startY = int.Parse(txtStartY.Text.ToString());
                int endX = int.Parse(txtEndX.Text.ToString());
                int endY = int.Parse(txtEndY.Text.ToString());

                int width = endX - startX;
                int height = endY - startY;

                //size 객체 생성  
                Size s = new Size(width, height);

                //Bitmap 객체 생성   
                Bitmap b = new Bitmap(width, height);

                //Graphics 객체 생성   
                Graphics g = Graphics.FromImage(b);

                //Graphics 객체의 CopyFromScreen()메서드로 bitmap 객체에 Screen을 캡처하여 저장   
                g.CopyFromScreen(startX, startY, 0, 0, s);
                g.Dispose();
                return b;
                //pictureBox1.Image = b;  
            }
            catch(Exception e)
            {
                System.Threading.Thread.Sleep(2000);
                return ScreenCapture();
            }
        }

        public void WriteFile(int fileName)
        {
            Bitmap bmp = ScreenCapture();
            bmp.Save("C:\\workspace\\capture\\doit\\" + fileName + ".jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MouseAction();
            //WriteFile();
        }

        private void MouseAction()
        {
            int x = int.Parse(txtMouseX.Text.ToString());
            int y = int.Parse(txtMouseY.Text.ToString());

            Point point = new Point(x, y);
            
            for(int i = 0; i < 217; i++)
            {
                WriteFile(i+1);
                Cursor.Position = point;

                mouse_event(L_DOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(200);
                mouse_event(L_UP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(200);
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) timer.Stop();
            else timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtMouseX.Text = Cursor.Position.X.ToString();
            txtMouseY.Text = Cursor.Position.Y.ToString();

            int x = (int)(Cursor.Position.X * 1.5);
            int y = (int)(Cursor.Position.Y * 1.5);

            string str = "X : " + x + ", Y : " + y;

            lbPoint.Text = str;
        }
    }
    
}

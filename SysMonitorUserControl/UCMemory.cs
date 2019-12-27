using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SysMonitorUserControl
{
    public partial class UCMemory : UserControl
    {
        public UCMemory()
        {
            InitializeComponent();
            UsageColor = Color.DarkRed;
            CreateImage();
        }
        public Color UsageColor { get; set; }
        public float memValue = 0f; // 百分比中的分子
        public string memDescription = "";


        private void CreateImage()
        {
            Bitmap image = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(BackColor);
            SolidBrush usageBrush = new SolidBrush(UsageColor);
            g.FillRectangle(usageBrush, 0, 0, Width * memValue * 1.0f / 100, Height);
            SizeF _sz = new Size(0, 0);
            string _s = memDescription.ToString();
            _sz = g.MeasureString(_s, Font);
            g.DrawString(_s, Font, new SolidBrush(ForeColor), (Width - _sz.Width) / 2, (Height - _sz.Height) / 2);
            BackgroundImage = image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Microsoft.VisualBasic.Devices.Computer myInfo = new Microsoft.VisualBasic.Devices.Computer();
                //获取物理内存总量
                var totalPhysicalMemory = Convert.ToInt32(myInfo.Info.TotalPhysicalMemory / 1024 / 1024);
                // 获取进程占用内存
                var p = Process.GetCurrentProcess();
                var usedMemory = p.PrivateMemorySize64 / 1024 / 1024;

                memDescription = usedMemory.ToString("###,###") + " MiB";
                memValue = (1.0f * usedMemory / totalPhysicalMemory) * 100;

                Invoke(new Action(() => { CreateImage(); }));

            }
            catch(Exception ex) { }

        }


        public void Start() => timer1.Start();

        public void Stop() => timer1.Stop();
    }
}

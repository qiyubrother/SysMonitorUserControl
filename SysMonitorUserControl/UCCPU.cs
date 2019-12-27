using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SysMonitorUserControl
{
    public partial class UCCPU : UserControl
    {
        public UCCPU()
        {
            InitializeComponent();
            UsageColor = Color.DarkRed;
        }

        ManagementObjectSearcher searcher = null;
        int cpuValue = 0;
        private void CreateImage()
        {
            Bitmap image = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(BackColor);
            SolidBrush usageBrush = new SolidBrush(UsageColor);
            g.FillRectangle(usageBrush, 0, Height * (1 - cpuValue * 1.0f / 100), Width, Height * (cpuValue * 1.0f / 100));
            SizeF _sz = new Size(0, 0);
            string _s = cpuValue.ToString();
            _sz = g.MeasureString(_s, Font);
            g.DrawString(_s, Font, new SolidBrush(ForeColor), (Width - _sz.Width) / 2, (Height - _sz.Height) / 2);
            BackgroundImage = image;
        }

        public Color UsageColor { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var t = Task.Run(() =>
            {
                int iCPU = 0; // cpu数量
                int calcCPU = 0;
                float perCPU = 0.0f;
                try
                {
                    searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                    ManagementObjectCollection result = null;
                    result = searcher.Get();
                    foreach (ManagementObject myobject in result)
                    {
                        iCPU++;
                        calcCPU = Convert.ToInt32(myobject["LoadPercentage"]);
                        perCPU += calcCPU;
                    }
                    perCPU = perCPU / iCPU;

                    cpuValue = Convert.ToInt32(perCPU);

                    Invoke(new Action(() => { CreateImage(); }));

                }
                catch { }
            });
        }


        public void Start() => timer1.Start();

        public void Stop() => timer1.Stop();
    }
}

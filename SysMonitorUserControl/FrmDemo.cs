using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMonitorUserControl
{
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {
            uccpu1.Start();
            ucMemory1.Start();
            ucMicrophone1.Start();
            ucSpeaker1.Start();
            ucMicrophone2.Start();
        }
    }
}

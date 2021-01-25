using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class CPU : UserControl
    {
        public CPU()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            cpuUsagePb.Value = (int)fcpu;
            cpuUsageLabel.Text = string.Format("{0:0.00}%", fcpu);
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

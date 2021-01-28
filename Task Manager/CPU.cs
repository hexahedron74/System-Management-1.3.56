using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
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
            chartCPU.Series["CPU"].Points.AddY(fcpu);
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cpu_core_number();
            cpu_name();
            cpu_processor_number();
            logical_processor_number();
        }

        private void cpu_name()
        {
            ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in win32Proc.Get())
            {
                string procName = obj["name"].ToString();
                cpu_main_name.Text = procName;
            }
        }

        private void cpu_core_number()
        {
            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            core_number.Text = Convert.ToString(coreCount) + " Core";
        }

        private void cpu_processor_number()
        {
            Process[] allProc = Process.GetProcesses();
            processor_number.Text = Convert.ToString(allProc.Length);
        }

        private void logical_processor_number()
        {
            logic_pro_num.Text = Convert.ToString(Environment.ProcessorCount);
        }

    }
}

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
    public partial class GPU : UserControl
    {
        private Thread gpuThread;
        private double[] gpuArray = new double[30];
        public GPU()
        {
            InitializeComponent();
        }

        private void GPU_Load(object sender, EventArgs e)
        {
            GPUName();
            startGpuThread();
        }
        
        private void GPUName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        graphic_main_name.Text = graphicsCard;
                        Console.WriteLine("The graphic card model name has been imported successfully.\n");
                    }
                }
            }
        }

        //live update cpu usage chart not accumulate, floating chart
        private void getPerformanceCounters()
        {
            var GpuPerfCounter = new PerformanceCounter("NVIDIA GPU", "% GPU Usage", "#0 Quadro K1100M(id=1, NVAPI ID=256)");
            while (true)
            {
                gpuArray[gpuArray.Length - 1] = Math.Round(GpuPerfCounter.NextValue(), 0);
                Array.Copy(gpuArray, 1, gpuArray, 0, gpuArray.Length - 1);
                if (chartGPU.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateGpuChart(); });
                }
                else
                {

                }
                Thread.Sleep(1000);//thread 1 second
            }
        }

        private void UpdateGpuChart()
        {
            chartGPU.Series["GPU"].Points.Clear();
            for (int i = 0; i < gpuArray.Length - 1; ++i)
            {
                chartGPU.Series["GPU"].Points.AddY(gpuArray[i]);
            }
        }

        //start live chart thread
        private void startGpuThread()
        {
            gpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            gpuThread.IsBackground = true;
            gpuThread.Start();
        }

    }
}

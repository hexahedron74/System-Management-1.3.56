using Hardware.Info;
using System;
using System.Management;
using System.Windows.Forms;

namespace Task_Manager
{

    public partial class MainForm : Form
    {
        int mov;
        int movX;
        int movY;

        public MainForm()
        {
            InitializeComponent();
            dashboard db = new dashboard();
            dashboard1.BringToFront();
            cpu1.Hide();
            gpu1.Hide();
            //this.mainFormTimer.Tick += new EventHandler(mainFormTimer_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // mainFormTimer.Start();
            GetBatteryInfo();
            GetCpuTemperature();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        //Get Battery Information
        public void GetBatteryInfo()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            float batteryCharge = status.BatteryLifePercent;
            if (status.BatteryLifePercent < 100)
            {
                statitics_batterySize.Text = 0 + status.BatteryLifePercent.ToString("P0");
            }
            statistics_battery.Minimum = 0;
            statistics_battery.Maximum = 100;
            statistics_battery.Value = (int)(status.BatteryLifePercent != 255 ? status.BatteryLifePercent * 100 : 0);
            Console.WriteLine("The battery level has been loaded successfully.\n");
        }

        public void GetCpuTemperature()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject mo in mos.Get())
            {
                Double temp = Convert.ToDouble(mo["CurrentTemperature"].ToString());
                temp = (temp - 2732) / 10.0;
                cpuClockLabel.Text = 0 + Convert.ToString(temp);
                guna2CircleProgressBar1.Value = Convert.ToInt32(temp);
            }
            Console.WriteLine("CPU temperature has been loaded successfully.\n");
        }

        //Update Information every 1 second.
        private void mainFormTimer_Tick(object sender, EventArgs e)
        {
            GetBatteryInfo();
            GetCpuTemperature();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            cpu1.Hide();
            gpu1.Hide();
            dashboard1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cpu1.Show();
            cpu1.BringToFront();
            dashboard1.Hide();
            gpu1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gpu1.Show();
            gpu1.BringToFront();
            dashboard1.Hide();
            cpu1.Hide();

        }

    }
}

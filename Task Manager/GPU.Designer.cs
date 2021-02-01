
namespace Task_Manager
{
    partial class GPU
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chartGPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ClockSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logic_pro_num = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.processor_number = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.core_number = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cpuTempPb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.graphic_main_name = new System.Windows.Forms.Label();
            this.cpuSpeedPb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuUsagePb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGPU)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.cpuUsagePb.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.chartGPU);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(227, 68);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(540, 384);
            this.guna2CustomGradientPanel1.TabIndex = 28;
            // 
            // chartGPU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGPU.Legends.Add(legend1);
            this.chartGPU.Location = new System.Drawing.Point(3, 10);
            this.chartGPU.Name = "chartGPU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "GPU";
            this.chartGPU.Series.Add(series1);
            this.chartGPU.Size = new System.Drawing.Size(534, 362);
            this.chartGPU.TabIndex = 20;
            this.chartGPU.Text = "chart1";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.Controls.Add(this.label11);
            this.guna2CustomGradientPanel2.Controls.Add(this.label12);
            this.guna2CustomGradientPanel2.Controls.Add(this.label8);
            this.guna2CustomGradientPanel2.Controls.Add(this.label10);
            this.guna2CustomGradientPanel2.Controls.Add(this.ClockSpeed);
            this.guna2CustomGradientPanel2.Controls.Add(this.label5);
            this.guna2CustomGradientPanel2.Controls.Add(this.logic_pro_num);
            this.guna2CustomGradientPanel2.Controls.Add(this.label9);
            this.guna2CustomGradientPanel2.Controls.Add(this.processor_number);
            this.guna2CustomGradientPanel2.Controls.Add(this.label6);
            this.guna2CustomGradientPanel2.Controls.Add(this.core_number);
            this.guna2CustomGradientPanel2.Controls.Add(this.label7);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(17, 68);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(191, 384);
            this.guna2CustomGradientPanel2.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Logical Processor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Logical Processor";
            // 
            // ClockSpeed
            // 
            this.ClockSpeed.AutoSize = true;
            this.ClockSpeed.BackColor = System.Drawing.Color.Transparent;
            this.ClockSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockSpeed.Location = new System.Drawing.Point(11, 214);
            this.ClockSpeed.Name = "ClockSpeed";
            this.ClockSpeed.Size = new System.Drawing.Size(53, 23);
            this.ClockSpeed.TabIndex = 22;
            this.ClockSpeed.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Basic Speed";
            // 
            // logic_pro_num
            // 
            this.logic_pro_num.AutoSize = true;
            this.logic_pro_num.BackColor = System.Drawing.Color.Transparent;
            this.logic_pro_num.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logic_pro_num.Location = new System.Drawing.Point(11, 150);
            this.logic_pro_num.Name = "logic_pro_num";
            this.logic_pro_num.Size = new System.Drawing.Size(53, 23);
            this.logic_pro_num.TabIndex = 20;
            this.logic_pro_num.Text = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Logical Processor";
            // 
            // processor_number
            // 
            this.processor_number.AutoSize = true;
            this.processor_number.BackColor = System.Drawing.Color.Transparent;
            this.processor_number.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_number.Location = new System.Drawing.Point(11, 91);
            this.processor_number.Name = "processor_number";
            this.processor_number.Size = new System.Drawing.Size(53, 23);
            this.processor_number.TabIndex = 16;
            this.processor_number.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Process";
            // 
            // core_number
            // 
            this.core_number.AutoSize = true;
            this.core_number.BackColor = System.Drawing.Color.Transparent;
            this.core_number.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core_number.Location = new System.Drawing.Point(11, 33);
            this.core_number.Name = "core_number";
            this.core_number.Size = new System.Drawing.Size(53, 23);
            this.core_number.TabIndex = 14;
            this.core_number.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Core Number";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(17, 446);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(750, 26);
            this.guna2Separator1.TabIndex = 25;
            // 
            // cpuTempPb
            // 
            this.cpuTempPb.BackColor = System.Drawing.Color.White;
            this.cpuTempPb.FillThickness = 10;
            this.cpuTempPb.Location = new System.Drawing.Point(572, 17);
            this.cpuTempPb.Name = "cpuTempPb";
            this.cpuTempPb.ProgressThickness = 10;
            this.cpuTempPb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuTempPb.ShadowDecoration.Parent = this.cpuTempPb;
            this.cpuTempPb.Size = new System.Drawing.Size(129, 128);
            this.cpuTempPb.TabIndex = 23;
            // 
            // graphic_main_name
            // 
            this.graphic_main_name.AutoSize = true;
            this.graphic_main_name.BackColor = System.Drawing.Color.Transparent;
            this.graphic_main_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphic_main_name.Location = new System.Drawing.Point(243, 30);
            this.graphic_main_name.Name = "graphic_main_name";
            this.graphic_main_name.Size = new System.Drawing.Size(53, 23);
            this.graphic_main_name.TabIndex = 26;
            this.graphic_main_name.Text = "name";
            // 
            // cpuSpeedPb
            // 
            this.cpuSpeedPb.BackColor = System.Drawing.Color.White;
            this.cpuSpeedPb.FillThickness = 10;
            this.cpuSpeedPb.Location = new System.Drawing.Point(315, 17);
            this.cpuSpeedPb.Name = "cpuSpeedPb";
            this.cpuSpeedPb.ProgressThickness = 10;
            this.cpuSpeedPb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuSpeedPb.ShadowDecoration.Parent = this.cpuSpeedPb;
            this.cpuSpeedPb.Size = new System.Drawing.Size(129, 128);
            this.cpuSpeedPb.TabIndex = 24;
            // 
            // cpuUsagePb
            // 
            this.cpuUsagePb.BackColor = System.Drawing.Color.White;
            this.cpuUsagePb.Controls.Add(this.cpuUsageLabel);
            this.cpuUsagePb.FillThickness = 10;
            this.cpuUsagePb.Location = new System.Drawing.Point(58, 17);
            this.cpuUsagePb.Name = "cpuUsagePb";
            this.cpuUsagePb.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressThickness = 10;
            this.cpuUsagePb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuUsagePb.ShadowDecoration.Parent = this.cpuUsagePb;
            this.cpuUsagePb.Size = new System.Drawing.Size(129, 128);
            this.cpuUsagePb.TabIndex = 22;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageLabel.Location = new System.Drawing.Point(37, 57);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(57, 19);
            this.cpuUsageLabel.TabIndex = 10;
            this.cpuUsageLabel.Text = "00:00%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "GPU Information";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.cpuSpeedPb);
            this.guna2CustomGradientPanel3.Controls.Add(this.cpuUsagePb);
            this.guna2CustomGradientPanel3.Controls.Add(this.cpuTempPb);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(17, 470);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(750, 192);
            this.guna2CustomGradientPanel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Core Speed";
            // 
            // GPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.graphic_main_name);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Name = "GPU";
            this.Size = new System.Drawing.Size(789, 679);
            this.Load += new System.EventHandler(this.GPU_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGPU)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.cpuUsagePb.ResumeLayout(false);
            this.cpuUsagePb.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGPU;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ClockSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logic_pro_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label processor_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label core_number;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuTempPb;
        private System.Windows.Forms.Label graphic_main_name;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuSpeedPb;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuUsagePb;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label label2;
    }
}

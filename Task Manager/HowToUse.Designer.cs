
namespace Task_Manager
{
    partial class HowToUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToUse));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxStyle2 = new Task_Manager.listBoxStyle();
            this.listBoxStyle1 = new Task_Manager.listBoxStyle();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "How To Use";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.listBoxStyle2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.listBoxStyle1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(32, 56);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(738, 597);
            this.guna2CustomGradientPanel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(143, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 42);
            this.label3.TabIndex = 32;
            this.label3.Text = "V1.3.56";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 59);
            this.label2.TabIndex = 31;
            this.label2.Text = "Task Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(560, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Release Date: 2021-05-01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(286, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 42);
            this.label5.TabIndex = 35;
            this.label5.Text = "Notice";
            // 
            // listBoxStyle2
            // 
            this.listBoxStyle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStyle2.FormattingEnabled = true;
            this.listBoxStyle2.ItemHeight = 23;
            this.listBoxStyle2.Items.AddRange(new object[] {
            "1. Depending on your computer\'s specifications, the program loading speed may var" +
                "y.",
            "2.We will be constantly updating, so if there are any features you want to add, ",
            "please leave them in the GitHub issue.",
            "3.This program is open source, but please follow the license carefully ",
            "and if you would like to make another program using this program, please contact " +
                "us.",
            "4. Since this is still a test version, some items may not display information on " +
                "some ",
            "computers. ",
            "If there are any items that are not shown, please leave them in the GitHub issue." +
                ""});
            this.listBoxStyle2.Location = new System.Drawing.Point(19, 349);
            this.listBoxStyle2.Name = "listBoxStyle2";
            this.listBoxStyle2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxStyle2.ShowScrollbar = false;
            this.listBoxStyle2.Size = new System.Drawing.Size(703, 230);
            this.listBoxStyle2.TabIndex = 36;
            // 
            // listBoxStyle1
            // 
            this.listBoxStyle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStyle1.FormattingEnabled = true;
            this.listBoxStyle1.ItemHeight = 23;
            this.listBoxStyle1.Items.AddRange(new object[] {
            "1. Dashboard shows all of the informations of your computer.",
            "2. CPU Tab shows informations of your computer.",
            "3. GPU Tab shows informations of your computer.",
            "4. Memory Tab shows informations of your computer.",
            "5. All Programs Tab shows informations of your all the programs in your computer." +
                "",
            "6. License Tab shows the license and copyright of this programs."});
            this.listBoxStyle1.Location = new System.Drawing.Point(19, 145);
            this.listBoxStyle1.Name = "listBoxStyle1";
            this.listBoxStyle1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxStyle1.ShowScrollbar = false;
            this.listBoxStyle1.Size = new System.Drawing.Size(703, 138);
            this.listBoxStyle1.TabIndex = 33;
            // 
            // HowToUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label1);
            this.Name = "HowToUse";
            this.Size = new System.Drawing.Size(789, 679);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private listBoxStyle listBoxStyle1;
        private listBoxStyle listBoxStyle2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

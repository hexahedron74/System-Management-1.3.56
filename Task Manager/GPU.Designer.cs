
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
            this.storage_main_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storage_main_title
            // 
            this.storage_main_title.AutoSize = true;
            this.storage_main_title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_main_title.Location = new System.Drawing.Point(34, 27);
            this.storage_main_title.Name = "storage_main_title";
            this.storage_main_title.Size = new System.Drawing.Size(158, 26);
            this.storage_main_title.TabIndex = 3;
            this.storage_main_title.Text = "GPU Information";
            this.storage_main_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.storage_main_title);
            this.Name = "GPU";
            this.Size = new System.Drawing.Size(789, 679);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storage_main_title;
    }
}

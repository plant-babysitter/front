namespace plant_sitter
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxQ = new System.Windows.Forms.PictureBox();
            this.Button_set_image = new System.Windows.Forms.PictureBox();
            this.Button_set_info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "식물 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "식물의 종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "목표 습도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "목표 온도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "펌프 주기";
            // 
            // pictureBoxQ
            // 
            this.pictureBoxQ.Image = global::plant_sitter.Properties.Resources.basic;
            this.pictureBoxQ.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxQ.Name = "pictureBoxQ";
            this.pictureBoxQ.Size = new System.Drawing.Size(107, 165);
            this.pictureBoxQ.TabIndex = 1;
            this.pictureBoxQ.TabStop = false;
            // 
            // Button_set_image
            // 
            this.Button_set_image.Image = global::plant_sitter.Properties.Resources.reset;
            this.Button_set_image.Location = new System.Drawing.Point(125, 42);
            this.Button_set_image.Name = "Button_set_image";
            this.Button_set_image.Size = new System.Drawing.Size(17, 23);
            this.Button_set_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_set_image.TabIndex = 12;
            this.Button_set_image.TabStop = false;
            this.Button_set_image.Click += new System.EventHandler(this.Button_set_image1);
            // 
            // Button_set_info
            // 
            this.Button_set_info.Image = global::plant_sitter.Properties.Resources.reset;
            this.Button_set_info.Location = new System.Drawing.Point(102, 229);
            this.Button_set_info.Name = "Button_set_info";
            this.Button_set_info.Size = new System.Drawing.Size(17, 15);
            this.Button_set_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_set_info.TabIndex = 11;
            this.Button_set_info.TabStop = false;
            this.Button_set_info.Click += new System.EventHandler(this.Button_set_info_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQ);
            this.Controls.Add(this.Button_set_image);
            this.Controls.Add(this.Button_set_info);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Button_set_image;
        private System.Windows.Forms.PictureBox Button_set_info;
    }
}


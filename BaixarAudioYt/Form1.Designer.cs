namespace YoutubeAudioDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVideoUrl
            // 
            this.txtVideoUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoUrl.Location = new System.Drawing.Point(97, 120);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(851, 34);
            this.txtVideoUrl.TabIndex = 0;
            this.txtVideoUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(243, 204);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(272, 38);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download do Áudio!";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cole o link do vídeo do Youtube abaixo e clique em download!";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(91, 266);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(857, 32);
            this.status.TabIndex = 3;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVideo
            // 
            this.buttonVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideo.Location = new System.Drawing.Point(538, 204);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(272, 38);
            this.buttonVideo.TabIndex = 4;
            this.buttonVideo.Text = "Download do Vídeo!";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 334);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtVideoUrl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVideoUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button buttonVideo;
    }
}


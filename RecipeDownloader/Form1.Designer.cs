namespace RecipeDownloader
{
    partial class Form1
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
            this.wbBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser1
            // 
            this.wbBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbBrowser1.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser1.Name = "wbBrowser1";
            this.wbBrowser1.Size = new System.Drawing.Size(1192, 727);
            this.wbBrowser1.TabIndex = 0;
            this.wbBrowser1.Url = new System.Uri("https://www.homechef.com/users/sign_in", System.UriKind.Absolute);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(1198, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 727);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.wbBrowser1);
            this.Name = "Form1";
            this.Text = "          ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBrowser1;
        private System.Windows.Forms.Button btnDownload;
    }
}


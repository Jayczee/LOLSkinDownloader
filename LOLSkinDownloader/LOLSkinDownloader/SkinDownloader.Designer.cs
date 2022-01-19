namespace LOLSkinDownloader
{
    partial class SkinDownloader
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
            this.picBoxbg = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.btnDldBrwoser = new System.Windows.Forms.Button();
            this.btnDldDir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelVer = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxbg)).BeginInit();
            this.groupBoxPath.SuspendLayout();
            this.groupBoxDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxbg
            // 
            this.picBoxbg.Image = global::LOLSkinDownloader.Properties.Resources.bg;
            this.picBoxbg.Location = new System.Drawing.Point(0, 0);
            this.picBoxbg.Name = "picBoxbg";
            this.picBoxbg.Size = new System.Drawing.Size(536, 314);
            this.picBoxbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxbg.TabIndex = 0;
            this.picBoxbg.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(487, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(445, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(317, 38);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "LOL Skin Downloader";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPath.Controls.Add(this.btnPath);
            this.groupBoxPath.Controls.Add(this.txtPath);
            this.groupBoxPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPath.Location = new System.Drawing.Point(12, 73);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(511, 75);
            this.groupBoxPath.TabIndex = 4;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Select your download directory:";
            // 
            // btnPath
            // 
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Location = new System.Drawing.Point(413, 27);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(87, 28);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Choose";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(401, 28);
            this.txtPath.TabIndex = 0;
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDownload.Controls.Add(this.btnDldBrwoser);
            this.groupBoxDownload.Controls.Add(this.btnDldDir);
            this.groupBoxDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDownload.Location = new System.Drawing.Point(12, 169);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(511, 88);
            this.groupBoxDownload.TabIndex = 5;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Select a type of downloading:";
            // 
            // btnDldBrwoser
            // 
            this.btnDldBrwoser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDldBrwoser.Location = new System.Drawing.Point(339, 29);
            this.btnDldBrwoser.Name = "btnDldBrwoser";
            this.btnDldBrwoser.Size = new System.Drawing.Size(101, 53);
            this.btnDldBrwoser.TabIndex = 3;
            this.btnDldBrwoser.Text = "Browser\r\nDownload";
            this.btnDldBrwoser.UseVisualStyleBackColor = true;
            this.btnDldBrwoser.Click += new System.EventHandler(this.btnDldBrwoser_Click);
            // 
            // btnDldDir
            // 
            this.btnDldDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDldDir.Location = new System.Drawing.Point(85, 29);
            this.btnDldDir.Name = "btnDldDir";
            this.btnDldDir.Size = new System.Drawing.Size(101, 53);
            this.btnDldDir.TabIndex = 2;
            this.btnDldDir.Text = "Directly\r\nDownload";
            this.btnDldDir.UseVisualStyleBackColor = true;
            this.btnDldDir.Click += new System.EventHandler(this.btnDldDir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 275);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 27);
            this.progressBar1.TabIndex = 6;
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.BackColor = System.Drawing.Color.Transparent;
            this.labelVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVer.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVer.Location = new System.Drawing.Point(18, 45);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(122, 25);
            this.labelVer.TabIndex = 7;
            this.labelVer.Text = "Newest Ver:";
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.SystemColors.Control;
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgress.Location = new System.Drawing.Point(115, 281);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(304, 16);
            this.txtProgress.TabIndex = 4;
            this.txtProgress.Text = "0%";
            this.txtProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SkinDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 314);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxDownload);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picBoxbg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SkinDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkinDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxbg)).EndInit();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBoxDownload.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxbg;
        private Button btnClose;
        private Button btnMin;
        private Label labelTitle;
        private GroupBox groupBoxPath;
        private Button btnPath;
        private TextBox txtPath;
        private GroupBox groupBoxDownload;
        private Button btnDldBrwoser;
        private Button btnDldDir;
        private ProgressBar progressBar1;
        private Label labelVer;
        private TextBox txtProgress;
    }
}
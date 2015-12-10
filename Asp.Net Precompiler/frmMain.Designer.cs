namespace Asp.Net_Precompiler
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tSourcePath = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.tDestinationPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpenDestinationAfterCompile = new System.Windows.Forms.CheckBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.pbInnovacube = new System.Windows.Forms.PictureBox();
            this.btnCompile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInnovacube)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source :";
            // 
            // tSourcePath
            // 
            this.tSourcePath.Location = new System.Drawing.Point(108, 48);
            this.tSourcePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tSourcePath.Name = "tSourcePath";
            this.tSourcePath.Size = new System.Drawing.Size(328, 22);
            this.tSourcePath.TabIndex = 1;
            this.tSourcePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnSelectSource_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(445, 46);
            this.btnSelectSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(97, 28);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "Browse";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(445, 78);
            this.btnSelectDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(97, 28);
            this.btnSelectDestination.TabIndex = 5;
            this.btnSelectDestination.Text = "Browse";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // tDestinationPath
            // 
            this.tDestinationPath.Location = new System.Drawing.Point(108, 81);
            this.tDestinationPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDestinationPath.Name = "tDestinationPath";
            this.tDestinationPath.Size = new System.Drawing.Size(328, 22);
            this.tDestinationPath.TabIndex = 4;
            this.tDestinationPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnSelectDestination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination :";
            // 
            // cbOpenDestinationAfterCompile
            // 
            this.cbOpenDestinationAfterCompile.AutoSize = true;
            this.cbOpenDestinationAfterCompile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOpenDestinationAfterCompile.Location = new System.Drawing.Point(279, 188);
            this.cbOpenDestinationAfterCompile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOpenDestinationAfterCompile.Name = "cbOpenDestinationAfterCompile";
            this.cbOpenDestinationAfterCompile.Size = new System.Drawing.Size(245, 20);
            this.cbOpenDestinationAfterCompile.TabIndex = 7;
            this.cbOpenDestinationAfterCompile.Text = "Open destination folder after compile";
            this.cbOpenDestinationAfterCompile.UseVisualStyleBackColor = true;
            // 
            // cbVersion
            // 
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Items.AddRange(new object[] {
            "v2.0.50727",
            "v4.0.30319"});
            this.cbVersion.Location = new System.Drawing.Point(108, 15);
            this.cbVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(328, 24);
            this.cbVersion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Version :";
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(16, 188);
            this.pbMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMain.MarqueeAnimationSpeed = 30;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(255, 21);
            this.pbMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbMain.TabIndex = 9;
            this.pbMain.Visible = false;
            // 
            // bw
            // 
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // pbInnovacube
            // 
            this.pbInnovacube.BackColor = System.Drawing.Color.Transparent;
            this.pbInnovacube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInnovacube.Image = global::AspNetPrecompiler.Properties.Resources.www_innovacube_com;
            this.pbInnovacube.Location = new System.Drawing.Point(391, 217);
            this.pbInnovacube.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbInnovacube.Name = "pbInnovacube";
            this.pbInnovacube.Size = new System.Drawing.Size(114, 29);
            this.pbInnovacube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInnovacube.TabIndex = 10;
            this.pbInnovacube.TabStop = false;
            this.pbInnovacube.Click += new System.EventHandler(this.pbInnovacube_Click);
            // 
            // btnCompile
            // 
            this.btnCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompile.Image = ((System.Drawing.Image)(resources.GetObject("btnCompile.Image")));
            this.btnCompile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompile.Location = new System.Drawing.Point(16, 112);
            this.btnCompile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Padding = new System.Windows.Forms.Padding(207, 0, 0, 0);
            this.btnCompile.Size = new System.Drawing.Size(527, 69);
            this.btnCompile.TabIndex = 6;
            this.btnCompile.Text = "     Compile";
            this.btnCompile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 267);
            this.Controls.Add(this.pbInnovacube);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbOpenDestinationAfterCompile);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.tDestinationPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.tSourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asp.Net Pre-compiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInnovacube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSourcePath;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.TextBox tDestinationPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.CheckBox cbOpenDestinationAfterCompile;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.PictureBox pbInnovacube;
    }
}


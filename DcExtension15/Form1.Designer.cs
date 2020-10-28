namespace DcExtension15
{
    partial class frmDcExtension
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDcExtension));
            this.gbSwitch = new System.Windows.Forms.GroupBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.wbDCNews = new System.Windows.Forms.WebBrowser();
            this.gbNews = new System.Windows.Forms.GroupBox();
            this.niIcono = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYourVersion = new System.Windows.Forms.Label();
            this.lbDevelopedBy = new System.Windows.Forms.Label();
            this.lblNumberOfVersion = new System.Windows.Forms.Label();
            this.gbSwitch.SuspendLayout();
            this.gbNews.SuspendLayout();
            this.mnuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSwitch
            // 
            this.gbSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSwitch.AutoSize = true;
            this.gbSwitch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSwitch.Controls.Add(this.btnSwitch);
            this.gbSwitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSwitch.Location = new System.Drawing.Point(9, 6);
            this.gbSwitch.Name = "gbSwitch";
            this.gbSwitch.Size = new System.Drawing.Size(950, 219);
            this.gbSwitch.TabIndex = 2;
            this.gbSwitch.TabStop = false;
            this.gbSwitch.Text = "DC EXTENSION SWITCH";
            // 
            // btnSwitch
            // 
            this.btnSwitch.AutoSize = true;
            this.btnSwitch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSwitch.BackColor = System.Drawing.Color.Black;
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.Location = new System.Drawing.Point(3, 16);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(944, 200);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            this.btnSwitch.MouseLeave += new System.EventHandler(this.btnSwitch_MouseLeave);
            this.btnSwitch.MouseHover += new System.EventHandler(this.btnSwitch_MouseHover);
            // 
            // wbDCNews
            // 
            this.wbDCNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDCNews.Location = new System.Drawing.Point(3, 16);
            this.wbDCNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDCNews.Name = "wbDCNews";
            this.wbDCNews.Size = new System.Drawing.Size(944, 247);
            this.wbDCNews.TabIndex = 0;
            this.wbDCNews.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // gbNews
            // 
            this.gbNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNews.AutoSize = true;
            this.gbNews.Controls.Add(this.wbDCNews);
            this.gbNews.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbNews.Location = new System.Drawing.Point(9, 274);
            this.gbNews.Name = "gbNews";
            this.gbNews.Size = new System.Drawing.Size(950, 266);
            this.gbNews.TabIndex = 3;
            this.gbNews.TabStop = false;
            this.gbNews.Text = "NEWS";
            // 
            // niIcono
            // 
            this.niIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcono.Icon")));
            this.niIcono.Text = "DeathCommandExtension";
            this.niIcono.Visible = true;
            this.niIcono.Click += new System.EventHandler(this.niIcono_Click);
            this.niIcono.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niIcono_MouseDoubleClick);
            // 
            // mnuContextual
            // 
            this.mnuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarToolStripMenuItem,
            this.desactivarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnuContextual.Name = "mnuContextual";
            this.mnuContextual.Size = new System.Drawing.Size(102, 70);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.activarToolStripMenuItem.Text = "ON";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.desactivarToolStripMenuItem.Text = "OFF";
            this.desactivarToolStripMenuItem.Click += new System.EventHandler(this.desactivarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.salirToolStripMenuItem.Text = "QUIT";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblYourVersion
            // 
            this.lblYourVersion.AutoSize = true;
            this.lblYourVersion.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourVersion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblYourVersion.Location = new System.Drawing.Point(30, 237);
            this.lblYourVersion.Name = "lblYourVersion";
            this.lblYourVersion.Size = new System.Drawing.Size(208, 30);
            this.lblYourVersion.TabIndex = 4;
            this.lblYourVersion.Text = "YOUR VERSION: ";
            // 
            // lbDevelopedBy
            // 
            this.lbDevelopedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDevelopedBy.AutoSize = true;
            this.lbDevelopedBy.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevelopedBy.ForeColor = System.Drawing.Color.Lime;
            this.lbDevelopedBy.Location = new System.Drawing.Point(738, 246);
            this.lbDevelopedBy.Name = "lbDevelopedBy";
            this.lbDevelopedBy.Size = new System.Drawing.Size(221, 18);
            this.lbDevelopedBy.TabIndex = 5;
            this.lbDevelopedBy.Text = "Developed by: JD - Developer";
            // 
            // lblNumberOfVersion
            // 
            this.lblNumberOfVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfVersion.AutoSize = true;
            this.lblNumberOfVersion.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfVersion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfVersion.Location = new System.Drawing.Point(298, 237);
            this.lblNumberOfVersion.Name = "lblNumberOfVersion";
            this.lblNumberOfVersion.Size = new System.Drawing.Size(0, 30);
            this.lblNumberOfVersion.TabIndex = 6;
            // 
            // frmDcExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(971, 552);
            this.Controls.Add(this.lblNumberOfVersion);
            this.Controls.Add(this.lbDevelopedBy);
            this.Controls.Add(this.lblYourVersion);
            this.Controls.Add(this.gbNews);
            this.Controls.Add(this.gbSwitch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(987, 550);
            this.Name = "frmDcExtension";
            this.Text = "DC Extension 2015";
            this.Load += new System.EventHandler(this.frmDcExtension_Load);
            this.gbSwitch.ResumeLayout(false);
            this.gbSwitch.PerformLayout();
            this.gbNews.ResumeLayout(false);
            this.mnuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSwitch;
        private System.Windows.Forms.WebBrowser wbDCNews;
        private System.Windows.Forms.GroupBox gbNews;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.NotifyIcon niIcono;
        private System.Windows.Forms.ContextMenuStrip mnuContextual;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblYourVersion;
        private System.Windows.Forms.Label lbDevelopedBy;
        private System.Windows.Forms.Label lblNumberOfVersion;
    }
}


namespace colordetector
{
    partial class HiddenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiddenForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photographicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textOnWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshEvery1sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshEvery10sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshEvery1mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Hall Color Detector";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.setModeToolStripMenuItem,
            this.setFrequencyToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(199, 100);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // setModeToolStripMenuItem
            // 
            this.setModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photographicToolStripMenuItem,
            this.textOnWhiteToolStripMenuItem});
            this.setModeToolStripMenuItem.Name = "setModeToolStripMenuItem";
            this.setModeToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.setModeToolStripMenuItem.Text = "Set Mode";
            // 
            // photographicToolStripMenuItem
            // 
            this.photographicToolStripMenuItem.Name = "photographicToolStripMenuItem";
            this.photographicToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.photographicToolStripMenuItem.Text = "Photographic";
            this.photographicToolStripMenuItem.Click += new System.EventHandler(this.photographicToolStripMenuItem_Click);
            // 
            // textOnWhiteToolStripMenuItem
            // 
            this.textOnWhiteToolStripMenuItem.Name = "textOnWhiteToolStripMenuItem";
            this.textOnWhiteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.textOnWhiteToolStripMenuItem.Text = "Text on White";
            this.textOnWhiteToolStripMenuItem.Click += new System.EventHandler(this.textOnWhiteToolStripMenuItem_Click);
            // 
            // setFrequencyToolStripMenuItem
            // 
            this.setFrequencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshEvery1sToolStripMenuItem,
            this.refreshEvery10sToolStripMenuItem,
            this.refreshEvery1mToolStripMenuItem,
            this.useConfigFileToolStripMenuItem});
            this.setFrequencyToolStripMenuItem.Name = "setFrequencyToolStripMenuItem";
            this.setFrequencyToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.setFrequencyToolStripMenuItem.Text = "Set Frequency (1s)";
            // 
            // refreshEvery1sToolStripMenuItem
            // 
            this.refreshEvery1sToolStripMenuItem.Name = "refreshEvery1sToolStripMenuItem";
            this.refreshEvery1sToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.refreshEvery1sToolStripMenuItem.Text = "refresh every 1s";
            this.refreshEvery1sToolStripMenuItem.Click += new System.EventHandler(this.SetFrequency_Click);
            // 
            // refreshEvery10sToolStripMenuItem
            // 
            this.refreshEvery10sToolStripMenuItem.Name = "refreshEvery10sToolStripMenuItem";
            this.refreshEvery10sToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.refreshEvery10sToolStripMenuItem.Text = "refresh every 10s";
            this.refreshEvery10sToolStripMenuItem.Click += new System.EventHandler(this.SetFrequency_Click);
            // 
            // refreshEvery1mToolStripMenuItem
            // 
            this.refreshEvery1mToolStripMenuItem.Name = "refreshEvery1mToolStripMenuItem";
            this.refreshEvery1mToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.refreshEvery1mToolStripMenuItem.Text = "refresh every 1m";
            this.refreshEvery1mToolStripMenuItem.Click += new System.EventHandler(this.SetFrequency_Click);
            // 
            // useConfigFileToolStripMenuItem
            // 
            this.useConfigFileToolStripMenuItem.Name = "useConfigFileToolStripMenuItem";
            this.useConfigFileToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.useConfigFileToolStripMenuItem.Text = "use config file";
            this.useConfigFileToolStripMenuItem.Click += new System.EventHandler(this.useConfigFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Interval = 1000;
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // HiddenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "HiddenForm";
            this.Text = "HiddenForm";
            this.Load += new System.EventHandler(this.HiddenForm_Load);
            this.Shown += new System.EventHandler(this.HiddenForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photographicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textOnWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshEvery1sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshEvery10sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshEvery1mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer CaptureTimer;
    }
}


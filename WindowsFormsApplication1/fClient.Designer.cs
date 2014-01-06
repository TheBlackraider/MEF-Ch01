namespace MEFClient
{
    partial class fClient
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarExtensionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtensiones = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusBar.Location = new System.Drawing.Point(0, 321);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(772, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 17);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.mnuExtensiones});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(772, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarExtensionesToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "&Programa";
            // 
            // cargarExtensionesToolStripMenuItem
            // 
            this.cargarExtensionesToolStripMenuItem.Name = "cargarExtensionesToolStripMenuItem";
            this.cargarExtensionesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cargarExtensionesToolStripMenuItem.Text = "Cargar Extensiones";
            this.cargarExtensionesToolStripMenuItem.Click += new System.EventHandler(this.cargarExtensionesToolStripMenuItem_Click);
            // 
            // mnuExtensiones
            // 
            this.mnuExtensiones.Name = "mnuExtensiones";
            this.mnuExtensiones.Size = new System.Drawing.Size(80, 20);
            this.mnuExtensiones.Text = "&Extensiones";
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 343);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "fClient";
            this.Text = "MEF Client";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarExtensionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExtensiones;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}


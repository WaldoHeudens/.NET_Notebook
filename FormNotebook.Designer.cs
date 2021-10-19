namespace Notebook
{
    partial class FormNotebook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Be = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBewaar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBewaarAls = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAfsluiten = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNotitie = new System.Windows.Forms.TextBox();
            this.Be.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Be
            // 
            this.Be.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Be.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.Be.Location = new System.Drawing.Point(0, 0);
            this.Be.Name = "Be";
            this.Be.Size = new System.Drawing.Size(800, 33);
            this.Be.TabIndex = 1;
            this.Be.Text = "menuStrip2";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpen,
            this.mnBewaar,
            this.mnBewaarAls,
            this.mnAfsluiten});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(270, 34);
            this.mnOpen.Text = "Open";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnBewaar
            // 
            this.mnBewaar.Name = "mnBewaar";
            this.mnBewaar.Size = new System.Drawing.Size(270, 34);
            this.mnBewaar.Text = "Bewaar";
            this.mnBewaar.Click += new System.EventHandler(this.mnBewaar_Click);
            // 
            // mnBewaarAls
            // 
            this.mnBewaarAls.Name = "mnBewaarAls";
            this.mnBewaarAls.Size = new System.Drawing.Size(270, 34);
            this.mnBewaarAls.Text = "Bewaar Als";
            this.mnBewaarAls.Click += new System.EventHandler(this.mnBewaarAls_Click);
            // 
            // mnAfsluiten
            // 
            this.mnAfsluiten.Name = "mnAfsluiten";
            this.mnAfsluiten.Size = new System.Drawing.Size(270, 34);
            this.mnAfsluiten.Text = "Afsluiten";
            this.mnAfsluiten.Click += new System.EventHandler(this.mnAfsluiten_Click);
            // 
            // tbNotitie
            // 
            this.tbNotitie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotitie.Location = new System.Drawing.Point(0, 57);
            this.tbNotitie.Multiline = true;
            this.tbNotitie.Name = "tbNotitie";
            this.tbNotitie.Size = new System.Drawing.Size(800, 393);
            this.tbNotitie.TabIndex = 2;
            this.tbNotitie.TextChanged += new System.EventHandler(this.tbNotitie_TextChanged);
            // 
            // FormNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNotitie);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Be);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNotebook";
            this.Text = "Notebook";
            this.Be.ResumeLayout(false);
            this.Be.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip Be;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem mnOpen;
        private ToolStripMenuItem mnBewaar;
        private ToolStripMenuItem mnBewaarAls;
        private ToolStripMenuItem mnAfsluiten;
        private TextBox tbNotitie;
    }
}
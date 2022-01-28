namespace B5_6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakIgracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapacitetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradoviToolStripMenuItem,
            this.stadioniToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spisakIgracaToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.UnosToolStripMenuItem_Click);
            // 
            // spisakIgracaToolStripMenuItem
            // 
            this.spisakIgracaToolStripMenuItem.Name = "spisakIgracaToolStripMenuItem";
            this.spisakIgracaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.spisakIgracaToolStripMenuItem.Text = "Spisak igraca";
            this.spisakIgracaToolStripMenuItem.Click += new System.EventHandler(this.SpisakIgracaToolStripMenuItem_Click);
            // 
            // stadioniToolStripMenuItem
            // 
            this.stadioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1,
            this.kapacitetToolStripMenuItem});
            this.stadioniToolStripMenuItem.Name = "stadioniToolStripMenuItem";
            this.stadioniToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.stadioniToolStripMenuItem.Text = "Stadioni";
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.unosToolStripMenuItem1.Text = "Unos";
            this.unosToolStripMenuItem1.Click += new System.EventHandler(this.UnosToolStripMenuItem1_Click);
            // 
            // kapacitetToolStripMenuItem
            // 
            this.kapacitetToolStripMenuItem.Name = "kapacitetToolStripMenuItem";
            this.kapacitetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapacitetToolStripMenuItem.Text = "Kapacitet";
            this.kapacitetToolStripMenuItem.Click += new System.EventHandler(this.KapacitetToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krajToolStripMenuItem});
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.krajToolStripMenuItem.Text = "Kraj";
            this.krajToolStripMenuItem.Click += new System.EventHandler(this.KrajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakIgracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kapacitetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}


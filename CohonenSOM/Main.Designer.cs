namespace CohonenSOM
{
    partial class Main
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
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohonenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_NetworkGridView = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_IterationsDone = new MetroFramework.Controls.MetroLabel();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NetworkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cohonenToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(20, 30);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(398, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // cohonenToolStripMenuItem
            // 
            this.cohonenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachNetworkToolStripMenuItem});
            this.cohonenToolStripMenuItem.Name = "cohonenToolStripMenuItem";
            this.cohonenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cohonenToolStripMenuItem.Text = "Cohonen";
            // 
            // teachNetworkToolStripMenuItem
            // 
            this.teachNetworkToolStripMenuItem.Name = "teachNetworkToolStripMenuItem";
            this.teachNetworkToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.teachNetworkToolStripMenuItem.Text = "Teach network";
            this.teachNetworkToolStripMenuItem.Click += new System.EventHandler(this.teachNetworkToolStripMenuItem_Click);
            // 
            // pictureBox_NetworkGridView
            // 
            this.pictureBox_NetworkGridView.BackColor = System.Drawing.Color.Gold;
            this.pictureBox_NetworkGridView.Location = new System.Drawing.Point(20, 66);
            this.pictureBox_NetworkGridView.Name = "pictureBox_NetworkGridView";
            this.pictureBox_NetworkGridView.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_NetworkGridView.TabIndex = 1;
            this.pictureBox_NetworkGridView.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 469);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Iterations done:";
            // 
            // metroLabel_IterationsDone
            // 
            this.metroLabel_IterationsDone.AutoSize = true;
            this.metroLabel_IterationsDone.Location = new System.Drawing.Point(128, 469);
            this.metroLabel_IterationsDone.Name = "metroLabel_IterationsDone";
            this.metroLabel_IterationsDone.Size = new System.Drawing.Size(16, 19);
            this.metroLabel_IterationsDone.TabIndex = 3;
            this.metroLabel_IterationsDone.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 492);
            this.Controls.Add(this.metroLabel_IterationsDone);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox_NetworkGridView);
            this.Controls.Add(this.menuStrip_Main);
            this.DisplayHeader = false;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Cohonen SOM";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NetworkGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohonenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachNetworkToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_NetworkGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel_IterationsDone;
    }
}
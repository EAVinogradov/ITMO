namespace DBConnection
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectionDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfConnectionToolStripMenuItem,
            this.connectionToDataBaseToolStripMenuItem,
            this.disconnectionDataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToDataBaseToolStripMenuItem
            // 
            this.connectionToDataBaseToolStripMenuItem.Name = "connectionToDataBaseToolStripMenuItem";
            this.connectionToDataBaseToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.connectionToDataBaseToolStripMenuItem.Text = "Connection to data base";
            this.connectionToDataBaseToolStripMenuItem.Click += new System.EventHandler(this.connectionToDataBaseToolStripMenuItem_Click);
            // 
            // disconnectionDataBaseToolStripMenuItem
            // 
            this.disconnectionDataBaseToolStripMenuItem.Name = "disconnectionDataBaseToolStripMenuItem";
            this.disconnectionDataBaseToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.disconnectionDataBaseToolStripMenuItem.Text = "Disconnection data base";
            this.disconnectionDataBaseToolStripMenuItem.Click += new System.EventHandler(this.disconnectionDataBaseToolStripMenuItem_Click);
            // 
            // listOfConnectionToolStripMenuItem
            // 
            this.listOfConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionListToolStripMenuItem});
            this.listOfConnectionToolStripMenuItem.Name = "listOfConnectionToolStripMenuItem";
            this.listOfConnectionToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.listOfConnectionToolStripMenuItem.Text = "File";
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectionListToolStripMenuItem.Text = "Connection list";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Connection to data base";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectionDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
    }
}


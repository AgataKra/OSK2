
namespace OSK2
{
    partial class Test3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Tester parent;
        private int time_low = 500;
        private int time_high = 1000;
        private bool testing = false;
        private int[] result = { 0, 0, 0, 0, 0 };
        private bool wait = true;
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
            this.help_test3 = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.panel_test = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_test3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help_test3
            // 
            this.help_test3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test3ToolStripMenuItem});
            this.help_test3.Name = "help_test3";
            this.help_test3.Size = new System.Drawing.Size(57, 20);
            this.help_test3.Text = "Pomoc";
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test3ToolStripMenuItem.Text = "Test 3";
            this.test3ToolStripMenuItem.Click += new System.EventHandler(this.test3ToolStripMenuItem_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(560, 400);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(122, 23);
            this.button_quit.TabIndex = 7;
            this.button_quit.Text = "Wyjdź bez zapisu";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(320, 400);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(122, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Zapisz wynik";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(80, 400);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(122, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Rozpocznij test";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_result.Location = new System.Drawing.Point(77, 40);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(33, 17);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "-----";
            this.label_result.Click += new System.EventHandler(this.state_Click);
            // 
            // panel_test
            // 
            this.panel_test.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_test.Location = new System.Drawing.Point(80, 60);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(600, 300);
            this.panel_test.TabIndex = 9;
            this.panel_test.Click += new System.EventHandler(this.panel_test_click);
            this.panel_test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Test3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Test3";
            this.Text = "Test3";
            this.Load += new System.EventHandler(this.Test3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help_test3;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Panel panel_test;
    }
}
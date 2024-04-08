
namespace OSK2
{
    partial class Test1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Tester parent;
        private int[] result = { 0, 0, 0, 0, 0 };
        private bool tested = false;
        private bool testing = false;
        private int time_low = 500;
        private int time_high = 2000;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_test1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_test = new System.Windows.Forms.Panel();
            this.label_result = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_test1});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // help_test1
            // 
            this.help_test1.Name = "help_test1";
            this.help_test1.Size = new System.Drawing.Size(180, 22);
            this.help_test1.Text = "Test 1";
            this.help_test1.Click += new System.EventHandler(this.help_test1_Click);
            // 
            // panel_test
            // 
            this.panel_test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_test.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_test.Controls.Add(this.label_result);
            this.panel_test.Location = new System.Drawing.Point(79, 61);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(600, 300);
            this.panel_test.TabIndex = 1;
            this.panel_test.Click += new System.EventHandler(this.panel_test_Click);
            this.panel_test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_test_Paint);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.BackColor = System.Drawing.Color.Transparent;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(120, 130);
            this.label_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(81, 31);
            this.label_result.TabIndex = 0;
            this.label_result.Text = "result";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(80, 400);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(122, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Rozpocznij test";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(320, 400);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Zapisz wynik";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(560, 400);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(122, 23);
            this.quit.TabIndex = 4;
            this.quit.Text = "Wyjdź bez zapisu";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(80, 41);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(22, 13);
            this.state.TabIndex = 5;
            this.state.Text = "-----";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.state);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Test1";
            this.Text = "Test1";
            this.Load += new System.EventHandler(this.Test1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_test.ResumeLayout(false);
            this.panel_test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_test1;
        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.ImageList imageList1;
    }
}
using System.Drawing;
namespace OSK2
{
    partial class Test2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Tester parent;
        private Image bulb_off = OSK2.Properties.Resources.light_off;
        private Image bulb_on = OSK2.Properties.Resources.light_on;
        private int time_low = 500;
        private int time_high = 1000;
        private bool testing = false;
        private int[] result = { 0, 0, 0, 0, 0 };
        private bool on = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help_test2 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.bulb1 = new System.Windows.Forms.PictureBox();
            this.bulb2 = new System.Windows.Forms.PictureBox();
            this.bulb3 = new System.Windows.Forms.PictureBox();
            this.label_result = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_test2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help_test2
            // 
            this.help_test2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test2ToolStripMenuItem});
            this.help_test2.Name = "help_test2";
            this.help_test2.Size = new System.Drawing.Size(57, 20);
            this.help_test2.Text = "Pomoc";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(560, 400);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(122, 23);
            this.quit.TabIndex = 7;
            this.quit.Text = "Wyjdź bez zapisu";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
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
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bulb1.Image = ((System.Drawing.Image)(resources.GetObject("bulb1.Image")));
            this.bulb1.Location = new System.Drawing.Point(100, 130);
            this.bulb1.Name = "bulb1";
            this.bulb1.Size = new System.Drawing.Size(180, 180);
            this.bulb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulb1.TabIndex = 8;
            this.bulb1.TabStop = false;
            this.bulb1.Click += new System.EventHandler(this.bulb_Click);
            // 
            // bulb2
            // 
            this.bulb2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bulb2.Image = ((System.Drawing.Image)(resources.GetObject("bulb2.Image")));
            this.bulb2.Location = new System.Drawing.Point(289, 130);
            this.bulb2.Name = "bulb2";
            this.bulb2.Size = new System.Drawing.Size(180, 180);
            this.bulb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulb2.TabIndex = 9;
            this.bulb2.TabStop = false;
            this.bulb2.Click += new System.EventHandler(this.bulb_Click);
            // 
            // bulb3
            // 
            this.bulb3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bulb3.Image = ((System.Drawing.Image)(resources.GetObject("bulb3.Image")));
            this.bulb3.Location = new System.Drawing.Point(475, 130);
            this.bulb3.Name = "bulb3";
            this.bulb3.Size = new System.Drawing.Size(180, 180);
            this.bulb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulb3.TabIndex = 10;
            this.bulb3.TabStop = false;
            this.bulb3.Click += new System.EventHandler(this.bulb_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_result.Location = new System.Drawing.Point(97, 110);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(33, 17);
            this.label_result.TabIndex = 11;
            this.label_result.Text = "-----";
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.bulb3);
            this.Controls.Add(this.bulb2);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Test2";
            this.Text = "Test2";
            this.Load += new System.EventHandler(this.Test2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help_test2;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox bulb1;
        private System.Windows.Forms.PictureBox bulb2;
        private System.Windows.Forms.PictureBox bulb3;
        private System.Windows.Forms.Label label_result;
    }
}
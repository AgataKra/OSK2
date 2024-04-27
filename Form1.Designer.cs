
namespace OSK2
{
    partial class Tester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Test1 window1;
        public Test2 window2;
        public Test3 window3;
        public Wyniki window4;
        public int[,] results = { { 100, 0, 300, 0, 0 }, { 0, 200, 700, 300, 0 }, { 0, 500, 200, 0, 400 } };
        public string help_tester_message = "Program umożliwia przeprowadzenie testu zdolności psychomotorycznych " +
                "na podstawie czasu reakcji osoby testowanej. \n \n" +
                "Każdy test sprawdza czas reakcji osoby testowanej w inny sposób, określony " +
                "w pomocy do poszczególnych testów.\n" +
                "Test 1: Czas reakcji na zmianę koloru na ekranie\n" +
                "Test 2: Czas reakcji na zmianę wyglądu jednego z elementów na ekranie\n" +
                "Test 3: Czas reakcji na pojawienie się dźwięku";
        public string help_test1_message = "Test 1: Sprawdzenie czasu reakcji na zmianę koloru na ekranie\n\n" +
            "Po rozpoczęciu testu, okno testowe zmieni kolor na czerwony.\n" +
            "W momencie zmiany koloru okna testowego na zielony, należy jak najszybciej kliknąć " +
            "lewym przyciskiem myszy na okno testowe.\n" +
            "Po kliknięciu na ekranie pojawi się czas reakcji osoby testowanej. \n\n" +
            "Dwie pierwsze próby mają miarę szkolenia i nie są wliczane do wyniku.\n" +
            "Następne pięć prób stanowi test.";
        public string help_test2_message = "Test 2: Sprawdzenie czasu reakcji na zmianę wyglądu jednego z elementów na ekranie\n" +
            "Po rozpoczęciu testu na ekranie pojawią się trzy niezapalone żarówki. \n" +
            "Po zapaleniu jednej z żarówek, należy kliknąć na nią jak najszybciej lewym przyciskiem myszki. \n" +
            "Po kliknięciu na ekranie pojawi się czas reakcji osoby testowanej. \n\n" +
            "Dwie pierwsze próby mają miarę szkolenia i nie są wliczane do wyniku.\n" +
            "Następne pięć prób stanowi test.";
        public string help_test3_message = "Test 3: Sprawdzenie czasu reakcji na bodziec dźwiękowy\n\n" +
            "Po rozpoczęciu testu okno testowe zmieni kolor na czarny.\n" +
            "Po pewnym czasie pojawi się bodziec dźwiękowy. " +
            "Po jego pojawieniu się, należy jak najszybciej kliknąć na okno testowe lewym przyciskiem myszki.\n" +
            "Po kliknięciu na ekranie pojawi się czas reakcji osoby testowanej. \n\n" +
            "Dwie pierwsze próby mają miarę szkolenia i nie są wliczane do wyniku.\n" +
            "Następne pięć prób stanowi test.";
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
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_tester = new System.Windows.Forms.ToolStripMenuItem();
            this.help_test1 = new System.Windows.Forms.ToolStripMenuItem();
            this.help_test2 = new System.Windows.Forms.ToolStripMenuItem();
            this.help_test3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_test1 = new System.Windows.Forms.Label();
            this.label_test2 = new System.Windows.Forms.Label();
            this.label_test3 = new System.Windows.Forms.Label();
            this.button_test1 = new System.Windows.Forms.Button();
            this.button_test2 = new System.Windows.Forms.Button();
            this.button_test3 = new System.Windows.Forms.Button();
            this.button_results = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_tester,
            this.help_test1,
            this.help_test2,
            this.help_test3});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // help_tester
            // 
            this.help_tester.Name = "help_tester";
            this.help_tester.Size = new System.Drawing.Size(131, 26);
            this.help_tester.Text = "Tester";
            this.help_tester.Click += new System.EventHandler(this.help_tester_Click);
            // 
            // help_test1
            // 
            this.help_test1.Name = "help_test1";
            this.help_test1.Size = new System.Drawing.Size(131, 26);
            this.help_test1.Text = "Test 1";
            this.help_test1.Click += new System.EventHandler(this.help_test1_Click);
            // 
            // help_test2
            // 
            this.help_test2.Name = "help_test2";
            this.help_test2.Size = new System.Drawing.Size(131, 26);
            this.help_test2.Text = "Test 2";
            this.help_test2.Click += new System.EventHandler(this.help_test2_Click);
            // 
            // help_test3
            // 
            this.help_test3.Name = "help_test3";
            this.help_test3.Size = new System.Drawing.Size(131, 26);
            this.help_test3.Text = "Test 3";
            this.help_test3.Click += new System.EventHandler(this.help_test3_Click);
            // 
            // label_test1
            // 
            this.label_test1.AutoSize = true;
            this.label_test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_test1.Location = new System.Drawing.Point(80, 74);
            this.label_test1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test1.Name = "label_test1";
            this.label_test1.Size = new System.Drawing.Size(227, 20);
            this.label_test1.TabIndex = 1;
            this.label_test1.Text = "Test 1 - Test optyczny prosty";
            // 
            // label_test2
            // 
            this.label_test2.AutoSize = true;
            this.label_test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_test2.Location = new System.Drawing.Point(80, 222);
            this.label_test2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test2.Name = "label_test2";
            this.label_test2.Size = new System.Drawing.Size(238, 20);
            this.label_test2.TabIndex = 2;
            this.label_test2.Text = "Test 2 - Test optyczny złożony";
            // 
            // label_test3
            // 
            this.label_test3.AutoSize = true;
            this.label_test3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_test3.Location = new System.Drawing.Point(80, 369);
            this.label_test3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test3.Name = "label_test3";
            this.label_test3.Size = new System.Drawing.Size(193, 20);
            this.label_test3.TabIndex = 3;
            this.label_test3.Text = "Test 3 - Test akustyczny";
            // 
            // button_test1
            // 
            this.button_test1.Location = new System.Drawing.Point(84, 98);
            this.button_test1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test1.Name = "button_test1";
            this.button_test1.Size = new System.Drawing.Size(252, 28);
            this.button_test1.TabIndex = 4;
            this.button_test1.Text = "Rozpocznij test";
            this.button_test1.UseVisualStyleBackColor = true;
            this.button_test1.Click += new System.EventHandler(this.button_test1_Click);
            // 
            // button_test2
            // 
            this.button_test2.Location = new System.Drawing.Point(84, 246);
            this.button_test2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test2.Name = "button_test2";
            this.button_test2.Size = new System.Drawing.Size(252, 28);
            this.button_test2.TabIndex = 5;
            this.button_test2.Text = "Rozpocznij test";
            this.button_test2.UseVisualStyleBackColor = true;
            this.button_test2.Click += new System.EventHandler(this.button_test2_Click);
            // 
            // button_test3
            // 
            this.button_test3.Location = new System.Drawing.Point(84, 394);
            this.button_test3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test3.Name = "button_test3";
            this.button_test3.Size = new System.Drawing.Size(252, 28);
            this.button_test3.TabIndex = 6;
            this.button_test3.Text = "Rozpocznij test";
            this.button_test3.UseVisualStyleBackColor = true;
            this.button_test3.Click += new System.EventHandler(this.button_test3_Click);
            // 
            // button_results
            // 
            this.button_results.Location = new System.Drawing.Point(587, 185);
            this.button_results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_results.Name = "button_results";
            this.button_results.Size = new System.Drawing.Size(351, 53);
            this.button_results.TabIndex = 7;
            this.button_results.Text = "Pokaż wyniki";
            this.button_results.UseVisualStyleBackColor = true;
            this.button_results.Click += new System.EventHandler(this.button_results_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(587, 295);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(351, 52);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Nowy tester";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_results);
            this.Controls.Add(this.button_test3);
            this.Controls.Add(this.button_test2);
            this.Controls.Add(this.button_test1);
            this.Controls.Add(this.label_test3);
            this.Controls.Add(this.label_test2);
            this.Controls.Add(this.label_test1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tester";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_tester;
        private System.Windows.Forms.ToolStripMenuItem help_test1;
        private System.Windows.Forms.ToolStripMenuItem help_test2;
        private System.Windows.Forms.ToolStripMenuItem help_test3;
        private System.Windows.Forms.Label label_test1;
        private System.Windows.Forms.Label label_test2;
        private System.Windows.Forms.Label label_test3;
        private System.Windows.Forms.Button button_test1;
        private System.Windows.Forms.Button button_test2;
        private System.Windows.Forms.Button button_test3;
        private System.Windows.Forms.Button button_results;
        private System.Windows.Forms.Button button_reset;
    }
}


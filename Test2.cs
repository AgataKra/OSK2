using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime; 
namespace OSK2
{
    public partial class Test2 : Form
    {
        public Test2(Tester parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public Stopwatch clock = new Stopwatch();
        Random rand_time = new Random();
        Random rand_num = new Random();
        int number;
        private void Test2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.parent.help_test2_message);
        }
        private void bulb_Click(object sender, EventArgs e)
        {
            PictureBox[] boxes = { bulb1, bulb2, bulb3 };
            if (number == Array.IndexOf(boxes, (PictureBox)sender) && this.testing)
            {
                clock.Stop();
                this.testing = false;
            }
            else if (this.on)
            {
                boxes[number].Image = bulb_off;
                this.on = false;
            }
        }
        private async void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            PictureBox[] boxes = {bulb1, bulb2, bulb3};
            for (int i = 0; i < 7; i++)
            {
                number = rand_num.Next(0, 3);
                await Task.Delay(rand_time.Next(time_low, time_high)); // Random delay between 1 to 5 seconds
                this.on = true;
                boxes[number].Image = bulb_on;
                clock.Start();
                this.testing = true;
                // Wait for user click
                while (this.testing)
                {
                    Application.DoEvents(); // Allows the UI to continue responding
                }
                TimeSpan reaction_time = clock.Elapsed;
                if (i > 1)
                {
                    this.result[i - 2] = (int)reaction_time.TotalMilliseconds;
                }
                label_result.Text = $"Reaction time: {reaction_time.TotalMilliseconds} ms";
                clock.Reset();
                while (this.on)
                {
                    Application.DoEvents();
                }
            }
            button_start.Enabled = true;
            label_result.Text = "Koniec testu! Zapisz wynik lub spróbuj ponownie";
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.result.Length; i++)
            {
                this.parent.results[1, i] = this.result[i];
            }
        }
        private void quit_Click(object sender, EventArgs e)
        {
            this.clock.Reset();
            for (int i = 0; i < this.result.Length; i++)
            {
                this.result[i] = 0;
                this.parent.results[1, i] = 0;
            }
            this.Dispose();
            this.Close();
        }
        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.parent.help_test2_message);
        }
    }
}

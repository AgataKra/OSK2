using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
namespace OSK2
{
    public partial class Test3 : Form
    {
        public Test3(Tester parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        SoundPlayer sound = new SoundPlayer("sound.wav");
        public Stopwatch clock = new Stopwatch();
        Random rand = new Random();
        private void Test3_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.parent.help_test3_message);
        }

        private void state_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            panel_test.BackColor = Color.Blue;

            for (int i = 0; i < 7; i++)
            {
                await Task.Delay(rand.Next(time_low, time_high)); // Random delay between 1 to 5 seconds
                clock.Start();
                sound.Play();
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
                this.wait = true;
                while (this.wait)
                {
                    Application.DoEvents();
                }
            }
            button_start.Enabled = true;
            label_result.Text = "Koniec testu! Zapisz wynik lub spróbuj ponownie";
        } 

        private void panel_test_click(object sender, EventArgs e)
        {
            if (this.testing)
            {
                clock.Stop();
                this.testing = !this.testing;
            }
            else if (this.wait)
            {
                this.wait = !this.wait;
                this.label_result.Text = "";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.result.Length; i++)
            {
                this.parent.results[1, i] = this.result[i];
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.result.Length; i++)
            {
                this.result[i] = 0;
                this.parent.results[2, i] = 0;
            }
        }

        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.parent.help_test3_message);
        }
    }
}

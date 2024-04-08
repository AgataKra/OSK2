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
using System.Threading;

namespace OSK2
{
    public partial class Test1 : Form
    {
        public Test1(Tester parent)
        {
            this.parent = parent;     
            InitializeComponent();
        }
        public Stopwatch clock = new Stopwatch();
        Random rand = new Random();
        private void Test1_Load(object sender, EventArgs e)
        {
            this.label_result.Text = "";
            MessageBox.Show(this.parent.help_test1_message);
        }

        private async void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            panel_test.BackColor = Color.Red;
            
            for (int i = 0; i < 7; i++)
            {
                await Task.Delay(rand.Next(time_low, time_high)); // Random delay between 1 to 5 seconds
                panel_test.BackColor = Color.Green;
                clock.Start();
                this.testing = true;
                // Wait for user click
                while (this.testing)
                {
                    Application.DoEvents(); // Allows the UI to continue responding
                }
                clock.Stop();
                TimeSpan reaction_time = clock.Elapsed;
                if (i > 1)
                {
                    this.result[i - 2] = (int)reaction_time.TotalMilliseconds;
                }
                label_result.Text = $"Reaction time: {reaction_time.TotalMilliseconds} ms";
                clock.Reset();
                while(panel_test.BackColor == Color.Green)
                {
                    Application.DoEvents();
                }
            }
            button_start.Enabled = true;
            label_result.Text = "Koniec testu! \n Zapisz wynik lub spróbuj ponownie";
            this.BackColor = Color.Gray;
        }

        private void panel_test_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_test_Click(object sender, EventArgs e)
        {
            if (panel_test.BackColor == Color.Green && this.testing)
            {
                this.testing = false;
            }
            else if (panel_test.BackColor == Color.Green && !this.testing)
            {
                panel_test.BackColor = Color.Red;
                label_result.Text = "";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.result.Length; i++)
            {
                this.parent.results[0, i] = this.result[i];
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.result.Length; i++)
            {
                this.result[i] = 0;
                this.parent.results[0, i] = 0;
            }
        }

        private void help_test1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.parent.help_test1_message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK2
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }
        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button_test1_Click(object sender, EventArgs e)
        {
            window1 = new Test1(this);
            window1.ShowDialog();
        }
        private void button_test2_Click(object sender, EventArgs e)
        {
            window2 = new Test2(this);
            window2.ShowDialog();
        }
        private void button_test3_Click(object sender, EventArgs e)
        {
            window3 = new Test3(this);
            window3.ShowDialog();
        }
        private void button_results_Click(object sender, EventArgs e)
        {
            window4 = new Wyniki(this.results, this);
            window4.ShowDialog();
        }
        private void help_tester_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.help_tester_message);
        }
        private void help_test1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.help_test1_message);
        }
        private void help_test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.help_test2_message);
        }
        private void help_test3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.help_test3_message);
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                this.results[0, i] = 0;
                this.results[1, i] = 0;
                this.results[2, i] = 0;
            }
        }
    }
}

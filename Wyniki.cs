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
    public partial class Wyniki : Form
    {
        public Wyniki(int[,] results, Tester parent)
        {
            for (int i = 0; i < 5; i++)
            {
                this.results1[i] = results[0, i];
                this.results2[i] = results[1, i];
                this.results3[i] = results[2, i];
                this.mean[0] += this.results1[i]/5;
                this.mean[1] += this.results2[i]/5;
                this.mean[2] += this.results3[i]/5;
            }
            
            this.parent = parent;           
            InitializeComponent();
            this.label_mean1.Text = this.mean[0].ToString() + " ms";
            this.label_mean2.Text = this.mean[1].ToString() + " ms";
            this.label_mean3.Text = this.mean[2].ToString() + " ms";
        }

        private void Wyniki_Load(object sender, EventArgs e)
        {
            chart1.Series["Test 1"].Points.DataBindXY(indexes, results1);
            chart1.Series["Test 2"].Points.DataBindXY(indexes, results2);
            chart1.Series["Test 3"].Points.DataBindXY(indexes, results3);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

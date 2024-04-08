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
            }
            this.parent = parent;
            InitializeComponent();
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
    }
}

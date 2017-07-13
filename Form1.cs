using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalc_Click(object sender, EventArgs e)
        {
            Double dblMiles, dblGallons, dblMPG;
            if (double.TryParse(txtMiles.Text, out dblMiles))
            { 
                if (double.TryParse(txtGallons.Text, out dblGallons))
                {
                dblMPG = dblMiles / dblGallons;
                lblOut.Text = dblMPG.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2_1_Vika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal classAPrice = 15m;
            const decimal classBPrice = 12m;
            const decimal classCPrice = 9m;

            int ticketsA, ticketsB, ticketsC;
            decimal revenueA, revenueB, revenueC, totalRevenue;

            if (int.TryParse(txtClassA.Text, out ticketsA) &&
               int.TryParse(txtClassB.Text, out ticketsB) &&
               int.TryParse(txtClassC.Text, out ticketsC))
            {
                revenueA = ticketsA * classAPrice;
                revenueB = ticketsB * classBPrice;
                revenueC = ticketsC * classCPrice;

                totalRevenue = revenueA + revenueB + revenueC;

                txtRevenueA.Text = revenueA.ToString("0.00 €");
                txtRevenueB.Text = revenueB.ToString("0.00 €");
                txtRevenueC.Text = revenueC.ToString("0.00 €");

                txtTotalRevenue.Text = totalRevenue.ToString("0.00 €");
            }
            else
            {
                MessageBox.Show("Please enter valid ticket numbers.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();

            txtRevenueA.Clear();
            txtRevenueB.Clear();
            txtRevenueC.Clear();
            txtTotalRevenue.Clear();
        }

        private void txtClassA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

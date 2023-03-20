using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishList.Text;
        }

        private void selectionOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("iPhone 14 Pro Max Fully Paid");
            wishList.Items.Add("House n Lot");
            wishList.Items.Add("Travel to Switzerland");
            wishList.Items.Add("Black Pink Concert Ticket");
            wishList.Items.Add("Jackpot Lottery");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishList.Items.Count);              
        }
    }
}

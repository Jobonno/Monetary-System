using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monetary_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCoins_Click(object sender, EventArgs e)
        {
            int[] coins = new int[4] {50,20,10,5};
            int[] count = new int[4] {0,0,0,0};
            int input = int.Parse(txtInput.Text);
            
            input = input % 100;
            for (int i = 0; i < coins.Length; i++)
            {
                count[i] = input / coins[i];
                input = input % coins[i];
            }
            MessageBox.Show("50 :" + count[0] + "\n20 :" + count[1] + "\n10 :" + count[2] + "\n5 :" + count[3] );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

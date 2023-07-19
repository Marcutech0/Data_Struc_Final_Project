using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FO
{
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
            
        }
        public void  test()
        {
            Cashier cashier = new Cashier();
            string text = cashier.LABEL12.Text;
            textBox1.Text = text;
        }
        private void Discount_Load(object sender, EventArgs e)
        {

            test();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

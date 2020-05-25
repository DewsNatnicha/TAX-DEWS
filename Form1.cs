using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX_DEWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBpaym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBbouns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBpayelse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int paym = int.Parse(TBpaym.Text);
            int bouns = int.Parse(TBbouns.Text);
            int payelse = int.Parse(TBpayelse.Text);
            int earnall = (paym * 12) + bouns + payelse;
            TBearn.Text = earnall.ToString();
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            calTAX main = new calTAX(TBearn.Text);
            Form3 sum = new Form3();
            Group1 one = new Group1(TBearn.Text);
            Group2 two = new Group2();
            Group3 three = new Group3();
            Group4 four = new Group4();
            Group5 five = new Group5();
            one.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TEXpaer paer = new TEXpaer();

            int P50 = int.Parse(TBearn.Text) * 50 / 100;
            if (P50 >= 100000)
            { TB50.Text = "100000"; }
            else { TB50.Text = P50.ToString(); }

            TBsumtax.Text = (int.Parse(g1.Text) + int.Parse(g2.Text) + int.Parse(g3.Text) + int.Parse(g4.Text) + int.Parse(g5.Text)).ToString();
            //TBsumtax.Text = (int.Parse(g5.Text)).ToString();

            //รวมเงินได้สุทธิ
            /*int earnall = int.Parse(TBearn.Text) - int.Parse(TBsumtax.Text);
            if (earnall < 0) { TBearnall.Text = "0"; }
            else { TBearnall.Text = earnall.ToString(); }*/

            //ภาษี
            int taxAll = int.Parse(TBearnall.Text) - int.Parse(TBsumtax.Text);

            if (taxAll > 5000000)
            {
                //35%
                int TTTAAAXXX = (taxAll * 35) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 2000000)
            {
                //30%
                int TTTAAAXXX = (taxAll * 30) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 1000000)
            {
                //25%
                int TTTAAAXXX = (taxAll * 25) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 750000)
            {
                //20%
                int TTTAAAXXX = (taxAll * 20) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 500000)
            {
                //15%
                int TTTAAAXXX = (taxAll * 15) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 300000)
            {
                //10%
                int TTTAAAXXX = (taxAll * 10) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll >= 150000)
            {
                //5%
                int TTTAAAXXX = (taxAll * 5) / 100;
                TBtax.Text = TTTAAAXXX.ToString();
            }
            else if (taxAll < 150000)
            {
                int TTTAAAXXX = 0;
                TBtax.Text = TTTAAAXXX.ToString();
            }
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            calTAX main = new calTAX(TBearn.Text);
            main.Show();
            this.Hide();
        }
    }
}

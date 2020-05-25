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
    public partial class Group4 : Form
    {
        public Group4()
        {
            InitializeComponent();
        }
        private void BTcal_Click(object sender, EventArgs e)
        {
            int earnLOB = (int.Parse(TBearn.Text) * 10 / 100);
            if (int.Parse(TBforedu.Text) >= earnLOB)
            { TBforedusum.Text = earnLOB.ToString(); }
            else { TBforedusum.Text = TBforedu.Text; }

            //บรจาคใหญ่
            TBforedu.Text = (int.Parse(TBedu1.Text) + int.Parse(TBedu2.Text) + int.Parse(TBedu3.Text) + int.Parse(TBedu4.Text)).ToString();
            int foredusum = int.Parse(TBforedu.Text) * 2;
            if (foredusum >= (int.Parse(TBearnLOB.Text) * 10)/100)
            { TBforedusum.Text = ((int.Parse(TBearnLOB.Text) * 10)/100).ToString(); }
            else { TBforedusum.Text = foredusum.ToString(); }
            //น้ำท่วม
            TBfloodsum.Text = (int.Parse(TBflood.Text)).ToString();
            TBelsesum.Text = (int.Parse(TBelse.Text)).ToString();
            //เงินบริจาคให้พรรคการเมือง
            if (int.Parse(TBPolitical.Text) >= 10000)
            { TBPoliticalsum.Text = "10000"; }
            if (int.Parse(TBPolitical.Text) < 10000)
            { TBPoliticalsum.Text = TBPolitical.Text; }

            TBdeduction.Text = (int.Parse(TBforedusum.Text) + int.Parse(TBfloodsum.Text) + int.Parse(TBelsesum.Text) + int.Parse(TBPoliticalsum.Text)).ToString();
        }

        private void BTcalall_Click(object sender, EventArgs e)
        {
            //รวมเงินได้สุทธิ
            int earn = int.Parse(TBearn.Text);
            int tax = int.Parse(TBdeduction.Text);
            int sum = earn - tax;
            if (sum < 0) { TBall.Text = "0"; }
            else { TBall.Text = sum.ToString(); }

            //ภาษี
            int Alltax = int.Parse(TBdeduction.Text);
            int Asum = int.Parse(TBall.Text);

            int taxAll = Asum - Alltax;

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

        #region กรุณาระบุ
        private void TBforedu_Enter(object sender, EventArgs e)
        {
            if (TBforedu.Text == "- กรุณาระบุ -")
            { TBforedu.Text = ""; }
        }

        private void TBforedu_Leave(object sender, EventArgs e)
        {
            if (TBforedu.Text == "")
            { TBforedu.Text = "- กรุณาระบุ -"; }
        }

        private void TBflood_Enter(object sender, EventArgs e)
        {
            if (TBflood.Text == "- กรุณาระบุ -")
            { TBflood.Text = ""; }
        }

        private void TBflood_Leave(object sender, EventArgs e)
        {
            if (TBflood.Text == "")
            { TBflood.Text = "- กรุณาระบุ -"; }
        }

        private void TBelse_Enter(object sender, EventArgs e)
        {
            if (TBelse.Text == "- กรุณาระบุ -")
            { TBelse.Text = ""; }
        }

        private void TBelse_Leave(object sender, EventArgs e)
        {
            if (TBelse.Text == "")
            { TBelse.Text = "- กรุณาระบุ -"; }
        }

        private void TBPolitical_Enter(object sender, EventArgs e)
        {
            if (TBPolitical.Text == "- กรุณาระบุ -")
            { TBPolitical.Text = ""; }
        }

        private void TBPolitical_Leave(object sender, EventArgs e)
        {
            if (TBPolitical.Text == "")
            { TBPolitical.Text = "- กรุณาระบุ -"; }
        }

        private void TBedu1_Enter(object sender, EventArgs e)
        {
            if (TBedu1.Text == "- กรุณาระบุ -")
            { TBedu1.Text = ""; }
        }

        private void TBedu1_Leave(object sender, EventArgs e)
        {
            if (TBedu1.Text == "")
            { TBedu1.Text = "- กรุณาระบุ -"; }
        }

        private void TBedu2_Enter(object sender, EventArgs e)
        {
            if (TBedu2.Text == "- กรุณาระบุ -")
            { TBedu2.Text = ""; }
        }

        private void TBedu2_Leave(object sender, EventArgs e)
        {
            if (TBedu2.Text == "")
            { TBedu2.Text = "- กรุณาระบุ -"; }
        }

        private void TBedu3_Enter(object sender, EventArgs e)
        {
            if (TBedu3.Text == "- กรุณาระบุ -")
            { TBedu3.Text = ""; }
        }

        private void TBedu3_Leave(object sender, EventArgs e)
        {
            if (TBedu3.Text == "")
            { TBedu3.Text = "- กรุณาระบุ -"; }
        }

        private void TBedu4_Enter(object sender, EventArgs e)
        {
            if (TBedu4.Text == "- กรุณาระบุ -")
            { TBedu4.Text = ""; }
        }

        private void TBedu4_Leave(object sender, EventArgs e)
        {
            if (TBedu4.Text == "")
            { TBedu4.Text = "- กรุณาระบุ -"; }
        }
        #endregion

        private void Group4_Load(object sender, EventArgs e)
        {
            TBearnLOB.Text = (int.Parse(TBearn.Text)*10/100).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group5 g5 = new Group5();
            g5.g1.Text = g1.Text;
            g5.g2.Text = g2.Text;
            g5.g3.Text = g3.Text;
            g5.earn.Text = earn.Text;
            g5.TBearn.Text = TBall.Text;
            g5.g4.Text = TBdeduction.Text;
            g5.Show();
        }

        #region กรอกเฉพาะตัวเลข
        private void TBedu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBedu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBedu3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBedu4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBflood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBelse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBPolitical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

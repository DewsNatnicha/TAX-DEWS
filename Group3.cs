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
    public partial class Group3 : Form
    {
        public Group3()
        {
            InitializeComponent();
        }

        #region กรุณาระบุ
        private void TBinterest_Enter(object sender, EventArgs e)
        {
            if (TBhome.Text == "- กรุณาระบุ -")
            { TBhome.Text = ""; }
        }

        private void TBinterest_Leave(object sender, EventArgs e)
        {
            if (TBhome.Text == "")
            { TBhome.Text = "- กรุณาระบุ -"; }
        }

        private void TB58_Enter(object sender, EventArgs e)
        {
            if (TB58.Text == "- กรุณาระบุ -")
            { TB58.Text = ""; }
        }

        private void TB58_Leave(object sender, EventArgs e)
        {
            if (TB58.Text == "")
            { TB58.Text = "- กรุณาระบุ -"; }
        }

        private void TB62_Enter(object sender, EventArgs e)
        {
            if (TB62.Text == "- กรุณาระบุ -")
            { TB62.Text = ""; }
        }

        private void TB62_Leave(object sender, EventArgs e)
        {
            if (TB62.Text == "")
            { TB62.Text = "- กรุณาระบุ -"; }
        }

        private void TBinterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB58_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB62_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

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

            TEXpaer paer = new TEXpaer();
            paer.Group3 = TBall.Text;
        }

        private void BTcal_Click(object sender, EventArgs e)
        {
            //ดอกเบี้ยที่อยู่อาศัย
            if (int.Parse(TBhome.Text) >= 100000)
            { TBhomesum.Text = "100000"; }
            else { TBhomesum.Text = TBhome.Text; }

            if (RB58.Checked)
            { 
                //บ้าน2558                
                //เวลา 5 ปี รวม 20%
                TB58year5.Text = (int.Parse(TB58.Text) * 20/ 100).ToString();
                //เฉลี่ยต่อปี
                TB58yaer.Text = (int.Parse(TB58year5.Text) / 5).ToString();
                //รวมลดหย่อนภาษี = ดอกเบี้ยบ้าน+เฉลี่ยต่อปี
                TBsum58.Text = (int.Parse(TBhomesum.Text) + int.Parse(TB58yaer.Text)).ToString();
            }

            if (RB62.Checked)
            {
                //บ้าน2562
                if (int.Parse(TB62.Text) >= 5000000)
                { TB62sum.Text = "5000000"; }
                else { TB62sum.Text = TB62.Text; }
                //รวมลดหย่อนภาษี = ดอกเบี้ยบ้าน+เฉลี่ยต่อปี
                int sum62 = int.Parse(TBhomesum.Text) + int.Parse(TB62sum.Text);
                if (sum62 >= 200000)
                { TBsum62.Text = "200000"; }
                else { TBsum62.Text = sum62.ToString(); }
            }
            //รวมค่าลดหย่อน
            if (RB58.Checked)
            { TBdeduction.Text = (int.Parse(TBsum58.Text) + int.Parse(TBhomesum.Text)).ToString(); }
            if (RB62.Checked)
            { TBdeduction.Text = (int.Parse(TBsum62.Text) + int.Parse(TBhomesum.Text)).ToString(); }

        }

        private void RB58_CheckedChanged(object sender, EventArgs e)
        {
            if (RB58.Checked)
            {
                TB62.Enabled = false;
                TB62sum.Enabled = false;
                TBsum62.Enabled = false;
            }
            else
            {
                TB62.Enabled = true;
                TB62sum.Enabled = true;
                TBsum62.Enabled = true;
            }
        }

        private void RB62_CheckedChanged(object sender, EventArgs e)
        {
            if (RB62.Checked)
            {
                TB58.Enabled = false;
                TB58year5.Enabled = false;
                TB58yaer.Enabled = false;
                TBsum58.Enabled = false;
            }
            else
            {
                TB58.Enabled = true;
                TB58year5.Enabled = true;
                TB58yaer.Enabled = true;
                TBsum58.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group4 g4 = new Group4();
            g4.g1.Text = g1.Text;
            g4.g2.Text = g2.Text;
            g4.earn.Text = earn.Text;
            g4.TBearn.Text = TBall.Text;
            g4.g3.Text = TBdeduction.Text;
            g4.Show();
        }
    }
}

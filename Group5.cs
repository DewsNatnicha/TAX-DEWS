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
    public partial class Group5 : Form
    {
        public Group5()
        {
            InitializeComponent();
        }
        private void BTcal_Click(object sender, EventArgs e)
        {
            //ช้อปช่วยชาติ
            if (int.Parse(TBshop.Text) >= 15000)
            { TBshopsum.Text = "15000"; }
            if (int.Parse(TBshop.Text) < 15000)
            { TBshopsum.Text = TBshop.Text; }

            //ซื้อสินค้าเกี่ยวกับการศึกษาและกีฬา
            if (int.Parse(TBedu.Text) >= 15000)
            { TBedusum.Text = "15000"; }
            if (int.Parse(TBedu.Text) < 15000)
            { TBedusum.Text = TBedu.Text; }

            //ซื้อหนังสือ
            if (int.Parse(TBbook.Text) >= 15000)
            { TBshopsum.Text = "15000"; }
            if (int.Parse(TBbook.Text) < 15000)
            { TBshopsum.Text = TBbook.Text; }

            //ซื้อสินค้าโอทอป (OTOP)
            if (int.Parse(TBotop.Text) >= 15000)
            { TBbooksum.Text = "15000"; }
            if (int.Parse(TBotop.Text) < 15000)
            { TBbooksum.Text = TBotop.Text; }

            //เมืองหลัก
            if (int.Parse(TBthai1.Text) >= 15000)
            { TBthai1sum.Text = "15000"; }
            if (int.Parse(TBthai1.Text) < 15000)
            { TBthai1sum.Text = TBthai1.Text; }

            //เมืองรอง
            if (int.Parse(TBthai2.Text) >= 20000)
            { TBthai2sum.Text = "20000"; }
            if (int.Parse(TBthai2.Text) < 20000)
            { TBthai2sum.Text = TBthai2.Text; }

            //รวมเมืองหลัก+เมืองรอง
            int thaisum = int.Parse(TBthai2sum.Text) + int.Parse(TBthai1sum.Text);
            if (int.Parse(TBthaisum.Text) >= 20000)
            { TBthaisum.Text = "20000"; }
            if (int.Parse(TBthaisum.Text) < 20000)
            { TBthaisum.Text = thaisum.ToString(); }

            //ค่าซ่อมบ้าน
            if (int.Parse(TBhome.Text) >= 100000)
            { TBhomesum.Text = "100000"; }
            if (int.Parse(TBhome.Text) < 100000)
            { TBhomesum.Text = TBhome.Text; }

            //ค่าซ่อมรถ
            if (int.Parse(TBcar.Text) >= 30000)
            { TBcarsum.Text = "30000"; }
            if (int.Parse(TBcar.Text) < 30000)
            { TBcarsum.Text = TBcar.Text; }

            TBdeduction.Text = (int.Parse(TBshopsum.Text) + int.Parse(TBedusum.Text) + int.Parse(TBbooksum.Text) + int.Parse(TBotopsum.Text) + int.Parse(TBthaisum.Text) + int.Parse(TBhomesum.Text) + int.Parse(TBcarsum.Text)).ToString();
        }

        private void BTcalall_Click(object sender, EventArgs e)
        {
            //รวมเงินได้สุทธิ
            int earn = int.Parse(TBearn.Text);
            int tax = int.Parse(TBdeduction.Text);
            int sum = earn - tax;
            TBall.Text = sum.ToString();
            if (sum < 0) { TBall.Text = "0"; }

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
            paer.Group5 = TBall.Text;
        }

        #region กรุณาระบุ
        private void TBshop_Enter(object sender, EventArgs e)
        {
            if (TBshop.Text == "- กรุณาระบุ -")
            { TBshop.Text = ""; }
        }

        private void TBshop_Leave(object sender, EventArgs e)
        {
            if (TBshop.Text == "")
            { TBshop.Text = "- กรุณาระบุ -"; }
        }

        private void TBedu_Enter(object sender, EventArgs e)
        {
            if (TBedu.Text == "- กรุณาระบุ -")
            { TBedu.Text = ""; }
        }

        private void TBedu_Leave(object sender, EventArgs e)
        {
            if (TBedu.Text == "")
            { TBedu.Text = "- กรุณาระบุ -"; }
        }

        private void TBbook_Enter(object sender, EventArgs e)
        {
            if (TBbook.Text == "- กรุณาระบุ -")
            { TBbook.Text = ""; }
        }

        private void TBbook_Leave(object sender, EventArgs e)
        {
            if (TBbook.Text == "")
            { TBbook.Text = "- กรุณาระบุ -"; }
        }

        private void TBotop_Enter(object sender, EventArgs e)
        {
            if (TBotop.Text == "- กรุณาระบุ -")
            { TBotop.Text = ""; }
        }

        private void TBotop_Leave(object sender, EventArgs e)
        {
            if (TBotop.Text == "")
            { TBotop.Text = "- กรุณาระบุ -"; }
        }

        private void TBthai1_Enter(object sender, EventArgs e)
        {
            if (TBthai1.Text == "- กรุณาระบุ -")
            { TBthai1.Text = ""; }
        }

        private void TBthai1_Leave(object sender, EventArgs e)
        {
            if (TBthai1.Text == "")
            { TBthai1.Text = "- กรุณาระบุ -"; }
        }

        private void TBthai2_Enter(object sender, EventArgs e)
        {
            if (TBthai2.Text == "- กรุณาระบุ -")
            { TBthai2.Text = ""; }
        }

        private void TBthai2_Leave(object sender, EventArgs e)
        {
            if (TBthai2.Text == "")
            { TBthai2.Text = "- กรุณาระบุ -"; }
        }

        private void TBhome_Enter(object sender, EventArgs e)
        {
            if (TBhome.Text == "- กรุณาระบุ -")
            { TBhome.Text = ""; }
        }

        private void TBhome_Leave(object sender, EventArgs e)
        {
            if (TBhome.Text == "")
            { TBhome.Text = "- กรุณาระบุ -"; }
        }

        private void TBcar_Enter(object sender, EventArgs e)
        {
            if (TBcar.Text == "- กรุณาระบุ -")
            { TBcar.Text = ""; }
        }
        #endregion

        private void TBcar_Leave(object sender, EventArgs e)
        {
            if (TBcar.Text == "")
            { TBcar.Text = "- กรุณาระบุ -"; }
        }

        private void thaimain_Click(object sender, EventArgs e)
        {
            rak mengrak = new rak();
            mengrak.FormBorderStyle = FormBorderStyle.None;
            mengrak.ShowDialog();
            
        }

        private void thairong_Click(object sender, EventArgs e)
        {
            rong mengrong = new rong();
            mengrong.FormBorderStyle = FormBorderStyle.None;
            mengrong.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.g1.Text = g1.Text;
            f3.g2.Text = g2.Text;
            f3.g3.Text = g3.Text;
            f3.g4.Text = g4.Text;
            f3.g1.Text = g1.Text;
            f3.TBearn.Text = earn.Text;
            f3.g5.Text = TBdeduction.Text;
            f3.TBearnall.Text = TBall.Text;
            f3.Show();
        }

        #region กรอกเฉพาะตัวเลข
        private void TBshop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBedu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBotop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBthai1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBthai2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBhome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBcar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
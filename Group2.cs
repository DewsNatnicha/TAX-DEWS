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
    public partial class Group2 : Form
    {
        public Group2(string earnall)
        {
            InitializeComponent();
            TBearn.Text = earnall;
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
            paer.Group2 = TBall.Text;
        }

        #region กรุณาระบุ
        private void TBsocial_Enter(object sender, EventArgs e)
        {
            if (TBsocial.Text == "- กรุณาระบุ -")
            { TBsocial.Text = ""; }
        }

        private void TBsocial_Leave(object sender, EventArgs e)
        {
            if (TBsocial.Text == "")
            { TBsocial.Text = "- กรุณาระบุ -"; }
        }

        private void TBfamily_Enter(object sender, EventArgs e)
        {
            if (TBfamily.Text == "- กรุณาระบุ -")
            { TBfamily.Text = ""; }
        }

        private void TBfamily_Leave(object sender, EventArgs e)
        {
            if (TBfamily.Text == "")
            { TBfamily.Text = "- กรุณาระบุ -"; }
        }

        private void TBlife_Enter(object sender, EventArgs e)
        {
            if (TBlife.Text == "- กรุณาระบุ -")
            { TBlife.Text = ""; }
        }

        private void TBlife_Leave(object sender, EventArgs e)
        {
            if (TBlife.Text == "")
            { TBlife.Text = "- กรุณาระบุ -"; }
        }

        private void TBhealth_Enter(object sender, EventArgs e)
        {
            if (TBhealth.Text == "- กรุณาระบุ -")
            { TBhealth.Text = ""; }
        }

        private void TBhealth_Leave(object sender, EventArgs e)
        {
            if (TBhealth.Text == "")
            { TBhealth.Text = "- กรุณาระบุ -"; }
        }

        private void TBfm_Enter(object sender, EventArgs e)
        {
            if (TBfm.Text == "- กรุณาระบุ -")
            { TBfm.Text = ""; }
        }

        private void TBfm_Leave(object sender, EventArgs e)
        {
            if (TBfm.Text == "")
            { TBfm.Text = "- กรุณาระบุ -"; }
        }

        private void TBliving_Enter(object sender, EventArgs e)
        {
            if (TBliving.Text == "- กรุณาระบุ -")
            { TBliving.Text = ""; }
        }

        private void TBliving_Leave(object sender, EventArgs e)
        {
            if (TBliving.Text == "")
            { TBliving.Text = "- กรุณาระบุ -"; }
        }

        private void TBfund_Enter(object sender, EventArgs e)
        {
            if (TBfund.Text == "- กรุณาระบุ -")
            { TBfund.Text = ""; }
        }

        private void TBfund_Leave(object sender, EventArgs e)
        {
            if (TBfund.Text == "")
            { TBfund.Text = "- กรุณาระบุ -"; }
        }
        #endregion

        private void BTcal_Click(object sender, EventArgs e)
        {
            //ประกันสังคม
            if (int.Parse(TBsocial.Text) >= 9000)
            { TBsocialsum.Text = "9000"; }
            else { TBsocialsum.Text = TBsocial.Text; }

            //ประกันชีวิตคู่สมรส
            if (CBstatus.Text == "โสด" || CBstatus.Text == "หย่า" || CBstatus.Text == "หม้าย" || CBstatus.Text == "คู่สมรสมีเงินได้")
            { TBfamilysum.Text = "0"; }
            if (CBstatus.Text == "คู่สมรสไม่มีเงินได้")
            {
                if (int.Parse(TBfamily.Text) >= 10000)
                { TBfamilysum.Text = "10000"; }
                else { TBfamilysum.Text = TBfamily.Text; }
            }

            //เบี้ยประกันชีวิต
            if (int.Parse(TBlife.Text) >= 10000)
            { TBlifesum.Text = "10000"; }
            else { TBlifesum.Text = TBlife.Text; }

            //เบี้ยประกันสุขภาพ
            if (int.Parse(TBlife.Text) >= 10000)
            { TBlifesum.Text = "10000"; }
            else { TBlifesum.Text = TBlife.Text; }

            //รวมเบี้ยประกันชีวิต + เบี้ยประกันสุขภาพ
            int sumlifeANDhealth = int.Parse(TBlifesum.Text) + int.Parse(TBlifesum.Text);
            if (int.Parse(TBsumlifeANDhealth.Text) >= 100000)
            { TBsumlifeANDhealth.Text = "100000"; }
            else { TBsumlifeANDhealth.Text = sumlifeANDhealth.ToString(); }

            //เบี้ยประกันสุขภาพบิดา-มารดา
            if (CBfm.Text == "ไม่มี")
            { TBfmsum.Text = "0"; }
            if (CBfm.Text == "มี")
            {
                if (int.Parse(TBfm.Text) >= 15000)
                { TBfmsum.Text = "15000"; }
                else { TBfmsum.Text = TBfm.Text; }
            }

            //เงินกองทุนสำรองเลี้ยงชีพ
            if (int.Parse(TBliving.Text) >= 10000)
            { TBlivingsum.Text = "10000"; }
            else { TBlivingsum.Text = TBliving.Text; }

            //เงินสะสมกองทุน
            if ((int.Parse(TBfund.Text)) >= (int.Parse(TBearn.Text) * 15 / 100))
            {
                if (int.Parse(TBfund.Text) >= 500000)
                { TBfundsum.Text = "500000"; }
            }
            else { TBfundsum.Text = TBfund.Text; }

            TBdeduction.Text = (int.Parse(TBsocialsum.Text) + int.Parse(TBfamilysum.Text) + int.Parse(TBfmsum.Text) + int.Parse(TBsumlifeANDhealth.Text) + int.Parse(TBlivingsum.Text) + int.Parse(TBfundsum.Text)).ToString();

        }

        private void CBstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBstatus.Text == "โสด" || CBstatus.Text == "หย่า" || CBstatus.Text == "หม้าย" || CBstatus.Text == "คู่สมรสมีเงินได้")
            { TBfamily.Enabled = false; }
            else if (CBstatus.Text == "คู่สมรสไม่มีเงินได้")
            { TBfamily.Enabled = true; }
        }

        private void CBfm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBfm.Text == "ไม่มี" )
            { TBfm.Enabled = false; }
            else if (CBfm.Text == "มี")
            { TBfm.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group3 g3 = new Group3(TBearn.Text);
            g3.g1.Text = g1.Text;
            g3.g2.Text = TBall.Text;
            g3.Show();
        }
    }
}

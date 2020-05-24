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
    public partial class Group1 : Form
    {
        public Group1(string earnall)
        {
            InitializeComponent();
            TBearn.Text = earnall;
        }

        private void cal_Click(object sender, EventArgs e)
        {
            #region ส่วนตัว & ครอบครัว
            //ค่าลดหย่อนบุตร
            int babynum = int.Parse(NMbabynum.Text);
            int K60 = 0;
            //บุตรคนที่2ขึ้นไป+ปี62
            if (NMbabynum.Value >= 2 && NMbaby62.Value > 0) 
            { K60 = 60000;}
            int sumbaby = (babynum * 30000) + K60;
            TBbaby.Text = sumbaby.ToString();

            //ค่าฝากครรภ์&ค่าคลอดบุตร
            int give = int.Parse(TBgive.Text);
            if (give >= 60000)
            { TBbirth.Text = "60000"; }
            if (give < 60000)
            { TBbirth.Text = give.ToString(); }

            //ค่าอุปการะเลี้ยงดูบิดา-มารดา
            int fm1 = 0;
            if (CBfm.Text == "1") { fm1 = 1; }
            else if (CBfm.Text == "2") { fm1 = 2; }
            else { fm1 = 0; }
            int fm2 = 0;
            if (CBfm2.Text == "1") { fm2 = 1; }
            else if(CBfm2.Text == "2") { fm2 = 2; }
            else { fm2 = 0; }

            int sumfm = (fm1 + fm2) * 30000;
            TBfm.Text = sumfm.ToString();

            #endregion
            #region ข้อผิดพลาด
            //จำนวนบุตร-ธิดา ผิด!
            if (NMbabynum.Value != (NMbaby61.Value + NMbaby62.Value)) 
            { 
                MessageBox.Show("กรุณาตรวจสอบอีกครั้ง");
                NMbabynum.BackColor = Color.Red;
                NMbaby61.BackColor = Color.Red;
                NMbaby62.BackColor = Color.Red;
            }
            else
            {
                NMbabynum.BackColor = Color.White;
                NMbaby61.BackColor = Color.White;
                NMbaby62.BackColor = Color.White;
            }
            #endregion

            TBdeduction.Text = (int.Parse(TBpersonal.Text) + int.Parse(TBmate.Text) + int.Parse(TBbirth.Text) + int.Parse(TBdisabled.Text) + int.Parse(TBbaby.Text) + int.Parse(TBfm.Text)).ToString();
        }

        private void CBbaby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBbaby.Text == "ไม่มี")
            { 
                NMbabynum.Enabled = false;
                NMbaby61.Enabled = false;
                NMbaby62.Enabled = false;
            }
            else
            {
                NMbabynum.Enabled = true;
                NMbaby61.Enabled = true;
                NMbaby62.Enabled = true;
            }
        }

        private void CBstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBstatus.Text == "โสด")
            {
                CBbaby.Enabled = false;
                NMbabynum.Enabled = false;
                NMbaby61.Enabled = false;
                NMbaby62.Enabled = false;
            }
            else
            {
                CBbaby.Enabled = true;
                NMbabynum.Enabled = true;
                NMbaby61.Enabled = true;
                NMbaby62.Enabled = true;
            }

            if (CBstatus.Text == "โสด" || CBstatus.Text == "หย่า" || CBstatus.Text == "หม้าย")
            { CBfm2.Text = "ไม่มี"; CBfm2.Enabled = false; }
            else { CBfm2.Enabled = true; }

            //ค่าลดหย่อนคู่สมรส
            if (CBstatus.Text == "คู่สมรสไม่มีเงินได้")
            {
                TBmate.Text = "60000";
            }
            else { TBmate.Text = "0"; }
        }

        private void Group1_Load(object sender, EventArgs e)
        {
            //ค่าลดหย่อนส่วนตัว
            int earn = int.Parse(TBearn.Text);
            if (earn != 0)
            {
                TBpersonal.Text = "60000";
            }
            else { TBpersonal.Text = "0"; }
        }

        #region กรุณาระบุ
        private void TBgive_Enter(object sender, EventArgs e)
        {
            if (TBgive.Text == "- กรุณาระบุ -")
            { TBgive.Text = ""; }
        }

        private void TBgive_Leave(object sender, EventArgs e)
        {
            if (TBgive.Text == "")
            { TBgive.Text = "- กรุณาระบุ -"; }
        }
        #endregion

        private void NMdisabled_ValueChanged(object sender, EventArgs e)
        {
            //ค่าอุปการะคนพิการ-คนทุพพลภาพ
            TBdisabled.Text = (NMdisabled.Value * 60000).ToString();
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
            paer.Group1 = TBall.Text;

            
        }

        #region กรุณาระบุ
        private void TBgive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group2 g2 = new Group2(TBearn.Text);
            g2.g1.Text = TBall.Text;
            g2.Show();
        }
    }
}

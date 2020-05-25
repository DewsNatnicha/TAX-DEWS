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
    public partial class calTAX : Form
    {
        public calTAX(string earnall)
        {
            InitializeComponent();
            TBearn.Text = earnall;
        }
        private Form openForm;
        private void openForminpPanel(Form NongForm)
        {
            if (openForm != null)
                openForm.Close();
            openForm = NongForm;
            NongForm.TopLevel = false;
            NongForm.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(NongForm);
            flowLayoutPanel1.Tag = NongForm;
            NongForm.BringToFront();
            NongForm.Show();
        }
        private void BTgroup_Click(object sender, EventArgs e)
        {
            if (PNgroup.Visible == true)
            {
                PNgroup.Visible = false;
            }
            else
            {
                PNgroup.Visible = true;
            }

            BT1.BackColor = Color.FromArgb(64, 64, 64);
            BT2.BackColor = Color.FromArgb(64, 64, 64);
            BT3.BackColor = Color.FromArgb(64, 64, 64);
            BT4.BackColor = Color.FromArgb(64, 64, 64);
            BT5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void TBcalearn_Click(object sender, EventArgs e)
        {
            Form1 earnForm = new Form1();
            earnForm.Show();
            this.Hide();
        }
        private void BT1_Click(object sender, EventArgs e)
        {
            BT1.BackColor = Color.Maroon;
            openForminpPanel(new Group1(TBearn.Text));
            
            BT2.BackColor = Color.FromArgb(64, 64, 64);
            BT3.BackColor = Color.FromArgb(64, 64, 64);
            BT4.BackColor = Color.FromArgb(64, 64, 64);
            BT5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            BT2.BackColor = Color.Maroon;
            openForminpPanel(new Group2());

            BT1.BackColor = Color.FromArgb(64, 64, 64);
            BT3.BackColor = Color.FromArgb(64, 64, 64);
            BT4.BackColor = Color.FromArgb(64, 64, 64);
            BT5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            BT3.BackColor = Color.Maroon;
            openForminpPanel(new Group3());

            BT1.BackColor = Color.FromArgb(64, 64, 64);
            BT2.BackColor = Color.FromArgb(64, 64, 64);
            BT4.BackColor = Color.FromArgb(64, 64, 64);
            BT5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            BT4.BackColor = Color.Maroon;
            openForminpPanel(new Group4());

            BT1.BackColor = Color.FromArgb(64, 64, 64);
            BT2.BackColor = Color.FromArgb(64, 64, 64);
            BT3.BackColor = Color.FromArgb(64, 64, 64);
            BT5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            BT5.BackColor = Color.Maroon;
            openForminpPanel(new Group5());

            BT1.BackColor = Color.FromArgb(64, 64, 64);
            BT2.BackColor = Color.FromArgb(64, 64, 64);
            BT3.BackColor = Color.FromArgb(64, 64, 64);
            BT4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void calTAX_Load(object sender, EventArgs e)
        {
            PNgroup.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 sumForm = new Form3();
            sumForm.Show();
            this.Hide();
        }
    }
}

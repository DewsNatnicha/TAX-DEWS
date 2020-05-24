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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string status = CBstatus.Text;
            string baby = CBbaby.Text;
            int babynum = int.Parse(NMbabynum.Text);
            int baby61 = int.Parse(NMbaby61.Text);
            int baby62 = int.Parse(NMbaby62.Text);
            string fm = CBfm.Text;
            string fm2 = CBfm2.Text;
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            
        }
    }
}

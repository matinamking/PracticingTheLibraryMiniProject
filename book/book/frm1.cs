using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            frmcustumer frm_c = new frmcustumer();
            frm_c.ShowDialog();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            frmbook frm_b = new frmbook();
            frm_b.ShowDialog();
        }

        private void btntahvil_Click(object sender, EventArgs e)
        {
            frmbordeshode frm_bord = new frmbordeshode();
            frm_bord.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("ایا میخواهید خارج شوید؟", "خروج", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}

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
    
    public partial class frmcustumer : Form
    {
        bookEntities data = new bookEntities();
        public frmcustumer()
        {
            InitializeComponent();
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            frmsbtcustomer frm_sbtc = new frmsbtcustomer();
            frm_sbtc.ShowDialog();
            grdlist.DataSource = data.tbl_Customer.ToList();
        }

        private void frmcustumer_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tbl_Customer.ToList();
        }
        private void serch()
        {
            var qury = (from tr in data.tbl_Customer where tr.name.Contains(txtserchname.Text) && tr.family.Contains(txtserchfa.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }

        private void txtserchfa_TextChanged(object sender, EventArgs e)
        {
            serch();
        }

        private void txtserchname_TextChanged(object sender, EventArgs e)
        {
            serch();
        }
    }
}

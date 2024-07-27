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
    public partial class frmbook : Form
    {
        bookEntities data = new bookEntities();
        public frmbook()
        {
            InitializeComponent();
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            frmsbtbook frm_sbtb = new frmsbtbook();
            frm_sbtb.ShowDialog();
            grdlist.DataSource = data.tbl_book.ToList();
        }

        private void frmbook_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tbl_book.ToList();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.tbl_book where tr.name_book.Contains(txtserch.Text)select tr);
            grdlist.DataSource = qury.ToList();
        }
    }
}

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
    public partial class frmlist : Form
    {
        bookEntities data = new bookEntities();
        public frmlist()
        {
            InitializeComponent();
        }

        private void frmlist_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tbl_tahvil.ToList();
        }
        private void serch()
        {
            var qury = (from tr in data.tbl_tahvil where tr.name_customer.Contains(txtnamecustomer.Text) && tr.name_book.Contains(txtnamebook.Text) && tr.idbook.ToString().Contains(txtserchid.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }
        private void txtserchid_TextChanged(object sender, EventArgs e)
        {
            serch();
        }

        private void txtnamebook_TextChanged(object sender, EventArgs e)
        {
            serch();
        }

        private void txtnamecustomer_TextChanged(object sender, EventArgs e)
        {
            serch();
        }
    }
}

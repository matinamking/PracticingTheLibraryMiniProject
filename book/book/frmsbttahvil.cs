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
    public partial class frmsbttahvil : Form
    {
        public bookEntities data = new bookEntities();
        public int code = 0;
        public frmsbttahvil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtfamilycustomer.Text == "" ||txtnamecustomer.Text=="")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                string sindex = "";

                sindex = grdlist.CurrentRow.Cells["idbook"].Value.ToString();
                txtidbook.Text = sindex;

                sindex = grdlist.CurrentRow.Cells["name_book"].Value.ToString();
                txtnamebook.Text = sindex;

                tbl_tahvil username = new tbl_tahvil();
                username.idbook =Convert.ToInt32 (txtidbook.Text);
                username.idcustomer = code;
                username.tahvil_date = Convert.ToString(numsallb.Value + "/" + nummahb.Value + "/" + numdayb.Value);
                username.name_book = txtnamebook.Text;
                username.name_customer = txtnamecustomer.Text;
                username.family_customer = txtfamilycustomer.Text;

                data.tbl_tahvil.Add(username);
                data.SaveChanges();
                

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }

        }

        private void frmsbttahvil_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tbl_book.ToList();
        }

       
        private void txtidbook_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtidbook);
        }

        private void txtidbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

    }
}

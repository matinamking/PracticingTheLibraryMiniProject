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
    public partial class frmsbtbook : Form
    {
        bookEntities data = new bookEntities();
        public frmsbtbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtid.Text == "")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                tbl_book username = new tbl_book();
                username.name_book = txtname.Text;
                username.idbook = Convert.ToInt32(txtid.Text);
                

                data.tbl_book.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");
                txtid.Text = string.Empty;
                txtname.Text = string.Empty;

            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtid);
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
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

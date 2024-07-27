using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace book
{
    public partial class frmsbtcustomer : Form
    {
        bookEntities data = new bookEntities();
        public frmsbtcustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "" || txtfamily.Text == "" || txtmely.Text == "" ||txtnumber.Text=="")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                tbl_Customer username = new tbl_Customer();
                username.name = txtname.Text;
                username.ozviat_date = Convert.ToString(numsalloz.Value + "/" + nummahoz.Value + "/" + numdayoz.Value);
                username.birth_data = Convert.ToString(numsallb.Value + "/" + nummahb.Value + "/" + numdayb.Value);
                username.family = txtfamily.Text;
                username.numerik_fhone = txtnumber.Text;
                username.Idmely = Convert.ToInt32(txtmely.Text);

                data.tbl_Customer.Add(username);
                data.SaveChanges();
                
                MessageBox.Show("ثبت با موفقیت انجام شد");
                
            }

        }

        private void frmsbtcustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void txtmely_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtmely);
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtnumber);
        }

        private void txtmely_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void frmsbtcustomer_Load_1(object sender, EventArgs e)
        {

        }
    }
}
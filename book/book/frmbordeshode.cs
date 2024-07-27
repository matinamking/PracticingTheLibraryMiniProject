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
    public partial class frmbordeshode : Form
    {
        bookEntities data = new bookEntities();
        public frmbordeshode()
        {
            InitializeComponent();
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            string sindex = "";
            frmsbttahvil ft = new frmsbttahvil();

            ft.code=Convert.ToInt32( grdlist.CurrentRow.Cells["Idmely"].Value.ToString());
            

            sindex = grdlist.CurrentRow.Cells["name"].Value.ToString();
            ft.txtnamecustomer.Text = sindex;

            sindex = grdlist.CurrentRow.Cells["family"].Value.ToString();
            ft.txtfamilycustomer.Text = sindex;

            ft.ShowDialog();
            data = ft.data;
            grdlist.DataSource = data.tbl_Customer.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlist frm_list = new frmlist();
            frm_list.ShowDialog();
        }

        private void frmbordeshode_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tbl_Customer.ToList();
        }
    }
}

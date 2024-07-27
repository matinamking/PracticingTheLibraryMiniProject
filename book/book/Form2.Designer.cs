
namespace book
{
    partial class frmlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahvil_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.txtnamebook = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtserchid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.AllowUserToDeleteRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.idbook,
            this.idcustomer,
            this.tahvil_date,
            this.name_customer,
            this.family_customer,
            this.name_book});
            this.grdlist.Location = new System.Drawing.Point(12, 81);
            this.grdlist.Name = "grdlist";
            this.grdlist.ReadOnly = true;
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(1142, 289);
            this.grdlist.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // idbook
            // 
            this.idbook.DataPropertyName = "idbook";
            this.idbook.HeaderText = "ایدی کتاب";
            this.idbook.MinimumWidth = 6;
            this.idbook.Name = "idbook";
            this.idbook.ReadOnly = true;
            this.idbook.Width = 80;
            // 
            // idcustomer
            // 
            this.idcustomer.DataPropertyName = "idcustomer";
            this.idcustomer.HeaderText = "کد ملی";
            this.idcustomer.MinimumWidth = 6;
            this.idcustomer.Name = "idcustomer";
            this.idcustomer.ReadOnly = true;
            this.idcustomer.Width = 80;
            // 
            // tahvil_date
            // 
            this.tahvil_date.DataPropertyName = "tahvil_date";
            this.tahvil_date.HeaderText = "تاریخ تحویل کتاب";
            this.tahvil_date.MinimumWidth = 6;
            this.tahvil_date.Name = "tahvil_date";
            this.tahvil_date.ReadOnly = true;
            this.tahvil_date.Width = 125;
            // 
            // name_customer
            // 
            this.name_customer.DataPropertyName = "name_customer";
            this.name_customer.HeaderText = "نام مشتری";
            this.name_customer.MinimumWidth = 6;
            this.name_customer.Name = "name_customer";
            this.name_customer.ReadOnly = true;
            this.name_customer.Width = 125;
            // 
            // family_customer
            // 
            this.family_customer.DataPropertyName = "family_customer";
            this.family_customer.HeaderText = "نام خانوادگی";
            this.family_customer.MinimumWidth = 6;
            this.family_customer.Name = "family_customer";
            this.family_customer.ReadOnly = true;
            this.family_customer.Width = 125;
            // 
            // name_book
            // 
            this.name_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_book.DataPropertyName = "name_book";
            this.name_book.HeaderText = "اسم کتاب";
            this.name_book.MinimumWidth = 6;
            this.name_book.Name = "name_book";
            this.name_book.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "جستجو اسم مشتری";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "جستجو شماره کتاب";
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Location = new System.Drawing.Point(785, 48);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.Size = new System.Drawing.Size(254, 22);
            this.txtnamecustomer.TabIndex = 15;
            this.txtnamecustomer.Tag = "";
            this.txtnamecustomer.TextChanged += new System.EventHandler(this.txtnamecustomer_TextChanged);
            // 
            // txtnamebook
            // 
            this.txtnamebook.Location = new System.Drawing.Point(471, 48);
            this.txtnamebook.Name = "txtnamebook";
            this.txtnamebook.Size = new System.Drawing.Size(254, 22);
            this.txtnamebook.TabIndex = 14;
            this.txtnamebook.Tag = "";
            this.txtnamebook.TextChanged += new System.EventHandler(this.txtnamebook_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(608, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 17);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "جستجو اسم کتاب";
            // 
            // txtserchid
            // 
            this.txtserchid.Location = new System.Drawing.Point(156, 48);
            this.txtserchid.Name = "txtserchid";
            this.txtserchid.Size = new System.Drawing.Size(254, 22);
            this.txtserchid.TabIndex = 12;
            this.txtserchid.Tag = "";
            this.txtserchid.TextChanged += new System.EventHandler(this.txtserchid_TextChanged);
            // 
            // frmlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnamecustomer);
            this.Controls.Add(this.txtnamebook);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtserchid);
            this.Controls.Add(this.grdlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlist";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کتاب ها";
            this.Load += new System.EventHandler(this.frmlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahvil_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn family_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamecustomer;
        private System.Windows.Forms.TextBox txtnamebook;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtserchid;
    }
}
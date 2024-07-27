
namespace book
{
    partial class frmcustumer
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozviat_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idmely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerik_fhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsabt = new System.Windows.Forms.Button();
            this.txtserchfa = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtserchname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.family,
            this.birth_data,
            this.ozviat_date,
            this.Idmely,
            this.numerik_fhone});
            this.grdlist.Location = new System.Drawing.Point(12, 111);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(1144, 289);
            this.grdlist.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.Frozen = true;
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 90;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.Frozen = true;
            this.family.HeaderText = "نام خانوادگی";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.Width = 125;
            // 
            // birth_data
            // 
            this.birth_data.DataPropertyName = "birth_data";
            this.birth_data.Frozen = true;
            this.birth_data.HeaderText = "تاریخ تولد";
            this.birth_data.MinimumWidth = 6;
            this.birth_data.Name = "birth_data";
            this.birth_data.Width = 125;
            // 
            // ozviat_date
            // 
            this.ozviat_date.DataPropertyName = "ozviat_date";
            this.ozviat_date.Frozen = true;
            this.ozviat_date.HeaderText = "تاریخ عضویت";
            this.ozviat_date.MinimumWidth = 6;
            this.ozviat_date.Name = "ozviat_date";
            this.ozviat_date.Width = 125;
            // 
            // Idmely
            // 
            this.Idmely.DataPropertyName = "Idmely";
            this.Idmely.Frozen = true;
            this.Idmely.HeaderText = "کد ملی";
            this.Idmely.MinimumWidth = 6;
            this.Idmely.Name = "Idmely";
            this.Idmely.Width = 125;
            // 
            // numerik_fhone
            // 
            this.numerik_fhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerik_fhone.DataPropertyName = "numerik_fhone";
            this.numerik_fhone.HeaderText = "شماره تلفن";
            this.numerik_fhone.MinimumWidth = 6;
            this.numerik_fhone.Name = "numerik_fhone";
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(12, 12);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(1140, 36);
            this.btnsabt.TabIndex = 1;
            this.btnsabt.Text = "ثبت نام";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // txtserchfa
            // 
            this.txtserchfa.Location = new System.Drawing.Point(113, 84);
            this.txtserchfa.Name = "txtserchfa";
            this.txtserchfa.Size = new System.Drawing.Size(440, 22);
            this.txtserchfa.TabIndex = 2;
            this.txtserchfa.Tag = "";
            this.txtserchfa.TextChanged += new System.EventHandler(this.txtserchfa_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(560, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 17);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "جستجو";
            // 
            // txtserchname
            // 
            this.txtserchname.Location = new System.Drawing.Point(610, 84);
            this.txtserchname.Name = "txtserchname";
            this.txtserchname.Size = new System.Drawing.Size(440, 22);
            this.txtserchname.TabIndex = 4;
            this.txtserchname.Tag = "";
            this.txtserchname.TextChanged += new System.EventHandler(this.txtserchname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1026, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام خانوادگی";
            // 
            // frmcustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtserchname);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtserchfa);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.grdlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcustumer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.frmcustumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.TextBox txtserchfa;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozviat_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idmely;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerik_fhone;
        private System.Windows.Forms.TextBox txtserchname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
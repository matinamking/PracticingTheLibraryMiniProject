
namespace book
{
    partial class frmbordeshode
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
            this.btnsabt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozviat_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idmely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerik_fhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(13, 11);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(556, 36);
            this.btnsabt.TabIndex = 5;
            this.btnsabt.Text = "ثبت کتاب های برده شده";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "مشاهده لیست کتاب های برده شده";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.AllowUserToDeleteRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.family,
            this.birth_data,
            this.ozviat_date,
            this.Idmely,
            this.numerik_fhone});
            this.grdlist.Location = new System.Drawing.Point(12, 54);
            this.grdlist.Name = "grdlist";
            this.grdlist.ReadOnly = true;
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdlist.Size = new System.Drawing.Size(1144, 289);
            this.grdlist.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.Frozen = true;
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 90;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.Frozen = true;
            this.family.HeaderText = "نام خانوادگی";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Width = 125;
            // 
            // birth_data
            // 
            this.birth_data.DataPropertyName = "birth_data";
            this.birth_data.Frozen = true;
            this.birth_data.HeaderText = "تاریخ تولد";
            this.birth_data.MinimumWidth = 6;
            this.birth_data.Name = "birth_data";
            this.birth_data.ReadOnly = true;
            this.birth_data.Width = 125;
            // 
            // ozviat_date
            // 
            this.ozviat_date.DataPropertyName = "ozviat_date";
            this.ozviat_date.Frozen = true;
            this.ozviat_date.HeaderText = "تاریخ عضویت";
            this.ozviat_date.MinimumWidth = 6;
            this.ozviat_date.Name = "ozviat_date";
            this.ozviat_date.ReadOnly = true;
            this.ozviat_date.Width = 125;
            // 
            // Idmely
            // 
            this.Idmely.DataPropertyName = "Idmely";
            this.Idmely.Frozen = true;
            this.Idmely.HeaderText = "کد ملی";
            this.Idmely.MinimumWidth = 6;
            this.Idmely.Name = "Idmely";
            this.Idmely.ReadOnly = true;
            this.Idmely.Width = 125;
            // 
            // numerik_fhone
            // 
            this.numerik_fhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerik_fhone.DataPropertyName = "numerik_fhone";
            this.numerik_fhone.HeaderText = "شماره تلفن";
            this.numerik_fhone.MinimumWidth = 6;
            this.numerik_fhone.Name = "numerik_fhone";
            this.numerik_fhone.ReadOnly = true;
            // 
            // frmbordeshode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 361);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsabt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbordeshode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتاب های برده شده";
            this.Load += new System.EventHandler(this.frmbordeshode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozviat_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idmely;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerik_fhone;
    }
}
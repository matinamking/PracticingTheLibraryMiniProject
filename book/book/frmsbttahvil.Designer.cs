
namespace book
{
    partial class frmsbttahvil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidbook = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.txtfamilycustomer = new System.Windows.Forms.TextBox();
            this.txtnamebook = new System.Windows.Forms.TextBox();
            this.numsallb = new System.Windows.Forms.NumericUpDown();
            this.nummahb = new System.Windows.Forms.NumericUpDown();
            this.numdayb = new System.Windows.Forms.NumericUpDown();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numsallb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdayb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره کتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاریخ تحویل";
            // 
            // txtidbook
            // 
            this.txtidbook.Location = new System.Drawing.Point(24, 16);
            this.txtidbook.Name = "txtidbook";
            this.txtidbook.Size = new System.Drawing.Size(239, 22);
            this.txtidbook.TabIndex = 3;
            this.txtidbook.TextChanged += new System.EventHandler(this.txtidbook_TextChanged);
            this.txtidbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidbook_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم مشتری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "فامیل مشتری";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "اسم کتاب";
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Location = new System.Drawing.Point(24, 134);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.Size = new System.Drawing.Size(239, 22);
            this.txtnamecustomer.TabIndex = 10;
            // 
            // txtfamilycustomer
            // 
            this.txtfamilycustomer.Location = new System.Drawing.Point(23, 172);
            this.txtfamilycustomer.Name = "txtfamilycustomer";
            this.txtfamilycustomer.Size = new System.Drawing.Size(239, 22);
            this.txtfamilycustomer.TabIndex = 11;
            // 
            // txtnamebook
            // 
            this.txtnamebook.Location = new System.Drawing.Point(23, 213);
            this.txtnamebook.Name = "txtnamebook";
            this.txtnamebook.Size = new System.Drawing.Size(239, 22);
            this.txtnamebook.TabIndex = 12;
            // 
            // numsallb
            // 
            this.numsallb.Location = new System.Drawing.Point(24, 96);
            this.numsallb.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numsallb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsallb.Name = "numsallb";
            this.numsallb.Size = new System.Drawing.Size(85, 22);
            this.numsallb.TabIndex = 21;
            this.numsallb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nummahb
            // 
            this.nummahb.Location = new System.Drawing.Point(115, 96);
            this.nummahb.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nummahb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nummahb.Name = "nummahb";
            this.nummahb.Size = new System.Drawing.Size(74, 22);
            this.nummahb.TabIndex = 20;
            this.nummahb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numdayb
            // 
            this.numdayb.Location = new System.Drawing.Point(195, 96);
            this.numdayb.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numdayb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdayb.Name = "numdayb";
            this.numdayb.Size = new System.Drawing.Size(67, 22);
            this.numdayb.TabIndex = 19;
            this.numdayb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.AllowUserToDeleteRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name_book,
            this.idbook});
            this.grdlist.Location = new System.Drawing.Point(389, 12);
            this.grdlist.Name = "grdlist";
            this.grdlist.ReadOnly = true;
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdlist.Size = new System.Drawing.Size(439, 289);
            this.grdlist.TabIndex = 22;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // name_book
            // 
            this.name_book.DataPropertyName = "name_book";
            this.name_book.HeaderText = "اسم کتاب";
            this.name_book.MinimumWidth = 6;
            this.name_book.Name = "name_book";
            this.name_book.ReadOnly = true;
            this.name_book.Width = 125;
            // 
            // idbook
            // 
            this.idbook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idbook.DataPropertyName = "idbook";
            this.idbook.HeaderText = "ایدی کتاب";
            this.idbook.MinimumWidth = 6;
            this.idbook.Name = "idbook";
            this.idbook.ReadOnly = true;
            // 
            // frmsbttahvil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 315);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.numsallb);
            this.Controls.Add(this.nummahb);
            this.Controls.Add(this.numdayb);
            this.Controls.Add(this.txtnamebook);
            this.Controls.Add(this.txtfamilycustomer);
            this.Controls.Add(this.txtnamecustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtidbook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmsbttahvil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsbttahvil";
            this.Load += new System.EventHandler(this.frmsbttahvil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numsallb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdayb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidbook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnamebook;
        public System.Windows.Forms.TextBox txtnamecustomer;
        public System.Windows.Forms.TextBox txtfamilycustomer;
        private System.Windows.Forms.NumericUpDown numsallb;
        private System.Windows.Forms.NumericUpDown nummahb;
        private System.Windows.Forms.NumericUpDown numdayb;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbook;
    }
}
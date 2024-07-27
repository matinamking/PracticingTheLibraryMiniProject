
namespace book
{
    partial class frmbook
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.btnsabt = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name_book,
            this.idbook});
            this.grdlist.Location = new System.Drawing.Point(13, 110);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(439, 289);
            this.grdlist.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(337, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 17);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "جستجو اسم کتاب";
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(12, 71);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(440, 22);
            this.txtserch.TabIndex = 5;
            this.txtserch.Tag = "";
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(13, 12);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(439, 36);
            this.btnsabt.TabIndex = 4;
            this.btnsabt.Text = "ثبت کتاب";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // name_book
            // 
            this.name_book.DataPropertyName = "name_book";
            this.name_book.HeaderText = "اسم کتاب";
            this.name_book.MinimumWidth = 6;
            this.name_book.Name = "name_book";
            // 
            // idbook
            // 
            this.idbook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idbook.DataPropertyName = "idbook";
            this.idbook.HeaderText = "ایدی کتاب";
            this.idbook.MinimumWidth = 6;
            this.idbook.Name = "idbook";
            // 
            // frmbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 408);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.grdlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتاب";
            this.Load += new System.EventHandler(this.frmbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbook;
    }
}
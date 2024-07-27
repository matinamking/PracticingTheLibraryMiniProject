
namespace book
{
    partial class frm1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntahvil = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntahvil);
            this.groupBox1.Controls.Add(this.btnbook);
            this.groupBox1.Controls.Add(this.btncustomer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کتابخانه";
            // 
            // btntahvil
            // 
            this.btntahvil.BackColor = System.Drawing.Color.Silver;
            this.btntahvil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btntahvil.Location = new System.Drawing.Point(260, 23);
            this.btntahvil.Name = "btntahvil";
            this.btntahvil.Size = new System.Drawing.Size(92, 79);
            this.btntahvil.TabIndex = 2;
            this.btntahvil.Text = "کتاب های برده شده";
            this.btntahvil.UseVisualStyleBackColor = false;
            this.btntahvil.Click += new System.EventHandler(this.btntahvil_Click);
            // 
            // btnbook
            // 
            this.btnbook.ForeColor = System.Drawing.Color.Silver;
            this.btnbook.Location = new System.Drawing.Point(135, 24);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(92, 79);
            this.btnbook.TabIndex = 1;
            this.btnbook.Text = "کتاب";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.Silver;
            this.btncustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncustomer.Location = new System.Drawing.Point(6, 23);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(92, 79);
            this.btncustomer.TabIndex = 0;
            this.btncustomer.Text = "مشتری";
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SeaShell;
            this.btnexit.Location = new System.Drawing.Point(18, 127);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(357, 31);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 165);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتاب";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntahvil;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnexit;
    }
}


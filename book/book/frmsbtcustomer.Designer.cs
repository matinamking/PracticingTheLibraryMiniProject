
namespace book
{
    partial class frmsbtcustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtmely = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numdayoz = new System.Windows.Forms.NumericUpDown();
            this.nummahoz = new System.Windows.Forms.NumericUpDown();
            this.numsalloz = new System.Windows.Forms.NumericUpDown();
            this.numsallb = new System.Windows.Forms.NumericUpDown();
            this.nummahb = new System.Windows.Forms.NumericUpDown();
            this.numdayb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numdayoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsalloz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsallb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdayb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاریخ تولد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاریخ عضویت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "کد ملی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره تلفن";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(13, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(261, 22);
            this.txtname.TabIndex = 6;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(13, 44);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(261, 22);
            this.txtfamily.TabIndex = 7;
            // 
            // txtmely
            // 
            this.txtmely.Location = new System.Drawing.Point(13, 155);
            this.txtmely.Name = "txtmely";
            this.txtmely.Size = new System.Drawing.Size(261, 22);
            this.txtmely.TabIndex = 10;
            this.txtmely.TextChanged += new System.EventHandler(this.txtmely_TextChanged);
            this.txtmely.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmely_KeyPress);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(13, 194);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(261, 22);
            this.txtnumber.TabIndex = 11;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numdayoz
            // 
            this.numdayoz.Location = new System.Drawing.Point(201, 122);
            this.numdayoz.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numdayoz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdayoz.Name = "numdayoz";
            this.numdayoz.Size = new System.Drawing.Size(73, 22);
            this.numdayoz.TabIndex = 13;
            this.numdayoz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nummahoz
            // 
            this.nummahoz.Location = new System.Drawing.Point(121, 122);
            this.nummahoz.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nummahoz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nummahoz.Name = "nummahoz";
            this.nummahoz.Size = new System.Drawing.Size(74, 22);
            this.nummahoz.TabIndex = 14;
            this.nummahoz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numsalloz
            // 
            this.numsalloz.Location = new System.Drawing.Point(13, 122);
            this.numsalloz.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numsalloz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsalloz.Name = "numsalloz";
            this.numsalloz.Size = new System.Drawing.Size(102, 22);
            this.numsalloz.TabIndex = 15;
            this.numsalloz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numsallb
            // 
            this.numsallb.Location = new System.Drawing.Point(13, 84);
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
            this.numsallb.Size = new System.Drawing.Size(102, 22);
            this.numsallb.TabIndex = 18;
            this.numsallb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nummahb
            // 
            this.nummahb.Location = new System.Drawing.Point(121, 84);
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
            this.nummahb.TabIndex = 17;
            this.nummahb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numdayb
            // 
            this.numdayb.Location = new System.Drawing.Point(201, 84);
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
            this.numdayb.Size = new System.Drawing.Size(73, 22);
            this.numdayb.TabIndex = 16;
            this.numdayb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmsbtcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 269);
            this.Controls.Add(this.numsallb);
            this.Controls.Add(this.nummahb);
            this.Controls.Add(this.numdayb);
            this.Controls.Add(this.numsalloz);
            this.Controls.Add(this.nummahoz);
            this.Controls.Add(this.numdayoz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtmely);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtcustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام مشتری";
            this.Load += new System.EventHandler(this.frmsbtcustomer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numdayoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsalloz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsallb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummahb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdayb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtmely;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numdayoz;
        private System.Windows.Forms.NumericUpDown nummahoz;
        private System.Windows.Forms.NumericUpDown numsalloz;
        private System.Windows.Forms.NumericUpDown numsallb;
        private System.Windows.Forms.NumericUpDown nummahb;
        private System.Windows.Forms.NumericUpDown numdayb;
    }
}
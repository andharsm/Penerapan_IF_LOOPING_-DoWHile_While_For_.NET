namespace Praktikum_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPembayaran = new System.Windows.Forms.ComboBox();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbTidak = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.btHasil = new System.Windows.Forms.Button();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btDowhile = new System.Windows.Forms.Button();
            this.btWhile = new System.Windows.Forms.Button();
            this.btFor = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member";
            // 
            // cbPembayaran
            // 
            this.cbPembayaran.FormattingEnabled = true;
            this.cbPembayaran.Items.AddRange(new object[] {
            "Tunai",
            "Kredit"});
            this.cbPembayaran.Location = new System.Drawing.Point(150, 36);
            this.cbPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPembayaran.Name = "cbPembayaran";
            this.cbPembayaran.Size = new System.Drawing.Size(133, 23);
            this.cbPembayaran.TabIndex = 2;
            this.cbPembayaran.Text = "Pilih Pembayaran";
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(150, 74);
            this.rbYa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(37, 19);
            this.rbYa.TabIndex = 3;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "Ya";
            this.rbYa.UseVisualStyleBackColor = true;
            // 
            // rbTidak
            // 
            this.rbTidak.AutoSize = true;
            this.rbTidak.Location = new System.Drawing.Point(213, 74);
            this.rbTidak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTidak.Name = "rbTidak";
            this.rbTidak.Size = new System.Drawing.Size(53, 19);
            this.rbTidak.TabIndex = 4;
            this.rbTidak.TabStop = true;
            this.rbTidak.Text = "Tidak";
            this.rbTidak.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah Barang";
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(150, 107);
            this.txtBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(133, 23);
            this.txtBarang.TabIndex = 6;
            this.txtBarang.TextChanged += new System.EventHandler(this.txtBarang_TextChanged);
            // 
            // btHasil
            // 
            this.btHasil.Location = new System.Drawing.Point(150, 147);
            this.btHasil.Name = "btHasil";
            this.btHasil.Size = new System.Drawing.Size(133, 23);
            this.btHasil.TabIndex = 7;
            this.btHasil.Text = "Hasil";
            this.btHasil.UseVisualStyleBackColor = true;
            this.btHasil.Click += new System.EventHandler(this.btHasil_Click);
            // 
            // txtDiskon
            // 
            this.txtDiskon.Location = new System.Drawing.Point(150, 187);
            this.txtDiskon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(133, 23);
            this.txtDiskon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diskon";
            // 
            // btDowhile
            // 
            this.btDowhile.Location = new System.Drawing.Point(46, 249);
            this.btDowhile.Name = "btDowhile";
            this.btDowhile.Size = new System.Drawing.Size(75, 23);
            this.btDowhile.TabIndex = 10;
            this.btDowhile.Text = "Do While";
            this.btDowhile.UseVisualStyleBackColor = true;
            this.btDowhile.Click += new System.EventHandler(this.btDowhile_Click);
            // 
            // btWhile
            // 
            this.btWhile.Location = new System.Drawing.Point(132, 249);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(75, 23);
            this.btWhile.TabIndex = 11;
            this.btWhile.Text = "While";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btFor
            // 
            this.btFor.Location = new System.Drawing.Point(213, 249);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(75, 23);
            this.btFor.TabIndex = 12;
            this.btFor.Text = "For";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(46, 295);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 94);
            this.listBox.TabIndex = 13;
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(213, 295);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 14;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 401);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btFor);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.btDowhile);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btHasil);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbTidak);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.cbPembayaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbPembayaran;
        private RadioButton rbYa;
        private RadioButton rbTidak;
        private Label label3;
        private TextBox txtBarang;
        private Button btHasil;
        private TextBox txtDiskon;
        private Label label4;
        private Button btDowhile;
        private Button btWhile;
        private Button btFor;
        private ListBox listBox;
        private Button btHapus;
    }
}
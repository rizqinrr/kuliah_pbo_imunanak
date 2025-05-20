namespace imun_anak_pbo.view
{
    partial class bidan_frm2
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
            this.tutup_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cariBidan_txt = new System.Windows.Forms.TextBox();
            this.cariBidan_lbl = new System.Windows.Forms.Label();
            this.batal_btn = new System.Windows.Forms.Button();
            this.dataBidan_dgv = new System.Windows.Forms.DataGridView();
            this.editBidan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.namaBidan_txt = new System.Windows.Forms.TextBox();
            this.noTelepon_txt = new System.Windows.Forms.TextBox();
            this.noTelepon_lbl = new System.Windows.Forms.Label();
            this.namaBidan_lbl = new System.Windows.Forms.Label();
            this.kodeBidan_txt = new System.Windows.Forms.TextBox();
            this.kodeBidan_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kode_bidan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_bidan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBidan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(513, 191);
            this.tutup_btn.Margin = new System.Windows.Forms.Padding(2);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(80, 29);
            this.tutup_btn.TabIndex = 34;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cariBidan_txt);
            this.groupBox1.Controls.Add(this.cariBidan_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(123, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(563, 81);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian";
            // 
            // cariBidan_txt
            // 
            this.cariBidan_txt.Location = new System.Drawing.Point(9, 49);
            this.cariBidan_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cariBidan_txt.Name = "cariBidan_txt";
            this.cariBidan_txt.Size = new System.Drawing.Size(546, 27);
            this.cariBidan_txt.TabIndex = 1;
            // 
            // cariBidan_lbl
            // 
            this.cariBidan_lbl.AutoSize = true;
            this.cariBidan_lbl.Location = new System.Drawing.Point(5, 25);
            this.cariBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cariBidan_lbl.Name = "cariBidan_lbl";
            this.cariBidan_lbl.Size = new System.Drawing.Size(118, 19);
            this.cariBidan_lbl.TabIndex = 0;
            this.cariBidan_lbl.Text = "Cari Nama Bidan";
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(421, 191);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(80, 29);
            this.batal_btn.TabIndex = 30;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            // 
            // dataBidan_dgv
            // 
            this.dataBidan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBidan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_bidan,
            this.nama_bidan,
            this.no_telepon});
            this.dataBidan_dgv.Location = new System.Drawing.Point(131, 234);
            this.dataBidan_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dataBidan_dgv.Name = "dataBidan_dgv";
            this.dataBidan_dgv.RowHeadersWidth = 62;
            this.dataBidan_dgv.RowTemplate.Height = 28;
            this.dataBidan_dgv.Size = new System.Drawing.Size(526, 113);
            this.dataBidan_dgv.TabIndex = 29;
            // 
            // editBidan_btn
            // 
            this.editBidan_btn.Location = new System.Drawing.Point(222, 191);
            this.editBidan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.editBidan_btn.Name = "editBidan_btn";
            this.editBidan_btn.Size = new System.Drawing.Size(80, 29);
            this.editBidan_btn.TabIndex = 28;
            this.editBidan_btn.Text = "EDIT";
            this.editBidan_btn.UseVisualStyleBackColor = true;
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(322, 191);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(80, 29);
            this.hapus_btn.TabIndex = 27;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(131, 191);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(80, 29);
            this.simpan_btn.TabIndex = 26;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // namaBidan_txt
            // 
            this.namaBidan_txt.Location = new System.Drawing.Point(215, 120);
            this.namaBidan_txt.Margin = new System.Windows.Forms.Padding(2);
            this.namaBidan_txt.Name = "namaBidan_txt";
            this.namaBidan_txt.Size = new System.Drawing.Size(181, 20);
            this.namaBidan_txt.TabIndex = 25;
            // 
            // noTelepon_txt
            // 
            this.noTelepon_txt.Location = new System.Drawing.Point(215, 154);
            this.noTelepon_txt.Margin = new System.Windows.Forms.Padding(2);
            this.noTelepon_txt.Name = "noTelepon_txt";
            this.noTelepon_txt.Size = new System.Drawing.Size(181, 20);
            this.noTelepon_txt.TabIndex = 24;
            // 
            // noTelepon_lbl
            // 
            this.noTelepon_lbl.AutoSize = true;
            this.noTelepon_lbl.Location = new System.Drawing.Point(128, 156);
            this.noTelepon_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noTelepon_lbl.Name = "noTelepon_lbl";
            this.noTelepon_lbl.Size = new System.Drawing.Size(69, 13);
            this.noTelepon_lbl.TabIndex = 23;
            this.noTelepon_lbl.Text = "No Telepon :";
            // 
            // namaBidan_lbl
            // 
            this.namaBidan_lbl.AutoSize = true;
            this.namaBidan_lbl.Location = new System.Drawing.Point(120, 122);
            this.namaBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namaBidan_lbl.Name = "namaBidan_lbl";
            this.namaBidan_lbl.Size = new System.Drawing.Size(71, 13);
            this.namaBidan_lbl.TabIndex = 22;
            this.namaBidan_lbl.Text = "Nama Bidan :";
            // 
            // kodeBidan_txt
            // 
            this.kodeBidan_txt.Location = new System.Drawing.Point(215, 85);
            this.kodeBidan_txt.Margin = new System.Windows.Forms.Padding(2);
            this.kodeBidan_txt.Name = "kodeBidan_txt";
            this.kodeBidan_txt.Size = new System.Drawing.Size(181, 20);
            this.kodeBidan_txt.TabIndex = 21;
            // 
            // kodeBidan_lbl
            // 
            this.kodeBidan_lbl.AutoSize = true;
            this.kodeBidan_lbl.Location = new System.Drawing.Point(120, 87);
            this.kodeBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kodeBidan_lbl.Name = "kodeBidan_lbl";
            this.kodeBidan_lbl.Size = new System.Drawing.Size(71, 13);
            this.kodeBidan_lbl.TabIndex = 20;
            this.kodeBidan_lbl.Text = "Kode Bidan  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data Petugas";
            // 
            // kode_bidan
            // 
            this.kode_bidan.DataPropertyName = "kode_bidan";
            this.kode_bidan.HeaderText = "Kode Bidan";
            this.kode_bidan.MinimumWidth = 8;
            this.kode_bidan.Name = "kode_bidan";
            this.kode_bidan.Width = 120;
            // 
            // nama_bidan
            // 
            this.nama_bidan.DataPropertyName = "nama_bidan";
            this.nama_bidan.HeaderText = "Nama Bidan";
            this.nama_bidan.MinimumWidth = 8;
            this.nama_bidan.Name = "nama_bidan";
            this.nama_bidan.Width = 150;
            // 
            // no_telepon
            // 
            this.no_telepon.DataPropertyName = "no_telepon";
            this.no_telepon.HeaderText = "No Telepon";
            this.no_telepon.MinimumWidth = 8;
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Width = 200;
            // 
            // bidan_frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.dataBidan_dgv);
            this.Controls.Add(this.editBidan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.namaBidan_txt);
            this.Controls.Add(this.noTelepon_txt);
            this.Controls.Add(this.noTelepon_lbl);
            this.Controls.Add(this.namaBidan_lbl);
            this.Controls.Add(this.kodeBidan_txt);
            this.Controls.Add(this.kodeBidan_lbl);
            this.Controls.Add(this.label1);
            this.Name = "bidan_frm2";
            this.Text = "bidan_frm2";
            this.Load += new System.EventHandler(this.bidan_frm2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBidan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cariBidan_txt;
        private System.Windows.Forms.Label cariBidan_lbl;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView dataBidan_dgv;
        private System.Windows.Forms.Button editBidan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox namaBidan_txt;
        private System.Windows.Forms.TextBox noTelepon_txt;
        private System.Windows.Forms.Label noTelepon_lbl;
        private System.Windows.Forms.Label namaBidan_lbl;
        private System.Windows.Forms.TextBox kodeBidan_txt;
        private System.Windows.Forms.Label kodeBidan_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_bidan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_bidan;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_telepon;
    }
}
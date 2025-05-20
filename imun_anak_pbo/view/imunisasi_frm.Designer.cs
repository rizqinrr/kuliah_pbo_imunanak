namespace imun_anak_pbo.view
{
    partial class imunisasi_frm
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
            this.cariImun_txt = new System.Windows.Forms.TextBox();
            this.cariBidan_lbl = new System.Windows.Forms.Label();
            this.batal_btn = new System.Windows.Forms.Button();
            this.dataImun_dgv = new System.Windows.Forms.DataGridView();
            this.edit_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.imunDes_txt = new System.Windows.Forms.TextBox();
            this.rentangUsia_txt = new System.Windows.Forms.TextBox();
            this.noTelepon_lbl = new System.Windows.Forms.Label();
            this.namaBidan_lbl = new System.Windows.Forms.Label();
            this.imun_txt = new System.Windows.Forms.TextBox();
            this.kodeBidan_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_imun_lbl = new System.Windows.Forms.Label();
            this.nama_imunisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imunisasi_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usia_anak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataImun_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(513, 191);
            this.tutup_btn.Margin = new System.Windows.Forms.Padding(2);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(80, 29);
            this.tutup_btn.TabIndex = 48;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cariImun_txt);
            this.groupBox1.Controls.Add(this.cariBidan_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(123, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(563, 81);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian";
            // 
            // cariImun_txt
            // 
            this.cariImun_txt.Location = new System.Drawing.Point(9, 49);
            this.cariImun_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cariImun_txt.Name = "cariImun_txt";
            this.cariImun_txt.Size = new System.Drawing.Size(546, 27);
            this.cariImun_txt.TabIndex = 1;
            this.cariImun_txt.TextChanged += new System.EventHandler(this.cariImun_txt_TextChanged);
            // 
            // cariBidan_lbl
            // 
            this.cariBidan_lbl.AutoSize = true;
            this.cariBidan_lbl.Location = new System.Drawing.Point(5, 25);
            this.cariBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cariBidan_lbl.Name = "cariBidan_lbl";
            this.cariBidan_lbl.Size = new System.Drawing.Size(101, 19);
            this.cariBidan_lbl.TabIndex = 0;
            this.cariBidan_lbl.Text = "Cari Imunisasi";
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(421, 191);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(80, 29);
            this.batal_btn.TabIndex = 46;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // dataImun_dgv
            // 
            this.dataImun_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataImun_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_imunisasi,
            this.imunisasi_id,
            this.deskripsi,
            this.usia_anak});
            this.dataImun_dgv.Location = new System.Drawing.Point(131, 234);
            this.dataImun_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dataImun_dgv.Name = "dataImun_dgv";
            this.dataImun_dgv.RowHeadersWidth = 62;
            this.dataImun_dgv.RowTemplate.Height = 28;
            this.dataImun_dgv.Size = new System.Drawing.Size(526, 113);
            this.dataImun_dgv.TabIndex = 45;
            this.dataImun_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataImun_dgv_CellClick);
            this.dataImun_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataImun_dgv_CellContentClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(222, 191);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(80, 29);
            this.edit_btn.TabIndex = 44;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(322, 191);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(80, 29);
            this.hapus_btn.TabIndex = 43;
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
            this.simpan_btn.TabIndex = 42;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // imunDes_txt
            // 
            this.imunDes_txt.Location = new System.Drawing.Point(215, 113);
            this.imunDes_txt.Margin = new System.Windows.Forms.Padding(2);
            this.imunDes_txt.Name = "imunDes_txt";
            this.imunDes_txt.Size = new System.Drawing.Size(181, 20);
            this.imunDes_txt.TabIndex = 41;
            // 
            // rentangUsia_txt
            // 
            this.rentangUsia_txt.Location = new System.Drawing.Point(215, 150);
            this.rentangUsia_txt.Margin = new System.Windows.Forms.Padding(2);
            this.rentangUsia_txt.Name = "rentangUsia_txt";
            this.rentangUsia_txt.Size = new System.Drawing.Size(181, 20);
            this.rentangUsia_txt.TabIndex = 40;
            // 
            // noTelepon_lbl
            // 
            this.noTelepon_lbl.AutoSize = true;
            this.noTelepon_lbl.Location = new System.Drawing.Point(102, 157);
            this.noTelepon_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noTelepon_lbl.Name = "noTelepon_lbl";
            this.noTelepon_lbl.Size = new System.Drawing.Size(99, 13);
            this.noTelepon_lbl.TabIndex = 39;
            this.noTelepon_lbl.Text = "Rentang Usia anak";
            // 
            // namaBidan_lbl
            // 
            this.namaBidan_lbl.AutoSize = true;
            this.namaBidan_lbl.Location = new System.Drawing.Point(151, 120);
            this.namaBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namaBidan_lbl.Name = "namaBidan_lbl";
            this.namaBidan_lbl.Size = new System.Drawing.Size(50, 13);
            this.namaBidan_lbl.TabIndex = 38;
            this.namaBidan_lbl.Text = "Deskripsi";
            // 
            // imun_txt
            // 
            this.imun_txt.Location = new System.Drawing.Point(215, 81);
            this.imun_txt.Margin = new System.Windows.Forms.Padding(2);
            this.imun_txt.Name = "imun_txt";
            this.imun_txt.Size = new System.Drawing.Size(181, 20);
            this.imun_txt.TabIndex = 37;
            // 
            // kodeBidan_lbl
            // 
            this.kodeBidan_lbl.AutoSize = true;
            this.kodeBidan_lbl.Location = new System.Drawing.Point(120, 88);
            this.kodeBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kodeBidan_lbl.Name = "kodeBidan_lbl";
            this.kodeBidan_lbl.Size = new System.Drawing.Size(81, 13);
            this.kodeBidan_lbl.TabIndex = 36;
            this.kodeBidan_lbl.Text = "Nama Imunisasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Data Imun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID imunisasi";
            // 
            // id_imun_lbl
            // 
            this.id_imun_lbl.AutoSize = true;
            this.id_imun_lbl.Location = new System.Drawing.Point(219, 47);
            this.id_imun_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_imun_lbl.Name = "id_imun_lbl";
            this.id_imun_lbl.Size = new System.Drawing.Size(10, 13);
            this.id_imun_lbl.TabIndex = 50;
            this.id_imun_lbl.Tag = "id_imun_lbl";
            this.id_imun_lbl.Text = "-";
            // 
            // nama_imunisasi
            // 
            this.nama_imunisasi.DataPropertyName = "nama_imunisasi";
            this.nama_imunisasi.HeaderText = "Nama Imunisasi";
            this.nama_imunisasi.MinimumWidth = 8;
            this.nama_imunisasi.Name = "nama_imunisasi";
            this.nama_imunisasi.Width = 120;
            // 
            // imunisasi_id
            // 
            this.imunisasi_id.DataPropertyName = "imunisasi_id";
            this.imunisasi_id.HeaderText = "imunisasi_id";
            this.imunisasi_id.Name = "imunisasi_id";
            // 
            // deskripsi
            // 
            this.deskripsi.DataPropertyName = "deskripsi";
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.MinimumWidth = 8;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 150;
            // 
            // usia_anak
            // 
            this.usia_anak.DataPropertyName = "usia_anak";
            this.usia_anak.HeaderText = "Rentang Usia Anak (Tahun)";
            this.usia_anak.MinimumWidth = 8;
            this.usia_anak.Name = "usia_anak";
            this.usia_anak.Width = 200;
            // 
            // imunisasi_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_imun_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.dataImun_dgv);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.imunDes_txt);
            this.Controls.Add(this.rentangUsia_txt);
            this.Controls.Add(this.noTelepon_lbl);
            this.Controls.Add(this.namaBidan_lbl);
            this.Controls.Add(this.imun_txt);
            this.Controls.Add(this.kodeBidan_lbl);
            this.Controls.Add(this.label1);
            this.Name = "imunisasi_frm";
            this.Text = "imunisasi_frm";
            this.Load += new System.EventHandler(this.imunisasi_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataImun_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cariImun_txt;
        private System.Windows.Forms.Label cariBidan_lbl;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView dataImun_dgv;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox imunDes_txt;
        private System.Windows.Forms.TextBox rentangUsia_txt;
        private System.Windows.Forms.Label noTelepon_lbl;
        private System.Windows.Forms.Label namaBidan_lbl;
        private System.Windows.Forms.TextBox imun_txt;
        private System.Windows.Forms.Label kodeBidan_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_imun_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_imunisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn imunisasi_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn usia_anak;
    }
}
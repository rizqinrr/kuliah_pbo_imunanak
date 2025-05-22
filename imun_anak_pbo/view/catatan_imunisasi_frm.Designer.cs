namespace imun_anak_pbo.view
{
    partial class catatan_imunisasi_frm
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
            this.id_catatan_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cari_tanggal_dtp = new System.Windows.Forms.DateTimePicker();
            this.cari_catatan_lbl = new System.Windows.Forms.Label();
            this.batal_btn = new System.Windows.Forms.Button();
            this.data_catatan_dgv = new System.Windows.Forms.DataGridView();
            this.edit_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.noTelepon_lbl = new System.Windows.Forms.Label();
            this.namaBidan_lbl = new System.Windows.Forms.Label();
            this.kodeBidan_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cari_btn = new System.Windows.Forms.Button();
            this.nama_imun_cmb = new System.Windows.Forms.ComboBox();
            this.nama_bidan_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keterangan_txt = new System.Windows.Forms.TextBox();
            this.nama_anak_txt = new System.Windows.Forms.TextBox();
            this.catatan_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_anak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imunisasi_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidan_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterngan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_imunisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_catatan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_catatan_lbl
            // 
            this.id_catatan_lbl.AutoSize = true;
            this.id_catatan_lbl.Location = new System.Drawing.Point(254, 47);
            this.id_catatan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_catatan_lbl.Name = "id_catatan_lbl";
            this.id_catatan_lbl.Size = new System.Drawing.Size(10, 13);
            this.id_catatan_lbl.TabIndex = 66;
            this.id_catatan_lbl.Tag = "id_catat_lbl";
            this.id_catatan_lbl.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "ID Catatan";
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(768, 410);
            this.tutup_btn.Margin = new System.Windows.Forms.Padding(2);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(80, 29);
            this.tutup_btn.TabIndex = 64;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cari_tanggal_dtp);
            this.groupBox1.Controls.Add(this.cari_catatan_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(256, 81);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian";
            // 
            // cari_tanggal_dtp
            // 
            this.cari_tanggal_dtp.Location = new System.Drawing.Point(5, 49);
            this.cari_tanggal_dtp.Name = "cari_tanggal_dtp";
            this.cari_tanggal_dtp.Size = new System.Drawing.Size(237, 27);
            this.cari_tanggal_dtp.TabIndex = 1;
            // 
            // cari_catatan_lbl
            // 
            this.cari_catatan_lbl.AutoSize = true;
            this.cari_catatan_lbl.Location = new System.Drawing.Point(5, 25);
            this.cari_catatan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cari_catatan_lbl.Name = "cari_catatan_lbl";
            this.cari_catatan_lbl.Size = new System.Drawing.Size(156, 19);
            this.cari_catatan_lbl.TabIndex = 0;
            this.cari_catatan_lbl.Text = "Cari Tanggal Imunisasi";
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(59, 191);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(80, 29);
            this.batal_btn.TabIndex = 62;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // data_catatan_dgv
            // 
            this.data_catatan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_catatan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catatan_id,
            this.nama_anak,
            this.imunisasi_id,
            this.bidan_id,
            this.Keterngan,
            this.tanggal_imunisasi});
            this.data_catatan_dgv.Location = new System.Drawing.Point(11, 326);
            this.data_catatan_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.data_catatan_dgv.Name = "data_catatan_dgv";
            this.data_catatan_dgv.RowHeadersWidth = 62;
            this.data_catatan_dgv.RowTemplate.Height = 28;
            this.data_catatan_dgv.Size = new System.Drawing.Size(748, 113);
            this.data_catatan_dgv.TabIndex = 61;
            this.data_catatan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_catatan_dgv_CellClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(295, 191);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(80, 29);
            this.edit_btn.TabIndex = 60;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(403, 191);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(80, 29);
            this.hapus_btn.TabIndex = 59;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = true;
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(176, 191);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(80, 29);
            this.simpan_btn.TabIndex = 58;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // noTelepon_lbl
            // 
            this.noTelepon_lbl.AutoSize = true;
            this.noTelepon_lbl.Location = new System.Drawing.Point(153, 143);
            this.noTelepon_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noTelepon_lbl.Name = "noTelepon_lbl";
            this.noTelepon_lbl.Size = new System.Drawing.Size(65, 13);
            this.noTelepon_lbl.TabIndex = 55;
            this.noTelepon_lbl.Text = "Nama Bidan";
            // 
            // namaBidan_lbl
            // 
            this.namaBidan_lbl.AutoSize = true;
            this.namaBidan_lbl.Location = new System.Drawing.Point(137, 113);
            this.namaBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namaBidan_lbl.Name = "namaBidan_lbl";
            this.namaBidan_lbl.Size = new System.Drawing.Size(81, 13);
            this.namaBidan_lbl.TabIndex = 54;
            this.namaBidan_lbl.Text = "Nama Imunisasi";
            // 
            // kodeBidan_lbl
            // 
            this.kodeBidan_lbl.AutoSize = true;
            this.kodeBidan_lbl.Location = new System.Drawing.Point(155, 81);
            this.kodeBidan_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kodeBidan_lbl.Name = "kodeBidan_lbl";
            this.kodeBidan_lbl.Size = new System.Drawing.Size(63, 13);
            this.kodeBidan_lbl.TabIndex = 52;
            this.kodeBidan_lbl.Text = "Nama Anak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "CATATAN IMUNISASI";
            // 
            // cari_btn
            // 
            this.cari_btn.Location = new System.Drawing.Point(379, 274);
            this.cari_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(80, 29);
            this.cari_btn.TabIndex = 67;
            this.cari_btn.Text = "CARI";
            this.cari_btn.UseVisualStyleBackColor = true;
            // 
            // nama_imun_cmb
            // 
            this.nama_imun_cmb.FormattingEnabled = true;
            this.nama_imun_cmb.Location = new System.Drawing.Point(250, 110);
            this.nama_imun_cmb.Name = "nama_imun_cmb";
            this.nama_imun_cmb.Size = new System.Drawing.Size(181, 21);
            this.nama_imun_cmb.TabIndex = 68;
            // 
            // nama_bidan_cmb
            // 
            this.nama_bidan_cmb.FormattingEnabled = true;
            this.nama_bidan_cmb.Location = new System.Drawing.Point(250, 143);
            this.nama_bidan_cmb.Name = "nama_bidan_cmb";
            this.nama_bidan_cmb.Size = new System.Drawing.Size(181, 21);
            this.nama_bidan_cmb.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Keterangan";
            // 
            // keterangan_txt
            // 
            this.keterangan_txt.Location = new System.Drawing.Point(493, 93);
            this.keterangan_txt.Margin = new System.Windows.Forms.Padding(2);
            this.keterangan_txt.Multiline = true;
            this.keterangan_txt.Name = "keterangan_txt";
            this.keterangan_txt.Size = new System.Drawing.Size(216, 71);
            this.keterangan_txt.TabIndex = 71;
            // 
            // nama_anak_txt
            // 
            this.nama_anak_txt.Location = new System.Drawing.Point(250, 75);
            this.nama_anak_txt.Name = "nama_anak_txt";
            this.nama_anak_txt.Size = new System.Drawing.Size(181, 20);
            this.nama_anak_txt.TabIndex = 72;
            // 
            // catatan_id
            // 
            this.catatan_id.DataPropertyName = "catatan_id";
            this.catatan_id.HeaderText = "catatan_id";
            this.catatan_id.Name = "catatan_id";
            // 
            // nama_anak
            // 
            this.nama_anak.DataPropertyName = "nama_anak";
            this.nama_anak.HeaderText = "Nama Anak";
            this.nama_anak.MinimumWidth = 8;
            this.nama_anak.Name = "nama_anak";
            this.nama_anak.Width = 120;
            // 
            // imunisasi_id
            // 
            this.imunisasi_id.DataPropertyName = "nama_imunisasi";
            this.imunisasi_id.HeaderText = "Nama Imunisasi";
            this.imunisasi_id.Name = "imunisasi_id";
            // 
            // bidan_id
            // 
            this.bidan_id.DataPropertyName = "nama_bidan";
            this.bidan_id.HeaderText = "Nama Bidan";
            this.bidan_id.MinimumWidth = 8;
            this.bidan_id.Name = "bidan_id";
            this.bidan_id.Width = 150;
            // 
            // Keterngan
            // 
            this.Keterngan.DataPropertyName = "keterangan";
            this.Keterngan.HeaderText = "Keterangan";
            this.Keterngan.Name = "Keterngan";
            this.Keterngan.Width = 200;
            // 
            // tanggal_imunisasi
            // 
            this.tanggal_imunisasi.DataPropertyName = "tanggal_imunisasi";
            this.tanggal_imunisasi.HeaderText = "Tanggal Imunisasi";
            this.tanggal_imunisasi.MinimumWidth = 8;
            this.tanggal_imunisasi.Name = "tanggal_imunisasi";
            // 
            // catatan_imunisasi_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.nama_anak_txt);
            this.Controls.Add(this.keterangan_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nama_bidan_cmb);
            this.Controls.Add(this.nama_imun_cmb);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.id_catatan_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.data_catatan_dgv);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.noTelepon_lbl);
            this.Controls.Add(this.namaBidan_lbl);
            this.Controls.Add(this.kodeBidan_lbl);
            this.Controls.Add(this.label1);
            this.Name = "catatan_imunisasi_frm";
            this.Text = "catatan_imunisasi_frm";
            this.Load += new System.EventHandler(this.catatan_imunisasi_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_catatan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_catatan_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cari_catatan_lbl;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView data_catatan_dgv;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Label noTelepon_lbl;
        private System.Windows.Forms.Label namaBidan_lbl;
        private System.Windows.Forms.Label kodeBidan_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cari_tanggal_dtp;
        private System.Windows.Forms.Button cari_btn;
        private System.Windows.Forms.ComboBox nama_imun_cmb;
        private System.Windows.Forms.ComboBox nama_bidan_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keterangan_txt;
        private System.Windows.Forms.TextBox nama_anak_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn catatan_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_anak;
        private System.Windows.Forms.DataGridViewTextBoxColumn imunisasi_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidan_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterngan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_imunisasi;
    }
}
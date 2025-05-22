using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using imun_anak_pbo.model;

namespace imun_anak_pbo.view
{
    public partial class catatan_imunisasi_frm: Form
    {
        Anak_cls anak = new Anak_cls();
        Bidan_cls bidan = new Bidan_cls();
        Imunisasi_cls imun = new Imunisasi_cls();
        Catatan_imunisasi_cls cat = new Catatan_imunisasi_cls();

        AutoCompleteStringCollection autoNama = new AutoCompleteStringCollection();


        public catatan_imunisasi_frm()
        {
            InitializeComponent();
        }

        

        void isiBidan()
        {
            string namaBidan = "";
            DataTable data = bidan.tampilsemua();

            nama_bidan_cmb.Items.Clear();

            foreach (DataRow bdn in data.Rows)
            {
                namaBidan = bdn["nama_bidan"].ToString();
                nama_bidan_cmb.Items.Add(namaBidan);
            }
        }

        void isiImunisasi()
        {
            string nama_imunisasi = "";
            DataTable data = imun.tampilsemua();

            nama_imun_cmb.Items.Clear(); // <- INI YANG BENAR

            foreach (DataRow imn in data.Rows)
            {
                nama_imunisasi = imn["nama_imunisasi"].ToString(); // atau imn[1]
                nama_imun_cmb.Items.Add(nama_imunisasi);
            }
        }


        private void tutup_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            nama_anak_txt.Clear();
            nama_bidan_cmb.Text = "";
            nama_imun_cmb.Text = "";
            id_catatan_lbl.Text = "-";
            keterangan_txt.Clear();
        }
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!cat.cekID(id_catatan_lbl.Text))
            {

                cat.anak_id = anak.ambilNamaAnak(nama_anak_txt.Text);
                cat.imunisasi_id = imun.ambilNamaImun(nama_imun_cmb.Text);
                cat.bidan_id = bidan.ambilIdBidan(nama_bidan_cmb.Text);
                cat.keterangan = keterangan_txt.Text;


                if (cat.simpanCatatan())
                {
                    MessageBox.Show("Data berhasil disimpan.", "SIMPAN DATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    nama_anak_txt.Focus();
                    tampilSemua();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.", "SIMPAN DATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Data Sudah Tersedia.", "SIMPAN DATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                nama_anak_txt.Focus();
            }
        }




        private void nama_anak_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void tampilSemua()
        {
           
                data_catatan_dgv.DataSource = cat.tampilDataGabungan();

            data_catatan_dgv.Columns["catatan_id"].Visible = false;
        }

        private void catatan_imunisasi_frm_Load(object sender, EventArgs e)
        {
            tampilSemua();
            isiImunisasi();
            isiBidan();
            
            DataTable data = anak.tampilNamaAnak();

            foreach (DataRow row in data.Rows)
            {
                autoNama.Add(row["nama"].ToString());
            }

            nama_anak_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nama_anak_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            nama_anak_txt.AutoCompleteCustomSource = autoNama;
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void data_catatan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.data_catatan_dgv.Rows[e.RowIndex];

                nama_anak_txt.Text = baris.Cells[1].Value.ToString();
                nama_imun_cmb.Text = baris.Cells[2].Value.ToString();
                nama_bidan_cmb.Text = baris.Cells[3].Value.ToString();
                keterangan_txt.Text = baris.Cells[5].Value.ToString();

                // Ambil ID tersembunyi
                string idImunisasi = baris.Cells["catatan_id"].Value.ToString();

                // Masukkan ke Label
                id_catatan_lbl.Text = idImunisasi;
            }
        }
    }
}

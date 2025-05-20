using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using imun_anak_pbo.model;

namespace imun_anak_pbo.view
{
    public partial class imunisasi_frm: Form
    {
        Imunisasi_cls imun = new Imunisasi_cls();
        public imunisasi_frm()
        {
            InitializeComponent();
        }

        private void clear()
        {
            imun_txt.Clear();
            imunDes_txt.Clear();
            rentangUsia_txt.Clear();
            id_imun_lbl.Text = "-";
        }
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            imun.nama_imunisasi = imun_txt.Text; //Memanggil 
            imun.deskripsi = imunDes_txt.Text;
            imun.usia_anak = rentangUsia_txt.Text;

            if (imun.simpanImun() == true)
            {
                MessageBox.Show("Data Berhasil Disimpan.", "SIMPAN DATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                imun_txt.Focus();
                tampilSemua();

            }
        }

        public void tampilSemua()
        {
            if (cariImun_txt.Text.Length == 0)
            {
                dataImun_dgv.DataSource = imun.tampilsemua();
            }
            else
            {
                dataImun_dgv.DataSource = imun.cariImun(cariImun_txt.Text);
            }
            
            dataImun_dgv.Columns["imunisasi_id"].Visible = false;
        }

        private void dataImun_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataImun_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.dataImun_dgv.Rows[e.RowIndex];
                
                imun_txt.Text = baris.Cells[1].Value.ToString();
                imunDes_txt.Text = baris.Cells[2].Value.ToString();
                rentangUsia_txt.Text = baris.Cells[3].Value.ToString();

                // Ambil ID tersembunyi
                string idImunisasi = baris.Cells["imunisasi_id"].Value.ToString();

                // Masukkan ke Label
                id_imun_lbl.Text =  idImunisasi;
            }
        }

        private void imunisasi_frm_Load(object sender, EventArgs e)
        {
            tampilSemua();
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan dihapus?", "HAPUS DATA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (imun.cekID(id_imun_lbl.Text) == true)
                {

                    if (imun.hapusImun(id_imun_lbl.Text) == true)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "HAPUS DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        imun_txt.Focus();
                        tampilSemua();
                    }
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "HAPUS DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    imun_txt.Focus();
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan diubah?", "UBAH DATA",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                imun.nama_imunisasi = imun_txt.Text;
                imun.deskripsi = imunDes_txt.Text;
                imun.usia_anak = rentangUsia_txt.Text;
                if (imun.cekID(id_imun_lbl.Text) == true)
                {

                    if (imun.ubahImun(id_imun_lbl.Text) == true)
                    {
                        MessageBox.Show("Data berhasil diubah.", "UBAH DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        imun_txt.Focus();
                        tampilSemua();
                    }
                }
                else
                {
                    MessageBox.Show("Data gagal diubah.", "UBAH DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    imun_txt.Focus();
                }
            }
        }

        private void cariImun_txt_TextChanged(object sender, EventArgs e)
        {
            tampilSemua();
        }
    }
}

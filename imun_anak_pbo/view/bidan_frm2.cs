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
    public partial class bidan_frm2: Form
    {
        Bidan_cls bidan = new Bidan_cls();
        public bidan_frm2()
        {
            InitializeComponent();
        }

        private void clear()
        {
            kodeBidan_txt.Clear();
            namaBidan_txt.Clear();
            noTelepon_txt.Clear();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            bidan.kode_bidan = kodeBidan_txt.Text; //Memanggil 
            bidan.nama_bidan = namaBidan_txt.Text;
            bidan.no_telepon = noTelepon_txt.Text;

            if (bidan.simpanBidan() == true)
            {
                MessageBox.Show("Data Berhasil Disimpan.", "SIMPAN DATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                kodeBidan_txt.Focus();
                tampilbidan();
            
            }
        }

        private void bidan_frm2_Load(object sender, EventArgs e)
        {
            tampilbidan();
        }

        public void tampilbidan()
        {
            dataBidan_dgv.DataSource = bidan.tampilsemua();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan dihapus?", "HAPUS DATA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bidan.cekKodeBidan(kodeBidan_txt.Text) == true)
                {

                    if (bidan.hapusBidan(kodeBidan_txt.Text) == true)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "HAPUS DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        kodeBidan_txt.Focus();
                        tampilbidan();
                    }
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "HAPUS DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeBidan_txt.Focus();
                }
            }
        }
    }
}

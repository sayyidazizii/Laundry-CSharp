using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laundry_1._0
{
    public partial class FrmPelanggan : Form
    {
        public FrmPelanggan()
        {
            InitializeComponent();
            DisplayData(); //pemanggilan method untuk menampilkan data pada datagridview
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear(); //pemanggilan method untuk hapus isian textbox
            ID();
        }
        //Button Hapus 
        private void button6_Click(object sender, EventArgs e)
        {   //MessageBox Konfirmasi Hapus
            DialogResult dialogResult = MessageBox.Show("Yakin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //Jika konfirmasi yes
            {
                //do something
                var contex = new laundryEntities1(); //koneksi
                string query = "DELETE FROM [dbo].[pelanggan] WHERE id_pel = '" + TxtID.Text + "'";
                contex.Database.ExecuteSqlCommand(query);
                Clear();//pemanggilan method untuk hapus isian textbox
                DisplayData();//pemanggilan method untuk menampilkan data pada datagridview
                MessageBox.Show("Data berhasil dihapus!");//MessageBox Informasi
            }
            else if (dialogResult == DialogResult.No) //Jika konfirmasi NO
            {
                //do something else
            }
            ID();
        }
        //method untuk hapus isian textbox
        public void Clear()
        {
            TxtID.Text = "";
            TxtNama.Text = "";
            TxtTelp.Text = "";
            TxtAlamat.Text = "";
            TxtCari.Text = "";
        }
        //Button Simpan
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1(); //koneksi
            string query = "INSERT INTO [dbo].[pelanggan] VALUES ('" + TxtID.Text + "','" + TxtNama.Text + "', '" + TxtAlamat.Text + "', '" + TxtTelp.Text + "')";
            contex.Database.ExecuteSqlCommand(query);
            string urut = query;
            Clear();//pemanggilan method untuk hapus isian textbox
            DisplayData();//pemanggilan method untuk menampilkan data pada datagridview
            MessageBox.Show("Data Berhasil Ditambahkan!");//MessageBox Informasi
            ID();
        }
        //Method untuk menampilkan data pada datagridview
        private void DisplayData()
        {
            var contex = new laundryEntities1();//koneksi
            laundryEntities1 laundry = new laundryEntities1();//koneksi
            var item = laundry.pelanggans.ToList();//pemanggilan data dari database
            dataGridView1.DataSource = item;//pengisian data ke datagridview
        }
        //Button Ubah
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1();//koneksi
            string query = "UPDATE [dbo].[pelanggan] SET [nama_pel] = '" + TxtNama.Text + "',[alamat] = '" + TxtAlamat.Text + "',[telp] = '" + TxtTelp.Text + "' WHERE id_pel = '"+TxtID.Text+"'";
            contex.Database.ExecuteSqlCommand(query);
            Clear();//panggil method clear
            DisplayData();//panggil method DisplayData
            MessageBox.Show("Data berhasil diperbarui!");
            ID();
        }
        //aksi jika cell datagrid di pilih / diklik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//percabangan, untuk melihat apakah datagridview berisi data atau kosong
            {   //jika kondisi terpenuhi, maka sourcecode dibawah ini akan dieksekusi
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];//select index row datagrid
                TxtID.Text = row.Cells[0].Value.ToString();//memasukkan data dari datagrid ke textbox ID
                TxtNama.Text = row.Cells[1].Value.ToString();//memasukkan data dari datagrid ke textbox nama
                TxtAlamat.Text = row.Cells[2].Value.ToString();//memasukkan data dari datagrid ke textbox alamat
                TxtTelp.Text = row.Cells[3].Value.ToString();//memasukkan data dari datagrid ke textbox telp
            }
        }
        //method untuk pencarian dari datagridview
        private void searchart()
        {
            {
                string searchValue = TxtCari.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                            {
                                int rowIndex = row.Index;
                                dataGridView1.Rows[rowIndex].Selected = true;
                                valueResult = true;
                                break;
                            }
                        }

                    }
                    if (!valueResult)
                    {
                        MessageBox.Show("Keyword " + TxtCari.Text, "tidak ditemukan");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        //form load
        private void FrmPelanggan_Load_1(object sender, EventArgs e)
        {   //mengisi ID dengan datetime now
            ID();
            TxtNama.Focus();
        }
        //Button Cari
        private void BtnCetak_Click(object sender, EventArgs e)
        {
            searchart(); //panggil method searchart
        }
        public void ID()
        {
            TxtID.Text = "Cus-" + DateTime.Now.ToString("ddMMyyyyhmmss");
        }
    }
}

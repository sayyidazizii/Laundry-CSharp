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
    public partial class FrmPaket : Form
    {
        public FrmPaket()
        {
            InitializeComponent();
            DisplayData(); //pemanggilan method untuk menampilkan data pada datagridview
        }

        //Button Simpan
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            //koneksi menggunakan entity framework
            var contex = new laundryEntities1();
            string query = "INSERT INTO [dbo].[paket] VALUES ('" + TxtID.Text + "','" + TxtNamaPaket.Text + "', '" + TxtHarga.Text + "', '" + TxtDurasi.Text + "')";
            contex.Database.ExecuteSqlCommand(query);
            string urut = query;
            Clear(); //pemanggilan method untuk hapus isian textbox
            DisplayData(); //pemanggilan method untuk menampilkan data pada datagridview
            MessageBox.Show("Data Berhasil Ditambahkan!"); //MessageBox Informasi
            ID();
        }

        //===============
        //Method Display Data
        //---------------
        private void DisplayData()
        {
            var contex = new laundryEntities1();
            laundryEntities1 laundry = new laundryEntities1();
            var item = laundry.pakets.SqlQuery("Select id_paket, nama_paket,harga_satuan, durasi from paket").ToList();
            dataGridView1.DataSource = item;
        }

        //===============
        //Method Clear
        //---------------
        public void Clear()
        {
            TxtID.Text = "";
            TxtNamaPaket.Text = "";
            TxtHarga.Text = "";
            TxtDurasi.Text = "";
        }
        //Button memperbarui data paket dalam database
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1();
            string query = "UPDATE [dbo].[paket] SET [nama_paket] = '" + TxtNamaPaket.Text + "',[harga_satuan] = '" + TxtHarga.Text + "',[durasi] = '" + TxtDurasi.Text + "' WHERE id_paket = '" + TxtID.Text + "' ";
            contex.Database.ExecuteSqlCommand(query);
            Clear();//pemanggilan method untuk hapus isian textbox
            DisplayData();//pemanggilan method untuk menampilkan data pada datagridview
            MessageBox.Show("Data berhasil diperbarui!");//MessageBox Informasi
            ID();
        }
        //Button Hapus data
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            //MessageBox Konfirmasi hapus data
            DialogResult dialogResult = MessageBox.Show("Yakin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something / dilakukan konfirmasi jika yes
                var contex = new laundryEntities1(); //inisiasi koneksi
                string query = "DELETE FROM [dbo].[paket] WHERE id_paket = '" + TxtID.Text + "'";
                contex.Database.ExecuteSqlCommand(query);
                Clear();//pemanggilan method untuk hapus isian textbox
                DisplayData();//pemanggilan method untuk menampilkan data pada datagridview
                MessageBox.Show("Data berhasil dihapus!");//MessageBox Informasi
            }
            else if (dialogResult == DialogResult.No)  
            {
                //do something else
                //Jika konfirmasi NO tidak dilakukan apa-apa
            }
            ID();
        }
        //Button Batal
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            Clear();//pemanggilan method untuk hapus isian textbox karena untuk pembatalan isian
            ID();
        }
        //aksi jika cell datagrid di pilih / diklik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //percabangan, untuk melihat apakah datagridview berisi data atau kosong
            {   //jika kondisi terpenuhi, maka sourcecode dibawah ini akan dieksekusi
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TxtID.Text = row.Cells[0].Value.ToString();//memasukkan data dari datagrid ke textbox ID
                TxtNamaPaket.Text = row.Cells[1].Value.ToString();//memasukkan data dari datagrid ke textbox nama
                TxtHarga.Text = row.Cells[2].Value.ToString();//memasukkan data dari datagrid ke textbox harga
                TxtDurasi.Text = row.Cells[3].Value.ToString();//memasukkan data dari datagrid ke textbox durasi
            }
        }
        //form load
        private void FrmPaket_Load(object sender, EventArgs e)
        {   //mengisi textbox ID dengan menggunakan date time now
            ID();
            TxtNamaPaket.Focus();
        }
        public void ID()
        {
            TxtID.Text = "Pkt-" + DateTime.Now.ToString("ddMMyyyyhhmmss");
        }
    }
}

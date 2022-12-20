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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pemanggilan method konfirmasi keluar aplikasi
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosingEventCancel_Closing);
        }
        //Method untuk konfirmasi keluar aplikasi
        private void FormClosingEventCancel_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox konfirmasi keluar aplikasi
            DialogResult dr = MessageBox.Show("Apakah Anda yakin keluar dari aplikasi ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) //percangan messageBox konfirmasi
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        //Method yang dijalankan ketika form di load
        private void Form1_Load(object sender, EventArgs e)
        {
            Login L = new Login(); //untuk menginisiasi form login
            L.ShowDialog(); //untuk menampilkan form login
            this.MaximizeBox = false; //untuk mendisable button max/min
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {}

        //Button Logout
        private void button6_Click(object sender, EventArgs e)
        {
            Login L = new Login(); //untuk menginisiasi form login
            L.ShowDialog(); //untuk menampilkan form login
        }
        
        //Button untuk membuka form Transaksi
        private void button1_Click(object sender, EventArgs e)
        {
            FrmTransaksi FT = new FrmTransaksi(); //untuk menginisiasi form Transaksi
            FT.ShowDialog(); //untuk menampilkan form Transaksi
        }
        //Button untuk membuka form Pelanggan
        private void button5_Click(object sender, EventArgs e)
        {
            FrmPelanggan FPel = new FrmPelanggan(); //untuk menginisiasi form Pelanggan
            FPel.ShowDialog();  //untuk menampilkan form Pelanggan
        }
        //Button untuk membuka form Laporan Transaksi
        private void button2_Click(object sender, EventArgs e)
        {
            FrmLaporan FL = new FrmLaporan(); //untuk menginisiasi form Transaksi
            FL.ShowDialog(); //untuk menampilkan form Transaksi
        }
        //Button untuk membuka form Pengguna / user aplikasi
        private void button3_Click(object sender, EventArgs e)
        {
            FrmPengguna FP = new FrmPengguna(); //untuk menginisiasi form Pengguna
            FP.ShowDialog(); //untuk menampilkan form Pengguna
        }
        //Button untuk membuka form Paket Laundry
        private void button4_Click(object sender, EventArgs e)
        {
            FrmPaket FPaket = new FrmPaket(); //untuk menginisiasi form Paket Laundry
            FPaket.ShowDialog(); //untuk menampilkan form Paket Laundry
        }
    }
}

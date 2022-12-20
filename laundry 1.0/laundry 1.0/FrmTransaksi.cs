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
    public partial class FrmTransaksi : Form
    {
        public object itemsList { get; private set; }
        int tgl;
        string tm_date;
        public FrmTransaksi()
        {
            InitializeComponent();

        }


        //===============
        //Display Data
        //---------------
        private void DisplayData()
        {
            var contex = new laundryEntities1();
            laundryEntities1 laundry = new laundryEntities1();
            var item = laundry.users.ToList();
            dataGridView1.DataSource = item;
        }

        //===============
        //Clear
        //---------------
        public void Clear()
        {
            TxtBayar.Text = "0";
            TxtBerat.Text = "";
            TxtDiskon.Text = "";
            TxtHarga.Text = "";
            TxtTelp.Text = "";
            TxtDiskon.Text = "";

            LblTotal.Text = "";
            
            CboPaket.Text = "";
            CboPelanggan.Text = "";
            //dataGridView1.Columns.Clear();
        }

        public void tutup()
        {
            FrmTransaksi a = new FrmTransaksi();
            a.Close();
        }

        public void buka()
        {
            FrmTransaksi b = new FrmTransaksi();
            b.ShowDialog();
        }

        private void Btnbatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSelesai_Click(object sender, EventArgs e)
        {
            
            var contex = new laundryEntities1();

            simpan_tm();
            simpan_detail();

            Clear();
            
            MessageBox.Show("Transaksi Berhasil!");
            //tutup();
            buka();
            this.Close();
            //buka();
            mulai();
            
        }

        private void FillCboPelanggan()
        {
            var contex = new laundryEntities1();
            CboPelanggan.ValueMember = "id_pel";
            CboPelanggan.DisplayMember = "nama_pel";
            CboPelanggan.DataSource = contex.pelanggans.ToList();
        }

        public void FillCboPaket()
        {
            var contex = new laundryEntities1();
            CboPaket.ValueMember = "id_paket";
            CboPaket.DisplayMember = "nama_paket";
            CboPaket.DataSource = contex.pakets.ToList();
        }

        private void FrmTransaksi_Load(object sender, EventArgs e)
        {
            mulai();
            CboPelanggan.Focus();
        }

        public void mulai()
        {
            FillCboPelanggan();
            FillCboPaket();
            TxtID.Text = "Trx-" + DateTime.Now.ToString("ddMMyyyyhhmmss");
            tm_date = DateTime.Now.ToString("dd/MM/yyyy");
            tgl = Convert.ToInt32(DateTime.Now.ToString("dd"));
            CboPelanggan.Text = "";
            TxtTelp.Text = "";
            CboPaket.Text = "";
            TxtHarga.Text = "";
            TxtDiskon.Text = "0";
            LblTmDate.Text = Convert.ToString(tm_date);
            //dataGridView1.Columns
        }


        private void CboPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_telp();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            durasi();
            int sub_total = Convert.ToInt32(TxtHarga.Text) * Convert.ToInt32(TxtBerat.Text);

            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["no", row].Value = dataGridView1.RowCount - 1;
            dataGridView1["nama_paket", row].Value = CboPaket.Text;
            dataGridView1["berat", row].Value = TxtBerat.Text;
            dataGridView1["diskon", row].Value = TxtDiskon.Text;
            dataGridView1["sub_total", row].Value = sub_total;
            dataGridView1.Refresh();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            LblTotal.Text = Convert.ToString(sum);

            TxtBerat.Text = "";
            TxtDiskon.Text = "0";
            CboPaket.Text = "";
            TxtHarga.Text = "";
        }


        public void no_telp()
        {
            var contex = new laundryEntities1();
            var query = contex.Database.SqlQuery<string>(
                "SELECT telp FROM dbo.pelanggan where nama_pel ='" + this.CboPelanggan.Text + "'").Single();
            TxtTelp.Text = query.ToString();
        }

        public void durasi()
        {
           var contex = new laundryEntities1();
           var query = contex.Database.SqlQuery<int>(
           "SELECT durasi FROM dbo.paket where nama_paket ='" + this.CboPaket.Text + "'").Single();
           int ambil = tgl + query;
           LblAmbil.Text = Convert.ToString(ambil) + DateTime.Now.ToString("/MM/yyyy");
        }

        public void harga()
        {
            var contex = new laundryEntities1();
            var harga = contex.Database.SqlQuery<int>(
                "SELECT harga_satuan FROM dbo.paket where nama_paket ='" + this.CboPaket.Text + "'").Single();
            TxtHarga.Text = harga.ToString();
        }

        private void TxtHarga_TextChanged(object sender, EventArgs e)
        {}

        private void CboPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            harga();
        }

        private void TxtBayar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBayar.Text == "")
            {
                MessageBox.Show("TextBox Bayar tidak boleh kosong!");
                TxtBayar.Text = "0";
            }
            else
            {
                int kembali = (Convert.ToInt32(TxtBayar.Text) - Convert.ToInt32(LblTotal.Text));
                LblKembali.Text = Convert.ToString(kembali);
            }
          
        }

        private void TxtBayar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
        }

        public void simpan_tm()
        {
            var contex = new laundryEntities1();
            string query = "INSERT INTO [dbo].[transaksi_masuk]([id_tm],[tgl_tm],[tgl_ambil],[total_harga],[status],[nama_pel],[telp])VALUES('" + TxtID.Text + "','" + LblTmDate.Text + "','" + LblAmbil.Text + "','" + LblTotal.Text + "','','" + CboPelanggan.Text + "','" + TxtTelp.Text + "')";       
            contex.Database.ExecuteSqlCommand(query);
        }
        public void simpan_detail()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                var no = dataGridView1.Rows[i].Cells[0].Value;
                var nama_paket = dataGridView1.Rows[i].Cells[1].Value;
                var berat = dataGridView1.Rows[i].Cells[2].Value;
                var diskon = dataGridView1.Rows[i].Cells[3].Value;
                var sub_total = dataGridView1.Rows[i].Cells[4].Value;
                //Konversi
                LblNo.Text = Convert.ToString(no);
                Lblnamapkt.Text = Convert.ToString(nama_paket);
                LblBrt.Text = Convert.ToString(berat);
                LblDis.Text = Convert.ToString(diskon);
                LblSub.Text = Convert.ToString(sub_total);

                //MessageBox.Show("No: "+LblNo.Text, "Nm: "+Lblnamapkt.Text);
                //MessageBox.Show("brt: " + LblBrt.Text, "Dis: " + LblDis.Text);
                //MessageBox.Show("SubTot: " + LblSub.Text);

                var contex = new laundryEntities1();
                string query = "INSERT INTO [dbo].[detail_tm] ([no],[id_tm],[nama_paket],[berat],[diskon],[sub_total]) VALUES('" + LblNo.Text + "','" + TxtID.Text + "','" + Lblnamapkt.Text + "','" + LblBrt.Text + "','" + LblDis.Text + "','" + LblSub.Text + "')";
                contex.Database.ExecuteSqlCommand(query);
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    foreach (DataGridViewRow selected in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(selected);


                    }
                }
                else
                {
                    MessageBox.Show("No Row Selected");
                }
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }

                LblTotal.Text = Convert.ToString(sum);

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnHapus.Enabled = true;
        }
    }
}

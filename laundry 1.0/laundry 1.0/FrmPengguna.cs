using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace laundry_1._0
{
    public partial class FrmPengguna : Form
    {
        public FrmPengguna()
        {
            InitializeComponent();
            DisplayData(); 
        }
        //Button Simpan
        private void button2_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1();
            
            string query = "INSERT INTO [dbo].[user] VALUES ('" + TxtID.Text + "','" + TxtNamaUser.Text + "', '" + TxtPass.Text + "', '" + CboLevel.SelectedItem + "')";
            contex.Database.ExecuteSqlCommand(query);
            string urut = query;
            Clear();
            DisplayData();
            MessageBox.Show("Data Berhasil Ditambahkan!");
        }      
        //Method untuk menampilkan data ke datagrid
        private void DisplayData()
        {
            var contex = new laundryEntities1(); //inisiasi koneksi
            laundryEntities1 laundry = new laundryEntities1(); //koneksi
            var item = laundry.users.ToList(); //mengambil data dari db, diisi ke var item
            dataGridView1.DataSource = item; //menjadikan var item sbg datasource datagrid
        }
        //method untuk mengosongkan isian
        public void Clear()
        {
            TxtID.Text = "";
            TxtNamaUser.Text = "";
            TxtPass.Text = "";
            CboLevel.Text = "";
        }
        //button batal
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            Clear();//memanggil method clear
        }
        //button ubah,untuk mengubah data 
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1();
            string query = "UPDATE [dbo].[user] SET [uname] = '" + TxtNamaUser.Text + "',[upass] = '" + TxtPass.Text + "',[level] = '" + CboLevel.SelectedItem + "' WHERE id_user = '" + TxtID.Text + "'";
            contex.Database.ExecuteSqlCommand(query);
            Clear();//memanggil method clear
            DisplayData();//memanggil method DisplayData
            MessageBox.Show("Data berhasil diperbarui!");
        }
        //Button hapus, menghapus data dari db
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            var contex = new laundryEntities1();
            string query = "DELETE FROM [dbo].[user] WHERE id_user = '"+TxtID.Text+"'";
            contex.Database.ExecuteSqlCommand(query);
            Clear();//memanggil method clear
            DisplayData();//memanggil method DisplayData
            MessageBox.Show("Data berhasil dihapus!");
        }
        //form load
        private void FrmPengguna_Load(object sender, EventArgs e)
        {   //mengisi ID dengan datetime now
            TxtID.Text = "Usr-" + DateTime.Now.ToString("ddMMyyyyhmmss");
        }
        //method pencarian
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
                        MessageBox.Show("Unable to find " + TxtCari.Text, "Not Found");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        //Button Cari
        private void BtnCetak_Click(object sender, EventArgs e)
        {
            searchart();//memanggil method pencarian
        }
        //aksi jika cell datagrid diklik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//percabangan, untuk melihat apakah datagridview berisi data atau kosong
            {   //jika kondisi terpenuhi, maka sourcecode dibawah ini akan dieksekusi
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];//select index row datagrid
                TxtID.Text = row.Cells[0].Value.ToString();//memasukkan data dari datagrid ke textbox ID
                TxtNamaUser.Text = row.Cells[1].Value.ToString();//memasukkan data dari datagrid ke textbox nama
                TxtPass.Text = row.Cells[2].Value.ToString();//memasukkan data dari datagrid ke textbox alamat
                CboLevel.Text = row.Cells[3].Value.ToString();//memasukkan data dari datagrid ke textbox telp
            }
        }
    }
}

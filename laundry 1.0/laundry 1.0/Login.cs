using System;
using System.Collections;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        //Button Login
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtUsername.Text, TxtPass.Text))
            {
                //User is valid
                MessageBox.Show("Login Sukses!","Login");
                this.Close();
            }
            else {
                //User is not valid
                MessageBox.Show("Login Gagal!","Login");
                txtUsername.Text = "";
                TxtPass.Text = "";
            }
        }

        //Method validasi username dan password untuk login
        private bool IsvalidUser(string userName, string password)
        {
            laundryEntities1 context = new laundryEntities1();
            var query = from p in context.users     //query 
                        where p.uname == userName
                        && p.upass == password
                        select p;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Button untuk menutup aplikasi
        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox konfirmasi menutup aplikasi
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin keluar dari aplikasi ini", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
    }
}

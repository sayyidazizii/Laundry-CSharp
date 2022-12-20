namespace laundry_1._0
{
    partial class FrmTransaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboPelanggan = new System.Windows.Forms.ComboBox();
            this.CboPaket = new System.Windows.Forms.ComboBox();
            this.TxtBerat = new System.Windows.Forms.TextBox();
            this.TxtDiskon = new System.Windows.Forms.TextBox();
            this.TxtTelp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblKembali = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtBayar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.Btnbatal = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnSelesai = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LblTmDate = new System.Windows.Forms.Label();
            this.LblAmbil = new System.Windows.Forms.Label();
            this.Lblnamapkt = new System.Windows.Forms.Label();
            this.LblNo = new System.Windows.Forms.Label();
            this.LblDis = new System.Windows.Forms.Label();
            this.LblBrt = new System.Windows.Forms.Label();
            this.LblSub = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-4, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::laundry_1._0.Properties.Resources.washing_machine;
            this.pictureBox2.Location = new System.Drawing.Point(16, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(99, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Melakukan transaksi  laundry masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaksi Laundry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "No Faktur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Paket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Berat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Diskon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nama Pelanggan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kg";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.nama_paket,
            this.berat,
            this.diskon,
            this.sub_total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 157);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.No.Width = 45;
            // 
            // nama_paket
            // 
            this.nama_paket.HeaderText = "Nama Paket";
            this.nama_paket.Name = "nama_paket";
            this.nama_paket.Width = 200;
            // 
            // berat
            // 
            this.berat.HeaderText = "Berat";
            this.berat.Name = "berat";
            this.berat.Width = 75;
            // 
            // diskon
            // 
            this.diskon.HeaderText = "Diskon";
            this.diskon.Name = "diskon";
            this.diskon.Width = 75;
            // 
            // sub_total
            // 
            this.sub_total.HeaderText = "Sub Total";
            this.sub_total.Name = "sub_total";
            this.sub_total.Width = 200;
            // 
            // CboPelanggan
            // 
            this.CboPelanggan.FormattingEnabled = true;
            this.CboPelanggan.Location = new System.Drawing.Point(450, 116);
            this.CboPelanggan.Name = "CboPelanggan";
            this.CboPelanggan.Size = new System.Drawing.Size(121, 24);
            this.CboPelanggan.TabIndex = 3;
            this.CboPelanggan.SelectedIndexChanged += new System.EventHandler(this.CboPelanggan_SelectedIndexChanged);
            // 
            // CboPaket
            // 
            this.CboPaket.FormattingEnabled = true;
            this.CboPaket.Location = new System.Drawing.Point(122, 198);
            this.CboPaket.Name = "CboPaket";
            this.CboPaket.Size = new System.Drawing.Size(172, 24);
            this.CboPaket.TabIndex = 4;
            this.CboPaket.SelectedIndexChanged += new System.EventHandler(this.CboPaket_SelectedIndexChanged);
            // 
            // TxtBerat
            // 
            this.TxtBerat.Location = new System.Drawing.Point(370, 195);
            this.TxtBerat.Name = "TxtBerat";
            this.TxtBerat.Size = new System.Drawing.Size(68, 23);
            this.TxtBerat.TabIndex = 5;
            // 
            // TxtDiskon
            // 
            this.TxtDiskon.Location = new System.Drawing.Point(370, 227);
            this.TxtDiskon.Name = "TxtDiskon";
            this.TxtDiskon.Size = new System.Drawing.Size(68, 23);
            this.TxtDiskon.TabIndex = 6;
            // 
            // TxtTelp
            // 
            this.TxtTelp.Location = new System.Drawing.Point(450, 146);
            this.TxtTelp.Name = "TxtTelp";
            this.TxtTelp.ReadOnly = true;
            this.TxtTelp.Size = new System.Drawing.Size(129, 23);
            this.TxtTelp.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.LblKembali);
            this.groupBox2.Controls.Add(this.LblTotal);
            this.groupBox2.Controls.Add(this.TxtBayar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(613, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // LblKembali
            // 
            this.LblKembali.AutoSize = true;
            this.LblKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKembali.Location = new System.Drawing.Point(88, 109);
            this.LblKembali.Name = "LblKembali";
            this.LblKembali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblKembali.Size = new System.Drawing.Size(0, 20);
            this.LblKembali.TabIndex = 5;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Red;
            this.LblTotal.Location = new System.Drawing.Point(88, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTotal.Size = new System.Drawing.Size(0, 29);
            this.LblTotal.TabIndex = 4;
            // 
            // TxtBayar
            // 
            this.TxtBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBayar.Location = new System.Drawing.Point(92, 62);
            this.TxtBayar.Name = "TxtBayar";
            this.TxtBayar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBayar.Size = new System.Drawing.Size(121, 24);
            this.TxtBayar.TabIndex = 3;
            this.TxtBayar.TextChanged += new System.EventHandler(this.TxtBayar_TextChanged);
            this.TxtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBayar_KeyPress_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kembali";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bayar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Harga/Kg";
            // 
            // TxtHarga
            // 
            this.TxtHarga.Location = new System.Drawing.Point(122, 233);
            this.TxtHarga.Name = "TxtHarga";
            this.TxtHarga.ReadOnly = true;
            this.TxtHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtHarga.Size = new System.Drawing.Size(113, 23);
            this.TxtHarga.TabIndex = 9;
            this.TxtHarga.TextChanged += new System.EventHandler(this.TxtHarga_TextChanged);
            // 
            // Btnbatal
            // 
            this.Btnbatal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btnbatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.Btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbatal.Image = global::laundry_1._0.Properties.Resources.refresh;
            this.Btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnbatal.Location = new System.Drawing.Point(248, 272);
            this.Btnbatal.Name = "Btnbatal";
            this.Btnbatal.Size = new System.Drawing.Size(111, 39);
            this.Btnbatal.TabIndex = 12;
            this.Btnbatal.Text = "Batal";
            this.Btnbatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnbatal.UseVisualStyleBackColor = true;
            this.Btnbatal.Click += new System.EventHandler(this.Btnbatal_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Enabled = false;
            this.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.Image = global::laundry_1._0.Properties.Resources.cancel__1_;
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(131, 272);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(111, 39);
            this.BtnHapus.TabIndex = 11;
            this.BtnHapus.TabStop = false;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.Image = global::laundry_1._0.Properties.Resources.add;
            this.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTambah.Location = new System.Drawing.Point(14, 272);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(111, 39);
            this.BtnTambah.TabIndex = 10;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnSelesai
            // 
            this.BtnSelesai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSelesai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BtnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelesai.Image = global::laundry_1._0.Properties.Resources._checked;
            this.BtnSelesai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelesai.Location = new System.Drawing.Point(665, 265);
            this.BtnSelesai.Name = "BtnSelesai";
            this.BtnSelesai.Size = new System.Drawing.Size(111, 39);
            this.BtnSelesai.TabIndex = 12;
            this.BtnSelesai.Text = "Selesai";
            this.BtnSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelesai.UseVisualStyleBackColor = true;
            this.BtnSelesai.Click += new System.EventHandler(this.BtnSelesai_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(91, 116);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(129, 23);
            this.TxtID.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "%";
            // 
            // LblTmDate
            // 
            this.LblTmDate.AutoSize = true;
            this.LblTmDate.Location = new System.Drawing.Point(732, 355);
            this.LblTmDate.Name = "LblTmDate";
            this.LblTmDate.Size = new System.Drawing.Size(16, 17);
            this.LblTmDate.TabIndex = 15;
            this.LblTmDate.Text = "a";
            this.LblTmDate.Visible = false;
            // 
            // LblAmbil
            // 
            this.LblAmbil.AutoSize = true;
            this.LblAmbil.Location = new System.Drawing.Point(753, 355);
            this.LblAmbil.Name = "LblAmbil";
            this.LblAmbil.Size = new System.Drawing.Size(16, 17);
            this.LblAmbil.TabIndex = 15;
            this.LblAmbil.Text = "a";
            this.LblAmbil.Visible = false;
            // 
            // Lblnamapkt
            // 
            this.Lblnamapkt.AutoSize = true;
            this.Lblnamapkt.Location = new System.Drawing.Point(698, 415);
            this.Lblnamapkt.Name = "Lblnamapkt";
            this.Lblnamapkt.Size = new System.Drawing.Size(16, 17);
            this.Lblnamapkt.TabIndex = 16;
            this.Lblnamapkt.Text = "a";
            this.Lblnamapkt.Visible = false;
            // 
            // LblNo
            // 
            this.LblNo.AutoSize = true;
            this.LblNo.Location = new System.Drawing.Point(677, 415);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(16, 17);
            this.LblNo.TabIndex = 17;
            this.LblNo.Text = "a";
            this.LblNo.Visible = false;
            // 
            // LblDis
            // 
            this.LblDis.AutoSize = true;
            this.LblDis.Location = new System.Drawing.Point(753, 415);
            this.LblDis.Name = "LblDis";
            this.LblDis.Size = new System.Drawing.Size(16, 17);
            this.LblDis.TabIndex = 18;
            this.LblDis.Text = "a";
            this.LblDis.Visible = false;
            // 
            // LblBrt
            // 
            this.LblBrt.AutoSize = true;
            this.LblBrt.Location = new System.Drawing.Point(732, 415);
            this.LblBrt.Name = "LblBrt";
            this.LblBrt.Size = new System.Drawing.Size(16, 17);
            this.LblBrt.TabIndex = 19;
            this.LblBrt.Text = "a";
            this.LblBrt.Visible = false;
            // 
            // LblSub
            // 
            this.LblSub.AutoSize = true;
            this.LblSub.Location = new System.Drawing.Point(775, 415);
            this.LblSub.Name = "LblSub";
            this.LblSub.Size = new System.Drawing.Size(16, 17);
            this.LblSub.TabIndex = 18;
            this.LblSub.Text = "a";
            this.LblSub.Visible = false;
            // 
            // FrmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(844, 486);
            this.Controls.Add(this.LblSub);
            this.Controls.Add(this.LblDis);
            this.Controls.Add(this.LblBrt);
            this.Controls.Add(this.Lblnamapkt);
            this.Controls.Add(this.LblNo);
            this.Controls.Add(this.LblAmbil);
            this.Controls.Add(this.LblTmDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnSelesai);
            this.Controls.Add(this.Btnbatal);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.TxtHarga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtTelp);
            this.Controls.Add(this.TxtDiskon);
            this.Controls.Add(this.TxtBerat);
            this.Controls.Add(this.CboPaket);
            this.Controls.Add(this.CboPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTransaksi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.FrmTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CboPelanggan;
        private System.Windows.Forms.ComboBox CboPaket;
        private System.Windows.Forms.TextBox TxtBerat;
        private System.Windows.Forms.TextBox TxtDiskon;
        private System.Windows.Forms.TextBox TxtTelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblKembali;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtBayar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtHarga;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button Btnbatal;
        private System.Windows.Forms.Button BtnSelesai;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn berat;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblTmDate;
        private System.Windows.Forms.Label LblAmbil;
        private System.Windows.Forms.Label Lblnamapkt;
        private System.Windows.Forms.Label LblNo;
        private System.Windows.Forms.Label LblDis;
        private System.Windows.Forms.Label LblBrt;
        private System.Windows.Forms.Label LblSub;
    }
}
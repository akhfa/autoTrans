using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace autoTrans
{
    public partial class LaporanBulanan : Form
    {
        DBConnect con;
        List<Pemasukan> dataPemasukan = new List<Pemasukan>();
        List<Pengeluaran> dataPengeluaran = new List<Pengeluaran>();
        public LaporanBulanan()
        {
            InitializeComponent();
            //koneksi ke database
            con = new DBConnect();
            //bulan pada Combobox
            bulanComboBox.Items.Add("Januari");
            bulanComboBox.Items.Add("Februari");
            bulanComboBox.Items.Add("Maret");
            bulanComboBox.Items.Add("April");
            bulanComboBox.Items.Add("Mei");
            bulanComboBox.Items.Add("Juni");
            bulanComboBox.Items.Add("Juli");
            bulanComboBox.Items.Add("Agustus");
            bulanComboBox.Items.Add("September");
            bulanComboBox.Items.Add("Oktober");
            bulanComboBox.Items.Add("Nopember");
            bulanComboBox.Items.Add("Desember");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LaporanBulanan_Load(object sender, EventArgs e)
        {
            tahuntextBox.Text = DateTime.Now.ToString("yyyy");
            switch (DateTime.Now.ToString("M"))
            {
                case "1" : bulanComboBox.Text = "Januari";
                    break;
                case "2": bulanComboBox.Text = "Februari";
                    break;
                case "3": bulanComboBox.Text = "Maret";
                    break;
                case "4": bulanComboBox.Text = "April";
                    break;
                case "5": bulanComboBox.Text = "Mei";
                    break;
                case "6": bulanComboBox.Text = "Juni";
                    break;
                case "7": bulanComboBox.Text = "Juli";
                    break;
                case "8": bulanComboBox.Text = "Agustus";
                    break;
                case "9": bulanComboBox.Text = "September";
                    break;
                case "10": bulanComboBox.Text = "Oktober";
                    break;
                case "11": bulanComboBox.Text = "Nopember";
                    break;
                case "12": bulanComboBox.Text = "Desember";
                    break;
                default  : bulanComboBox.Text = "Januari";
                    break;
            }
        }

        private void laporanHarianLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string tanggal = tanggalDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string bulan = tanggalDateTimePicker.Value.ToString("MM");
            string tahun = tanggalDateTimePicker.Value.ToString("yyyy");
            string keterangan = ketTextBox.Text;
            string biaya = biayaTextBox.Text;
            string jumlah = jumlahTextBox.Text;
            if((tanggal == null) || (keterangan == "") || (biaya=="") || (jumlah==""))
            {
                MessageBox.Show("Silahkan isi data pengeluaran yang masih kosong!");
            }
            else
            {
                Regex pattern = new Regex("^[0-9]*$");
                if (!pattern.IsMatch(biayaTextBox.Text) || !pattern.IsMatch(jumlahTextBox.Text))
                {
                    MessageBox.Show("Input salah! Silahkan isi biaya/jumlah dengan angka.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    string query = "INSERT INTO pengeluaran (`id_transaksi`, `nama_barang`, `harga`, `tanggal`, `jumlah`) VALUES (NULL, '" + keterangan + "', '" + biaya + "', '" + tanggal + "','" + jumlah + "');";
                    MessageBox.Show(query);
                    con.Insert(query);
                    //kosongkan form
                    ketTextBox.Text = "";
                    biayaTextBox.Text = "";
                    jumlahTextBox.Text = "";
                    //Pemasukan
                    dataPemasukan = con.getPemasukan(bulan, tahun);
                    pemasukanDataGridView.DataSource = null;
                    pemasukanDataGridView.DataSource = dataPemasukan;
                    pemasukanDataGridView.Columns[0].HeaderText = "No";
                    pemasukanDataGridView.Columns[1].HeaderText = "Tanggal";
                    pemasukanDataGridView.Columns[2].HeaderText = "Keterangan";
                    pemasukanDataGridView.Columns[3].HeaderText = "Biaya (Rp)";
                    pemasukanDataGridView.Columns[4].HeaderText = "Jumlah/Unit";
                    pemasukanDataGridView.Columns[5].HeaderText = "Subtotal (Rp)";
                    int sum = 0;
                    for (int i = 0; i < pemasukanDataGridView.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(pemasukanDataGridView.Rows[i].Cells[5].Value);
                    }
                    pemasukanTotalLabel.Text = sum.ToString("Rp#,0.00");
                    //Pengeluaran
                    dataPengeluaran = con.getPengeluaran(bulan, tahun);
                    pengeluaranDataGridView.DataSource = null;
                    pengeluaranDataGridView.DataSource = dataPengeluaran;
                    pengeluaranDataGridView.Columns[0].HeaderText = "No";
                    pengeluaranDataGridView.Columns[1].HeaderText = "Tanggal";
                    pengeluaranDataGridView.Columns[2].HeaderText = "Keterangan";
                    pengeluaranDataGridView.Columns[3].HeaderText = "Biaya (Rp)";
                    pengeluaranDataGridView.Columns[4].HeaderText = "Jumlah/Unit";
                    pengeluaranDataGridView.Columns[5].HeaderText = "Subtotal (Rp)";
                    sum = 0;
                    for (int i = 0; i < pengeluaranDataGridView.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(pengeluaranDataGridView.Rows[i].Cells[5].Value);
                    }
                    pengeluaranTotalLabel.Text = sum.ToString("(Rp#,0.00)");
                    //Anggaran Total
                }
                
            }
        }

        private void tampilkanButton_Click(object sender, EventArgs e)
        {
            //get Bulan & Tahun
            string bulan;
            switch (bulanComboBox.Text)
            {
                case "Januari": bulan = "01";
                    break;
                case "Februari": bulan = "02";
                    break;
                case "Maret": bulan = "03";
                    break;
                case "April": bulan = "04";
                    break;
                case "Mei": bulan = "05";
                    break;
                case "Juni": bulan = "06";
                    break;
                case "Juli": bulan = "07";
                    break;
                case "Agustus": bulan = "08";
                    break;
                case "September": bulan = "09";
                    break;
                case "Oktober": bulan = "10";
                    break;
                case "Nopember": bulan = "11";
                    break;
                case "Desember": bulan = "12";
                    break;
                default: bulan = "";
                    break;
            }
            string tahun = tahuntextBox.Text;

            if (tahun == "")
            {
                MessageBox.Show("Silahkan isi kolom tahun terlebih dahulu!");
            }
            else
            {
                Regex pattern = new Regex("^[0-9]*$");
                if (!pattern.IsMatch(tahun))
                {
                    MessageBox.Show("Input salah! Silahkan isi tahun dengan angka.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Pemasukan
                    dataPemasukan = con.getPemasukan(bulan, tahun);
                    pemasukanDataGridView.DataSource = null;
                    pemasukanDataGridView.DataSource = dataPemasukan;
                    pemasukanDataGridView.Columns[0].HeaderText = "No";
                    pemasukanDataGridView.Columns[1].HeaderText = "Tanggal";
                    pemasukanDataGridView.Columns[2].HeaderText = "Keterangan";
                    pemasukanDataGridView.Columns[3].HeaderText = "Biaya (Rp)";
                    pemasukanDataGridView.Columns[4].HeaderText = "Jumlah/Unit";
                    pemasukanDataGridView.Columns[5].HeaderText = "Subtotal (Rp)";
                    int sumMasuk = 0;
                    for (int i = 0; i < pemasukanDataGridView.Rows.Count; ++i)
                    {
                        sumMasuk += Convert.ToInt32(pemasukanDataGridView.Rows[i].Cells[5].Value);
                    }
                    pemasukanTotalLabel.Text = sumMasuk.ToString("Rp#,0.00");
                    //Pengeluaran
                    dataPengeluaran = con.getPengeluaran(bulan, tahun);
                    pengeluaranDataGridView.DataSource = null;
                    pengeluaranDataGridView.DataSource = dataPengeluaran;
                    pengeluaranDataGridView.Columns[0].HeaderText = "No";
                    pengeluaranDataGridView.Columns[1].HeaderText = "Tanggal";
                    pengeluaranDataGridView.Columns[2].HeaderText = "Keterangan";
                    pengeluaranDataGridView.Columns[3].HeaderText = "Biaya (Rp)";
                    pengeluaranDataGridView.Columns[4].HeaderText = "Jumlah/Unit";
                    pengeluaranDataGridView.Columns[5].HeaderText = "Subtotal (Rp)";
                    int sumKeluar = 0;
                    for (int i = 0; i < pengeluaranDataGridView.Rows.Count; ++i)
                    {
                        sumKeluar += Convert.ToInt32(pengeluaranDataGridView.Rows[i].Cells[5].Value);
                    }
                    pengeluaranTotalLabel.Text = sumKeluar.ToString("(Rp#,0.00)");
                    //Anggaran Total
                    int sumTotal = sumMasuk - sumKeluar;
                    if (sumTotal > 0)
                    {
                        anggaranTotalLabel.ForeColor = System.Drawing.Color.Green;
                        anggaranTotalLabel.Text = (sumMasuk - sumKeluar).ToString("Rp#,0.00");
                    }
                    else
                    {
                        anggaranTotalLabel.ForeColor = System.Drawing.Color.Red;
                        anggaranTotalLabel.Text = (sumKeluar - sumMasuk).ToString("(Rp#,0.00)");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menumanajer = new MenuManajer();
            this.Dispose(true);
            menumanajer.Show();
        }
    }
}

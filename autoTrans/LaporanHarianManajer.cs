using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoTrans
{
    public partial class LaporanHarianManajer : Form
    {
        DBConnect con;
        int HargaTiket;
        public LaporanHarianManajer()
        {
            InitializeComponent();
            con = new DBConnect();
            lokasiComboBox.Items.Add("Bandung");
            lokasiComboBox.Items.Add("Depok");
            HargaTiket = 85000;
        }

        private void LaporanHarianManajer_Load(object sender, EventArgs e)
        {

        }

        private void lihatButton_Click(object sender, EventArgs e)
        {
            string trayekTerpilih = lokasiComboBox.Text;
            string tanggalTerpilih = tanggalMonthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            int jumlahPenumpang = con.Count("SELECT COUNT(`id_transaksi`) FROM `transaksi` WHERE `tanggal_keberangkatan` = '"+tanggalTerpilih+"' AND `trayek` = '"+trayekTerpilih+"'");
            int jumlahKeberangkatan = con.Count("SELECT COUNT(`id_jadwal`) FROM `transaksi` WHERE `tanggal_keberangkatan` = '" + tanggalTerpilih + "' AND `trayek` = '" + trayekTerpilih + "'");
            float rataKeberangkatan; 
            if(jumlahKeberangkatan == 0)
            {
                rataKeberangkatan = 0;
            }
            else
            {
                rataKeberangkatan = jumlahPenumpang/jumlahKeberangkatan;
            }
            int jumlahPemasukan = jumlahPenumpang * HargaTiket;
            int jumlahPengeluaran = con.Count("SELECT SUM(harga*jumlah) FROM `pengeluaran` WHERE `tanggal` LIKE '"+tanggalTerpilih+"%'");
            int totalAnggaran = jumlahPemasukan - jumlahPengeluaran;
            //tampilkan di layar
            tanggalTerpilihLabel.Text = tanggalMonthCalendar.SelectionRange.Start.ToString("dd MMMM yyyy");
            jumlahPenumpangValueLabel.Text = jumlahPenumpang.ToString();
            jumlahKeberangkatanValueLabel.Text = jumlahKeberangkatan.ToString();
            rataKeberangkatanValueLabel.Text = rataKeberangkatan.ToString();
            jumlahPemasukanValueLabel.Text = jumlahPemasukan.ToString("Rp#,0.00");
            jumlahPengeluaranValueLabel.Text = jumlahPengeluaran.ToString("Rp#,0.00");
            if (totalAnggaran < 0)
            {
                totalAnggaranValueLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                totalAnggaranValueLabel.ForeColor = System.Drawing.Color.Green;
            }
            totalAnggaranValueLabel.Text = totalAnggaran.ToString("Rp#,0.00");
        }

 
    }
}

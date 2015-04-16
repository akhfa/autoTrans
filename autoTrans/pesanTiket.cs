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
    public partial class Tiket : Form
    {
        DBConnect connection;
        int statusPembayaran = 0;
        int noKursi = 0;
        PictureBox[] listOfPictureBox = new PictureBox[13];
        public Tiket()
        {
            InitializeComponent();
            waktuComboBox.Items.Add("05.00 WIB");
            waktuComboBox.Items.Add("07.30 WIB");
            waktuComboBox.Items.Add("10.00 WIB");
            waktuComboBox.Items.Add("12.00 WIB");
            waktuComboBox.Items.Add("13.30 WIB");
            waktuComboBox.Items.Add("15.45 WIB");
            waktuComboBox.Items.Add("17.30 WIB");
            waktuComboBox.Items.Add("19.30 WIB");
            waktuMonthCalendar.MaxSelectionCount = 1;

            trayekComboBox.Items.Add("Depok - Bandung");
            trayekComboBox.Items.Add("Bandung - Depok");

            label1.Text = "1";
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
            label5.Text = "5";
            label6.Text = "6";
            label7.Text = "7";
            label8.Text = "8";
            label9.Text = "9";
            label10.Text = "10";
            label11.Text = "11";
            label12.Text = "12";
            label13.Text = "13";

            listOfPictureBox[0] = kursi1;
            listOfPictureBox[1] = kursi2;
            listOfPictureBox[2] = kursi3;
            listOfPictureBox[3] = kursi4;
            listOfPictureBox[4] = kursi5;
            listOfPictureBox[5] = kursi6;
            listOfPictureBox[6] = kursi7;
            listOfPictureBox[7] = kursi8;
            listOfPictureBox[8] = kursi9;
            listOfPictureBox[9] = kursi10;
            listOfPictureBox[10] = kursi11;
            listOfPictureBox[11] = kursi12;
            listOfPictureBox[12] = kursi13;

            kursiSupir.Image = Image.FromFile("src/kursisupir.jpg");

            foreach(PictureBox pic in listOfPictureBox)
            {
                pic.Image = Image.FromFile("src/kursisupir.jpg");
            }

            hargaTextBox.Text = "85000";
            hargaTextBox.Enabled = false;

            mobilComboBox.Enabled = false;

            this.disableChair();

            connection = new DBConnect();

            waktuMonthCalendar.Enabled = false;

        }

        
        private void cekKursiButton_Click(object sender, EventArgs e)
        {
            List<string> daftarKursiIsi = connection.getKursiIsi(waktuMonthCalendar.SelectionRange.Start.ToString("yyyyMMdd"), this.getIdJadwal(), mobilComboBox.Text);
            foreach(string kursi in daftarKursiIsi)
            {
                listOfPictureBox[Convert.ToInt32(kursi)].Image = Image.FromFile("src/kursiterisi.jpg");
                //MessageBox.Show(kursi);
            }
        }

        private void loadDropdownMobil()
        {
            List<string> daftarMobil = connection.getCarList(waktuComboBox.Text, waktuMonthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"));
            foreach(string mobil in daftarMobil)
            {
                mobilComboBox.Items.Add(mobil);
            }
        }

        private void simpanButton_Click(object sender, EventArgs e)
        {
            //getIdPelanggan
            int idPelanggan = connection.isExist(namaTextBox.Text, teleponTextBox.Text);
            if(idPelanggan == 0) //Jika penumpang not exist
            {
                connection.insertNewPelanggan(namaTextBox.Text, teleponTextBox.Text);
                idPelanggan = connection.isExist(namaTextBox.Text, teleponTextBox.Text);
            }

            //getIdJadwal
            int idJadwal = this.getIdJadwal();
            

            //MessageBox.Show(idJadwal.ToString());
            if (connection.insertTransaksi(DateTime.Now.ToString("yyMMddhhmmss"), idPelanggan, trayekComboBox.Text, idJadwal, waktuMonthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"), 4, 1, mobilComboBox.Text, hargaTextBox.Text))
                MessageBox.Show("Insert transaksi berhasil");
            else
                MessageBox.Show("Insert transaksi gagal");
        }

        private int getIdJadwal()
        {
            int idJadwal = 0;
            switch (waktuComboBox.Text)
            {
                case "05.00 WIB":
                    idJadwal = 1;
                    break;
                case "07.30 WIB":
                    idJadwal = 2;
                    break;
                case "10.00 WIB":
                    idJadwal = 3;
                    break;
                case "12.00 WIB":
                    idJadwal = 4;
                    break;
                case "13.30 WIB":
                    idJadwal = 5;
                    break;
                case "15.45 WIB":
                    idJadwal = 6;
                    break;
                case "17.30 WIB":
                    idJadwal = 7;
                    break;
                case "19.30 WIB":
                    idJadwal = 8;
                    break;
            }
            return idJadwal;
        }

        private void disableChair()
        {
            foreach(Control c in this.Controls)
            {
                if(c is PictureBox)
                {
                    c.Enabled = false;
                }
            }
        }

        private void waktuComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            waktuMonthCalendar.Enabled = true;
        }

        private void waktuMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            mobilComboBox.Items.Clear();
            loadDropdownMobil();
            mobilComboBox.Enabled = true;
            hargaTextBox.Enabled = true;
        }

        private void kursi1_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 1;
        }

        private void kursi2_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 2;
        }

        private void kursi3_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 3;
        }

        private void kursi4_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 4;
        }

        private void kursi5_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 5;
        }

        private void kursi6_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 6;
        }

        private void kursi7_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 7;
        }

        private void kursi8_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 8;
        }

        private void kursi9_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 9;
        }

        private void kursi10_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 10;
        }

        private void kursi11_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 11;
        }

        private void kursi12_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 12;
        }

        private void kursi13_MouseClick(object sender, MouseEventArgs e)
        {
            noKursi = 13;
        }
    }
}

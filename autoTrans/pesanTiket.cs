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

            PictureBox[] listOfPictureBox = {kursi1, kursi2, kursi3, kursi4, kursi5, kursi6,
                                            kursi7, kursi8, kursi9, kursi10, kursi11, kursi12, kursi13};

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

        }

        
        private void cekKursiButton_Click(object sender, EventArgs e)
        {
            //connection.Insert("INSERT INTO mobil values ('AA3011DD', 'Wawan')");
            loadDropdownMobil();
            mobilComboBox.Enabled = true;
            hargaTextBox.Enabled = true;
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
            int idPelanggan = connection.isExist(namaTextBox.Text, teleponTextBox.Text);
            if(idPelanggan == 0) //Jika penumpang not exist
            {
                connection.insertNewPelanggan(namaTextBox.Text, teleponTextBox.Text);
                idPelanggan = connection.isExist(namaTextBox.Text, teleponTextBox.Text);
            }
            if (connection.insertTransaksi(DateTime.Now.ToString("yyMMddhhmmss"), idPelanggan, "Bandung-depok", 3, "2015-04-21", 4, 1, "D 7648 AJ", "85000"))
                MessageBox.Show("Insert transaksi berhasil");
            else
                MessageBox.Show("Insert transaksi gagal");
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
    }
}

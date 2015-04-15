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

            kursiSupir.Image = Image.FromFile("src/kursisupir.jpg");
            kursi1.Image = Image.FromFile("src/kursikosong.jpg");
            kursi2.Image = Image.FromFile("src/kursiterisi.jpg");
            kursi3.Image = Image.FromFile("src/kursikosong.jpg");
            kursi4.Image = Image.FromFile("src/kursikosong.jpg");
            kursi5.Image = Image.FromFile("src/kursikosong.jpg");
            kursi6.Image = Image.FromFile("src/kursikosong.jpg");
            kursi7.Image = Image.FromFile("src/kursikosong.jpg");
            kursi8.Image = Image.FromFile("src/kursiterisi.jpg");
            kursi9.Image = Image.FromFile("src/kursikosong.jpg");
            kursi10.Image = Image.FromFile("src/kursikosong.jpg");
            kursi11.Image = Image.FromFile("src/kursiterisi.jpg");
            kursi12.Image = Image.FromFile("src/kursikosong.jpg");
            kursi13.Image = Image.FromFile("src/kursikosong.jpg");

            hargaTextBox.Text = "85000";
            hargaTextBox.Enabled = false;

            mobilComboBox.Enabled = false;
            //mobilComboBox.Items.Add("AA 1234 DD");
            //mobilComboBox.Items.Add("AA 5678 DD");
            //MessageBox.Show(kursi1.Size.ToString());
            //MessageBox.Show(kursi1.Image.Size.ToString());

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
            //List<string> daftarMobil = connection.getCarList(waktuComboBox.Text, "2015-04-21");
            List<string> daftarMobil = connection.getCarList(waktuComboBox.Text, waktuMonthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"));
            foreach(string mobil in daftarMobil)
            {
                mobilComboBox.Items.Add(mobil);
            }
        }
    }
}

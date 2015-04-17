using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;

namespace autoTrans
{
    public partial class laporanForm : Form
    {
        public laporanForm()
        {
            InitializeComponent();
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
            bulanComboBox.Items.Add("November");
            bulanComboBox.Items.Add("Desember");

            ModeComboBox.Items.Add("Jam");
            ModeComboBox.Items.Add("Hari");
        }

        private void tampilkanButton_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string d2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DBConnect connection;
            connection = new DBConnect();

            List<string>[] ListStats = connection.SelectStats(d1, d2);

            //untuk graf jam
            Dictionary<string, int> FreqJam = new Dictionary<string, int>();
            FreqJam["05.00 WIB"] = 0;
            FreqJam["07.30 WIB"] = 0;
            FreqJam["10.00 WIB"] = 0;
            FreqJam["12.00 WIB"] = 0;
            FreqJam["13.30 WIB"] = 0;
            FreqJam["15.45 WIB"] = 0;
            FreqJam["17.30 WIB"] = 0;
            FreqJam["19.30 WIB"] = 0;
            foreach(string jam in ListStats[0])
            {
                FreqJam[jam]++;
            }

            //untuk graf hari
            Dictionary<string, int> FreqHari = new Dictionary<string, int>();
            FreqHari["Monday"] = 0;
            FreqHari["Tuesday"] = 0;
            FreqHari["Wednesday"] = 0;
            FreqHari["Thursday"] = 0;
            FreqHari["Friday"] = 0;
            FreqHari["Saturday"] = 0;
            FreqHari["Sunday"] = 0;
            foreach(string tanggal in ListStats[1])
            {
                DateTime time = DateTime.Parse(tanggal);
                //MessageBox.Show(time.ToString("ddddddd"));
                FreqHari[time.ToString("ddddddd")]++;
            }

            if (ModeComboBox.SelectedIndex == 0)
            {
                if (!chart1.Series.IsUniqueName("Frekuensi Hari"))
                {
                    chart1.Series["Frekuensi Hari"].Enabled = false;
                }
                if (chart1.Series.IsUniqueName("Frekuensi Jam"))
                {
                    chart1.Series.Add("Frekuensi Jam");
                }
                chart1.Series["Frekuensi Jam"].Enabled = true;
                chart1.Series["Frekuensi Jam"].Points.DataBindXY(FreqJam.Keys, FreqJam.Values);
                chart1.Series["Frekuensi Jam"].IsVisibleInLegend = false;
            }
            else if(ModeComboBox.SelectedIndex == 1)
            {
                if (!chart1.Series.IsUniqueName("Frekuensi Jam"))
                {
                    chart1.Series["Frekuensi Jam"].Enabled = false;
                }
                if(chart1.Series.IsUniqueName("Frekuensi Hari"))
                {
                    chart1.Series.Add("Frekuensi Hari");
                }
                chart1.Series["Frekuensi Hari"].Enabled = true;
                chart1.Series["Frekuensi Hari"].Points.DataBindXY(FreqHari.Keys, FreqHari.Values);
                chart1.Series["Frekuensi Hari"].IsVisibleInLegend = false;
            }
        }


    }
}

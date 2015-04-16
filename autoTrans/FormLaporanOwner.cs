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
        }

        private void tampilkanButton_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string d2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DBConnect connection;
            connection = new DBConnect();

            List<string>[] ListStats = connection.SelectStats(d1, d2);

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
            //Series ser1 = new Series("Jam", 8);
            if (chart1.Series.IsUniqueName("Frekuensi Jam"))
            {
                chart1.Series.Add("Frekuensi Jam");
            }
            chart1.Series["Frekuensi Jam"].Points.DataBindXY(FreqJam.Keys, FreqJam.Values);
            chart1.Series["Frekuensi Jam"].IsVisibleInLegend = false;
            //chart1.Series.  
            //for(int i=0; i<ListStats.Length; i++)
            /*foreach (string s in ListStats[0])
            {
                //Debug.Write(s + " ");
            }
            foreach (string s in ListStats[1])
            {
                //Debug.WriteLine(s);
                MessageBox.Show(s);
            }*/
            //MessageBox.Show(s);
        }


    }
}

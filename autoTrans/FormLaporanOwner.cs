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
    }
}

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
        }
    }
}

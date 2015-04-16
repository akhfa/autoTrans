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
    public partial class MenuManajer : Form
    {
        public MenuManajer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form lapHarian = new LaporanHarianManajer();
            this.Dispose(false);
            lapHarian.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form lapBulanan = new LaporanBulanan();
            this.Dispose(false);
            lapBulanan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }
    }
}

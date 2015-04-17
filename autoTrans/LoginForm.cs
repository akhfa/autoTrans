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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextBox.Text == "agen" && passwordTextBox.Text == "agen")
            {
                Form pemesananTiket = new Tiket();
                this.Dispose(false);
                pemesananTiket.Show();
            }
            else if(userTextBox.Text == "owner" && passwordTextBox.Text == "owner")
            {
                Form owner = new laporanForm();
                this.Dispose(false);
                owner.Show();
            }
            else if(userTextBox.Text == "manajer" && passwordTextBox.Text == "manajer")
            {
                Form menumanajer = new MenuManajer();
                this.Dispose(false);
                menumanajer.Show();
            }
            else
            {
                MessageBox.Show("User atau password salah");
            }
        }
    }
}

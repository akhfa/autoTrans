using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace autoTrans
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "si_autotrans";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(String _query)
        {
            string query = _query;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                return true;
            }
            return false;
        }

        public bool insertNewPelanggan(string nama, string nomor)
        {
            string query = "INSERT INTO pelanggan (nama, telepon) values ('" + nama + "', '" + nomor + "')";

            return Insert(query);
        }

        public bool insertTransaksi(string id_transaksi, int id_pelanggan, string trayek, int id_jadwal, string date, 
                                    int no_kursi, int status, string plat_nomor, string harga)
        {
            string query = "INSERT INTO transaksi (id_transaksi, id_pelanggan, trayek, id_jadwal, tanggal_keberangkatan, no_kursi, status, mobil, harga) "+
                "values ('" + id_transaksi + "','" + id_pelanggan + "', '" + trayek + "','"+ id_jadwal +"','"+ date +"','"+
                no_kursi +"', '"+ status +"','"+ plat_nomor +"','"+ harga +"')";
            
            return Insert(query);
        }


        //Mengecek apakah pelanggan dengan nama name dan nomor telepon number ada di database
        //Jika ada, kembalikan id_pelanggan, jika enggak, kembalikan 0
        public int isExist(string name, string number)
        {
            string query = "SELECT * FROM pelanggan where nama = '" + name + "' and telepon = '" + number+"'";
            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    if(dataReader["nama"].ToString().Equals(name) && dataReader["telepon"].ToString().Equals(number))
                    {
                        int result = int.Parse(dataReader["id_pelanggan"].ToString());
                        this.CloseConnection();
                        return result;
                    }
                }
                this.CloseConnection();
            }
            return 0;
        }
        
        public List<String> getCarList(String jam, String tanggal)
        {
            string query = "SELECT plat_nomor FROM trans_mobil natural join jadwal WHERE jadwal.id_jadwal = trans_mobil.id_jadwal and tanggal = '" + tanggal + " 00:00:00' and jam = '" + jam + "'";
            List<string> daftarMobil = new List<string>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    daftarMobil.Add(dataReader["plat_nomor"].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Gagal meload daftar mobil yang berangkat pada jam ini.");
            }
            return daftarMobil;
        }

        /*
        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }*/
    }
}

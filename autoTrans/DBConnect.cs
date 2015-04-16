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
            //server = "akhfa.in";
            server = "localhost";
            database = "si_autotrans";
            //uid = "si_autotrans";
            //password = "autotransaya";
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

        public List<string> getKursiIsi(string date, int id_jadwal, string plat_nomor)
        {
            List<string> daftarKursiIsi = new List<string>();
            string query = "SELECT no_kursi FROM transaksi where tanggal_keberangkatan = '" + date + "' and id_jadwal= '" + id_jadwal+ "' and mobil = '" + plat_nomor +"'";
            //SELECT no_kursi FROM transaksi where tanggal_keberangkatan='2015-04-21' and id_jadwal='5' and mobil='D 7648 AJ'
            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    //MessageBox.Show(dataReader["no_kursi"].ToString());
                    daftarKursiIsi.Add(dataReader["no_kursi"].ToString());
                }
                this.CloseConnection();
            }
            return daftarKursiIsi;
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
        */
        //Select statement
        public List<string>[] Select(string _query)
        {
            string query = _query;

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        /*public List<stats> SelectStats(string d1, string d2)
        {
            List<stats> ListStats = new List<stats>();

            return ListStats;
        }*/

        public List<string>[] SelectStats(string d1, string d2)
        {
            List<string>[] ListStats = new List<string>[2];
            ListStats[0] = new List<string>();
            ListStats[1] = new List<string>();

            string query = "SELECT * FROM `transaksi` natural join jadwal WHERE (tanggal_keberangkatan BETWEEN '"+d1+"' AND '"+d2+"')";
            if(this.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {
                    ListStats[0].Add(dataReader["jam"] + "");
                    ListStats[1].Add(dataReader["tanggal_keberangkatan"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
            }
            else 
            {
                MessageBox.Show("Error dalam menghubungi database");
            }
            return ListStats;
        }
        /*
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marica_Coord
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
            lblError.Visible = false;
           
        }
        private bool IsValidPassword(string pass)
        {
            return (pass.Length > 7
                &&
                pass.Any(char.IsUpper) &&
                pass.Any(char.IsLower) 
                )
                ;
        }
        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[12];

            using (RandomNumberGenerator random = new RNGCryptoServiceProvider())
                random.GetNonZeroBytes(salt);

            return salt;
        }
        private bool IsValidUsername(string pass)
        {
            return (pass.Length > 7);
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRusername.Text;
            
            string password = txbR_Password.Text;
            string password2 = txbR_Password2.Text;
  
            
            if (password != password2)
            {
                lblError.Text = "Паролата не съвпада";
                lblError.Visible = true;

            }

            else if (!IsValidUsername(username))
            {
                lblError.Text = "Потребителското име е кратко. " +
                    "Минимум 8 символа";
                lblError.Visible = true;
            }

            else if (IsValidPassword(password))
            {
                string pathToFile = AppDomain.CurrentDomain.BaseDirectory;
                string newPath = Path.GetFullPath(Path.Combine(pathToFile, @""));

                string cs = @"Data Source=" + newPath + "MaricaDB.db" + ";Pooling=true;FailIfMissing=false;Version=3";
                string dataBaseMaricaDb = newPath + "MaricaDB.db";
                if (!System.IO.File.Exists(dataBaseMaricaDb))
                {
                 
                    SQLiteConnection.CreateFile(dataBaseMaricaDb);

                    using (var sqlite2 = new SQLiteConnection(cs))
                    {
                        sqlite2.Open();
                        var sql = @"CREATE TABLE [loginData] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [username] text NOT NULL, [password] text NOT NULL, [salt] text NOT NULL);CREATE UNIQUE INDEX [loginData_sqlite_autoindex_loginData_1] ON [loginData] ([username] ASC);";
                        SQLiteCommand command = new SQLiteCommand(sql, sqlite2);
                        command.ExecuteNonQuery();
                        sqlite2.Close();
                    }
                }






                SQLiteConnection connection = new SQLiteConnection(cs);
                connection.Open();



                string salt = Convert.ToBase64String(GenerateSalt());

     

                byte[] salted = logReg.GetSaltedPasswordHash(username, salt);
                

                string select = "SELECT count(*) FROM loginData WHERE username=@user";
                SQLiteCommand selectUser = new SQLiteCommand(select, connection);
                selectUser.Parameters.Add(new SQLiteParameter("@user", username));
                ;
                int count = Convert.ToInt32(selectUser.ExecuteScalar());
                if (count == 0)
                {
                    string insertUserSql = "INSERT INTO[loginData]([username],[password],[salt])VALUES(@username,@password,@salt);";
                    SQLiteCommand insertUser = new SQLiteCommand(insertUserSql, connection);
                    string hashPassword = Convert.ToBase64String(salted);
                    insertUser.Parameters.Add(new SQLiteParameter("@username", username));
                    insertUser.Parameters.Add(new SQLiteParameter("@password", hashPassword));
                    insertUser.Parameters.Add(new SQLiteParameter("@salt", salt));
                    insertUser.ExecuteNonQuery();
                    connection.Close();
                    this.Hide();

                    Login form2 = new Login();
                    form2.ShowDialog();
                }


                else
                {
                    lblError.Text = "Името е заето, измислете друго";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Text = "Паролата не е валидна";
                lblError.Visible = true;
            }
        }

     
    }
}

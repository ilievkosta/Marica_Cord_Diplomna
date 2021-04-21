using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using BojkoSoft.Transformations;
using BojkoSoft.Transformations.Constants;
using System.Globalization;
using System.Data.SQLite;

namespace Marica_Coord
{
    public partial class MaricaForm : Form
    {
        public void LoadData()
        {
            string pathToFile = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = Path.GetFullPath(Path.Combine(pathToFile, @""));
            string cs = @"Data Source=" + newPath + "Coord.db" + ";Pooling=true;FailIfMissing=false;Version=3";
            string dataBaseCoordDb = newPath + "Coord.db";

            if (!System.IO.File.Exists(dataBaseCoordDb))
            {

                SQLiteConnection.CreateFile(dataBaseCoordDb);

                using (var sqlite2 = new SQLiteConnection(cs))
                {
                    sqlite2.Open();

                    var sqlCreateTableCoord = @"CREATE TABLE [Coord] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Data] text NOT NULL, [Date] text NOT NULL, [User] text NOT NULL, [Job] text NOT NULL);";

                    SQLiteCommand commandCreateTable = new SQLiteCommand(sqlCreateTableCoord, sqlite2);
                    commandCreateTable.ExecuteNonQuery();
                    sqlite2.Close();
                }
            }



            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT Id,Data,Date,Job FROM Coord WHERE User=@User";


            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.Add(new SQLiteParameter("@User", lblUser.Text));
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                databaseGritBindingSource.Add(new DatabaseGrit() { Id = rdr.GetInt32(0), Data = rdr.GetString(1), Date = rdr.GetString(2), Job = rdr.GetString(3) });

            }
        }
        protected override void OnLoad(EventArgs e)
        {
            LoadData();

        }

        List<Cord> CurrentCord = new List<Cord>();

        public MaricaForm()
        {
            InitializeComponent();

        }
        public MaricaForm(string username)
        {
            InitializeComponent();
            string User = username;
            lblUser.Text = User;
            this.buttonAddToCord.Enabled = false;
            textBoxX.Tag = false;
            textBoxY.Tag = false;
            textBoxZ.Tag = false;
            textBoxNumber.Tag = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double x, y;
            double.TryParse(textBox1.Text, out x);
            double.TryParse(textBox2.Text, out y);
            x += 4580000;
            y += 9430000;
            string myStringX = x.ToString();
            string myStringY = y.ToString();
            this.textBox3.Text = myStringX;
            this.textBox4.Text = myStringY;
        }

        private void btnConvert70_Click(object sender, EventArgs e)
        {
            double x, y;
            double.TryParse(textBox3.Text, out x);
            double.TryParse(textBox4.Text, out y);
            x -= 4580000;
            y -= 9430000;
            string myStringX = x.ToString();
            string myStringY = y.ToString();
            this.textBox1.Text = myStringX;
            this.textBox2.Text = myStringY;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) ||
            ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 43 || e.KeyChar > 46) && (e.KeyChar != 8) ))
            {
                e.Handled = true;
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            fileOpenLittle();
        }
        private void fileOpenLittle()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";

            theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(theDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                List<string> listName = new List<string>();

                using (var reader = new StreamReader(fs))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listName.Add(values[0]);
                        listA.Add(values[1]);
                        listB.Add(values[2]);
                        listC.Add(values[3]);
                    }

                }
                try
                {
                    List<double> listA_double1 = listA.Select(x => double.Parse(x)).ToList();
                    List<double> listB_double1 = listB.Select(x => double.Parse(x)).ToList();
                    List<double> listC_double1 = listC.Select(x => double.Parse(x)).ToList();
                }
                catch (FormatException)
                {

                    System.Windows.Forms.MessageBox.Show("Въведете коректни данни");
                    return;

                }
                List<double> listA_double = listA.Select(x => double.Parse(x)).ToList();
                List<double> listB_double = listB.Select(x => double.Parse(x)).ToList();
                List<double> listC_double = listC.Select(x => double.Parse(x)).ToList();


                for (var i = 0; i < listA_double.Count; i++)
                {

                    CurrentCord.Add(new Cord(listName[i], listA_double[i], listB_double[i], listC_double[i]));
                }
                string output = Cord.printCord(CurrentCord, ";", "\r\n");
                this.textBoxMain.Text = output;

                sr.Close();
                fs.Close();
                fs.Dispose();

            }
        }



        private void SaveCoord(string CoordText)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();

                StreamWriter m_WriterParameter = new StreamWriter(fs);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(CoordText);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
                fs.Close();
            }

        }

        private void save1_Click(object sender, EventArgs e)
        {
            SaveCoord(this.textBoxMain.Text);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxMain.Text = this.textBoxMain.Text.Replace(" ", "");
        }

        private void radioMto70_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

            string message = "Координатите се записват в текстов файл (.txt) с" +
                "разделител ';' Десетичен разделител запетая ',' - пример" +
                 "\n" +
                "point1;34567,2;45671;12" +
                 "\n" +
                 "point2;56785;32457;17";
            MessageBox.Show(message);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cord.BGS_1970_K5toBGS_2005_KK(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void buttonToBig_Click(object sender, EventArgs e)
        {
            Cord.Mto1970(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void btn1970toBGS_2005_KClick(object sender, EventArgs e)
        {
            double x, y;

            //Избягване на грешка от въвеждането на десетичен разделител  с CultureInfo.InvariantCulture

            x = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            y = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);

            Transformations tr = new Transformations();

            GeoPoint input = new GeoPoint(x, y);
            GeoPoint result = tr.TransformBGSCoordinates(input, enumProjection.BGS_1970_K5, enumProjection.BGS_2005_KK);


            this.textBox3.Text = (result.X).ToString();
            this.textBox4.Text = (result.Y).ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string CoordData = Cord.SerializeToXml(CurrentCord);


            string pathToFile = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = Path.GetFullPath(Path.Combine(pathToFile, @""));

            string cs = @"Data Source=" + newPath + "Coord.db" + ";Pooling=true;FailIfMissing=false;Version=3";

            SQLiteConnection connection = new SQLiteConnection(cs);
            connection.Open();


            string insertCoordData = "INSERT INTO [Coord]([Data],[Date],[User],[Job])VALUES(@Data,@Date,@User,@Job);";
            SQLiteCommand insertCord = new SQLiteCommand(insertCoordData, connection);

            insertCord.Parameters.Add(new SQLiteParameter("@Data", CoordData));
            insertCord.Parameters.Add(new SQLiteParameter("@Date", DateTime.UtcNow.ToLocalTime()));
            insertCord.Parameters.Add(new SQLiteParameter("@User", lblUser.Text));

            insertCord.Parameters.Add(new SQLiteParameter("@Job", txtBoxJob.Text));
            insertCord.ExecuteNonQuery();



            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
            connection.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Coord" & dataGridView1.Rows.Count > 1)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    CurrentCord = Cord.DeserializeObject(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    textBoxMain.Text = Cord.printCord(CurrentCord, ";", "\r\n");

                }


            }


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" & dataGridView1.Rows.Count > 1)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (dataGridView1.CurrentRow != null)
                    {
                        string pathToFile = AppDomain.CurrentDomain.BaseDirectory;
                        string newPath = Path.GetFullPath(Path.Combine(pathToFile, @""));
                        string cs = @"Data Source=" + newPath + "Coord.db" + ";Pooling=true;FailIfMissing=false;Version=3";


                        SQLiteConnection con = new SQLiteConnection(cs);
                        con.Open();

                        SQLiteCommand cmd = new SQLiteCommand(con);
                        cmd.CommandText = "DELETE FROM Coord WHERE Id=@Id";
                        int Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Prepare();

                        cmd.ExecuteNonQuery();
                    }
                    databaseGritBindingSource.RemoveCurrent();

                }

            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
            CurrentCord.Clear();
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            Cord.Inverce(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void btn70ToMine_Click(object sender, EventArgs e)
        {
            Cord.B70toM(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

       
        private void buttonDelLast_Click(object sender, EventArgs e)
        {
            CurrentCord.RemoveAt(CurrentCord.Count - 1);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        

        private void buttonAddToCord_Click(object sender, EventArgs e)
        {
            double x, y, z;

            //Избягване на грешка от въвеждането на десетичен разделител  с CultureInfo.InvariantCulture
        
            x = double.Parse(textBoxX.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            y = double.Parse(textBoxY.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            z = double.Parse(textBoxZ.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            Cord inputCord = new Cord(textBoxNumber.Text, x, y, z);
            CurrentCord.Add(inputCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void buttonDellPosition_Click(object sender, EventArgs e)
        {
            string Text = textBoxNumber.Text;
            int i = 0;
            foreach (Cord item in CurrentCord)
            {
                i++;
                
                if (item.nameC == Text)
                {
                    CurrentCord.RemoveAt(i-1);
                
                    break;
                    
                }
                ;
            }
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void buttonGeoToUTM_Click(object sender, EventArgs e) 
        { 
        
            Cord.GeoToUTM(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;

        }

        private void buttonBGS2005Cadto70_Click(object sender, EventArgs e)
        {
            Cord.BGS_2005_KKtoBGS_1970_K5(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;

        }

        private void ValidateOK()
        {
               bool check = (
                  Convert.ToBoolean(this.textBoxNumber.Tag)
               && Convert.ToBoolean(this.textBoxX.Tag)
               && Convert.ToBoolean(this.textBoxY.Tag)
               && Convert.ToBoolean(this.textBoxZ.Tag)

              );
            this.buttonAddToCord.Enabled = check;
     
        }


        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void btnUTMtoGeo_Click(object sender, EventArgs e)
        {
            Cord.UTMtoGeo(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void buttonWgs84ToBGS2005Cad_Click(object sender, EventArgs e)
        {
            Cord.GeographicToLambert(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

        private void btnBGS2005CadToWGS84_Click(object sender, EventArgs e)
        {
            Cord.LambertToGeographic(CurrentCord);
            string output = Cord.printCord(CurrentCord, ";", "\r\n");
            this.textBoxMain.Text = output;
        }

     
    }
}

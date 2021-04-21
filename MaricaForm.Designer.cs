namespace Marica_Coord
{
    partial class MaricaForm
    {

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
     
            

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnToUTM = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConvert70 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUTMtoGeo = new System.Windows.Forms.Button();
            this.btnBGS2005CadToWGS84 = new System.Windows.Forms.Button();
            this.buttonBGS2005Cadto70 = new System.Windows.Forms.Button();
            this.buttonWGStoBGS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDellPosition = new System.Windows.Forms.Button();
            this.buttonDelLast = new System.Windows.Forms.Button();
            this.buttonAddToCord = new System.Windows.Forms.Button();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxJob = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Coord = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMineTo70 = new System.Windows.Forms.Button();
            this.buttonWgs84ToBGS2005Cad = new System.Windows.Forms.Button();
            this.btn70toUtm = new System.Windows.Forms.Button();
            this.btn70ToMine = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseGritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGritBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "x";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 550);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Controls.Add(this.btnToUTM);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnConvert70);
            this.tabPage1.Controls.Add(this.btnConvert);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(768, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Единични координати";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(26, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 12;
            // 
            // btnToUTM
            // 
            this.btnToUTM.Location = new System.Drawing.Point(596, 87);
            this.btnToUTM.Margin = new System.Windows.Forms.Padding(4);
            this.btnToUTM.Name = "btnToUTM";
            this.btnToUTM.Size = new System.Drawing.Size(167, 28);
            this.btnToUTM.TabIndex = 11;
            this.btnToUTM.Text = "1970 -> БГС 2005";
            this.btnToUTM.UseVisualStyleBackColor = true;
            this.btnToUTM.Click += new System.EventHandler(this.btn1970toBGS_2005_KClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Излез";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConvert70
            // 
            this.btnConvert70.Location = new System.Drawing.Point(596, 50);
            this.btnConvert70.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert70.Name = "btnConvert70";
            this.btnConvert70.Size = new System.Drawing.Size(167, 28);
            this.btnConvert70.TabIndex = 9;
            this.btnConvert70.Text = "Конвертирай в 1970 ";
            this.btnConvert70.UseVisualStyleBackColor = true;
            this.btnConvert70.Click += new System.EventHandler(this.btnConvert70_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(596, 17);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(167, 28);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Конвертирай в малки";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            this.btnConvert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 126);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 154);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Изток Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Север Х";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изток Y Autocad X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Север Х Autocad Y ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUTMtoGeo);
            this.tabPage2.Controls.Add(this.btnBGS2005CadToWGS84);
            this.tabPage2.Controls.Add(this.buttonBGS2005Cadto70);
            this.tabPage2.Controls.Add(this.buttonWGStoBGS);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonDellPosition);
            this.tabPage2.Controls.Add(this.buttonDelLast);
            this.tabPage2.Controls.Add(this.buttonAddToCord);
            this.tabPage2.Controls.Add(this.textBoxZ);
            this.tabPage2.Controls.Add(this.textBoxY);
            this.tabPage2.Controls.Add(this.textBoxX);
            this.tabPage2.Controls.Add(this.textBoxNumber);
            this.tabPage2.Controls.Add(this.btnInverse);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtBoxJob);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnMineTo70);
            this.tabPage2.Controls.Add(this.buttonWgs84ToBGS2005Cad);
            this.tabPage2.Controls.Add(this.btn70toUtm);
            this.tabPage2.Controls.Add(this.btn70ToMine);
            this.tabPage2.Controls.Add(this.buttonHelp);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.save1);
            this.tabPage2.Controls.Add(this.textBoxMain);
            this.tabPage2.Controls.Add(this.btnLoadFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(768, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Избор от файл";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUTMtoGeo
            // 
            this.btnUTMtoGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUTMtoGeo.Location = new System.Drawing.Point(399, 50);
            this.btnUTMtoGeo.Name = "btnUTMtoGeo";
            this.btnUTMtoGeo.Size = new System.Drawing.Size(84, 30);
            this.btnUTMtoGeo.TabIndex = 27;
            this.btnUTMtoGeo.Text = "DMS -> D";
            this.btnUTMtoGeo.UseVisualStyleBackColor = true;
            this.btnUTMtoGeo.Click += new System.EventHandler(this.btnUTMtoGeo_Click);
            // 
            // btnBGS2005CadToWGS84
            // 
            this.btnBGS2005CadToWGS84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBGS2005CadToWGS84.Location = new System.Drawing.Point(242, 8);
            this.btnBGS2005CadToWGS84.Name = "btnBGS2005CadToWGS84";
            this.btnBGS2005CadToWGS84.Size = new System.Drawing.Size(149, 30);
            this.btnBGS2005CadToWGS84.TabIndex = 26;
            this.btnBGS2005CadToWGS84.Text = "BGS2005Cad -> WGS84";
            this.btnBGS2005CadToWGS84.UseVisualStyleBackColor = true;
            this.btnBGS2005CadToWGS84.Click += new System.EventHandler(this.btnBGS2005CadToWGS84_Click);
            // 
            // buttonBGS2005Cadto70
            // 
            this.buttonBGS2005Cadto70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBGS2005Cadto70.Location = new System.Drawing.Point(118, 50);
            this.buttonBGS2005Cadto70.Name = "buttonBGS2005Cadto70";
            this.buttonBGS2005Cadto70.Size = new System.Drawing.Size(117, 31);
            this.buttonBGS2005Cadto70.TabIndex = 26;
            this.buttonBGS2005Cadto70.Text = "BGS2005Cad -> 70";
            this.buttonBGS2005Cadto70.UseVisualStyleBackColor = true;
            this.buttonBGS2005Cadto70.Click += new System.EventHandler(this.buttonBGS2005Cadto70_Click);
            // 
            // buttonWGStoBGS
            // 
            this.buttonWGStoBGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWGStoBGS.Location = new System.Drawing.Point(399, 7);
            this.buttonWGStoBGS.Name = "buttonWGStoBGS";
            this.buttonWGStoBGS.Size = new System.Drawing.Size(84, 31);
            this.buttonWGStoBGS.TabIndex = 25;
            this.buttonWGStoBGS.Text = "D -> DMS";
            this.buttonWGStoBGS.UseVisualStyleBackColor = true;
            this.buttonWGStoBGS.Click += new System.EventHandler(this.buttonWGStoBGS_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Номер";
            // 
            // buttonDellPosition
            // 
            this.buttonDellPosition.Location = new System.Drawing.Point(520, 225);
            this.buttonDellPosition.Name = "buttonDellPosition";
            this.buttonDellPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonDellPosition.TabIndex = 20;
            this.buttonDellPosition.Text = "Изтрии ред";
            this.buttonDellPosition.UseVisualStyleBackColor = true;
            this.buttonDellPosition.Click += new System.EventHandler(this.buttonDellPosition_Click);
            // 
            // buttonDelLast
            // 
            this.buttonDelLast.Location = new System.Drawing.Point(482, 319);
            this.buttonDelLast.Name = "buttonDelLast";
            this.buttonDelLast.Size = new System.Drawing.Size(151, 23);
            this.buttonDelLast.TabIndex = 19;
            this.buttonDelLast.Text = "Изтрии последния";
            this.buttonDelLast.UseVisualStyleBackColor = true;
            this.buttonDelLast.Click += new System.EventHandler(this.buttonDelLast_Click);
            // 
            // buttonAddToCord
            // 
            this.buttonAddToCord.Location = new System.Drawing.Point(400, 319);
            this.buttonAddToCord.Name = "buttonAddToCord";
            this.buttonAddToCord.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCord.TabIndex = 18;
            this.buttonAddToCord.Text = "Добави";
            this.buttonAddToCord.UseVisualStyleBackColor = true;
            this.buttonAddToCord.Click += new System.EventHandler(this.buttonAddToCord_Click);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(649, 278);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxZ.TabIndex = 17;
            this.textBoxZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBoxZ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(520, 278);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(113, 22);
            this.textBoxY.TabIndex = 16;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBoxY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(400, 278);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(114, 22);
            this.textBoxX.TabIndex = 15;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBoxX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(400, 225);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 14;
            this.textBoxNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(210, 106);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(88, 23);
            this.btnInverse.TabIndex = 13;
            this.btnInverse.Text = "Инверсия";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Обект";
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Location = new System.Drawing.Point(76, 148);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(290, 22);
            this.txtBoxJob.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.Delete,
            this.Coord});
            this.dataGridView1.DataSource = this.databaseGritBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 120);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Изтрии данните";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Изтрии";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Coord
            // 
            this.Coord.DataPropertyName = "Coord";
            this.Coord.HeaderText = "Зареди данните";
            this.Coord.Name = "Coord";
            this.Coord.Text = "Зареди";
            this.Coord.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(596, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Запиши в БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMineTo70
            // 
            this.btnMineTo70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMineTo70.Location = new System.Drawing.Point(9, 51);
            this.btnMineTo70.Margin = new System.Windows.Forms.Padding(4);
            this.btnMineTo70.Name = "btnMineTo70";
            this.btnMineTo70.Size = new System.Drawing.Size(101, 31);
            this.btnMineTo70.TabIndex = 8;
            this.btnMineTo70.Text = "Руднична -> 1970";
            this.btnMineTo70.UseVisualStyleBackColor = true;
            this.btnMineTo70.Click += new System.EventHandler(this.buttonToBig_Click);
            // 
            // buttonWgs84ToBGS2005Cad
            // 
            this.buttonWgs84ToBGS2005Cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWgs84ToBGS2005Cad.Location = new System.Drawing.Point(242, 51);
            this.buttonWgs84ToBGS2005Cad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWgs84ToBGS2005Cad.Name = "buttonWgs84ToBGS2005Cad";
            this.buttonWgs84ToBGS2005Cad.Size = new System.Drawing.Size(149, 29);
            this.buttonWgs84ToBGS2005Cad.TabIndex = 7;
            this.buttonWgs84ToBGS2005Cad.Text = "WGS84  -> BGS2005Cad";
            this.buttonWgs84ToBGS2005Cad.UseVisualStyleBackColor = true;
            this.buttonWgs84ToBGS2005Cad.Click += new System.EventHandler(this.buttonWgs84ToBGS2005Cad_Click);
            // 
            // btn70toUtm
            // 
            this.btn70toUtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn70toUtm.Location = new System.Drawing.Point(118, 7);
            this.btn70toUtm.Margin = new System.Windows.Forms.Padding(4);
            this.btn70toUtm.Name = "btn70toUtm";
            this.btn70toUtm.Size = new System.Drawing.Size(117, 31);
            this.btn70toUtm.TabIndex = 7;
            this.btn70toUtm.Text = "70  -> BGS2005Cad";
            this.btn70toUtm.UseVisualStyleBackColor = true;
            this.btn70toUtm.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn70ToMine
            // 
            this.btn70ToMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn70ToMine.Location = new System.Drawing.Point(8, 8);
            this.btn70ToMine.Margin = new System.Windows.Forms.Padding(4);
            this.btn70ToMine.Name = "btn70ToMine";
            this.btn70ToMine.Size = new System.Drawing.Size(102, 31);
            this.btn70ToMine.TabIndex = 7;
            this.btn70ToMine.Text = "70  -> Руднична";
            this.btn70ToMine.UseVisualStyleBackColor = true;
            this.btn70ToMine.Click += new System.EventHandler(this.btn70ToMine_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(596, 127);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(167, 28);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Помощ";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(7, 97);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "Премахни празни места";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // save1
            // 
            this.save1.BackColor = System.Drawing.Color.Gray;
            this.save1.Location = new System.Drawing.Point(596, 47);
            this.save1.Margin = new System.Windows.Forms.Padding(4);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(167, 28);
            this.save1.TabIndex = 2;
            this.save1.Text = "Запиши в Файл";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.AcceptsTab = true;
            this.textBoxMain.Location = new System.Drawing.Point(9, 177);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMain.Size = new System.Drawing.Size(357, 166);
            this.textBoxMain.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(594, 15);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(167, 28);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Избери файл";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Обект";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            // 
            // databaseGritBindingSource
            // 
            this.databaseGritBindingSource.DataSource = typeof(Marica_Coord.DatabaseGrit);
            // 
            // MaricaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 611);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(795, 483);
            this.Name = "MaricaForm";
            this.ShowInTaskbar = false;
            this.Text = "Координати Марица";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGritBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConvert70;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button btnMineTo70;
        private System.Windows.Forms.Button btn70ToMine;
        private System.Windows.Forms.Button btnToUTM;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
   
        private System.Windows.Forms.BindingSource databaseGritBindingSource;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btn70toUtm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxJob;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Coord;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonAddToCord;
        private System.Windows.Forms.Button buttonDellPosition;
        private System.Windows.Forms.Button buttonDelLast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWGStoBGS;
        private System.Windows.Forms.Button buttonBGS2005Cadto70;
        private System.Windows.Forms.Button btnUTMtoGeo;
        private System.Windows.Forms.Button btnBGS2005CadToWGS84;
        private System.Windows.Forms.Button buttonWgs84ToBGS2005Cad;
    }
}


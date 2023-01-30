using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace SQLite
{
    public partial class Form1 : Form
    {
        public SQLiteConnection myConnection;
        string connectionString = @"D:\ScoresApp\test.db3";

        public Form1()
        {
            myConnection = new SQLiteConnection(@"D:\ScoresApp\test.db3");
            
            InitializeComponent();  
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.testDataSet.Table);
            if (System.IO.File.Exists(@"D:\ScoresApp\test.db3"))
            {
                // Do nothing
            }
            else 
            {
                var db = new SQLiteConnection(@"D:\ScoresApp\test.db3");

                db.CreateTable<DBInfo>();
                db.Close();

            }
            
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DBInfo temp = new DBInfo(textBox1.Text, textBox2.Text, textBox3.Text);

            var db = new SQLiteConnection(@"D:\ScoresApp\test.db3");
            db.Insert(temp);
            db.Close();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connectionString;


            //using (SqlConnection sqlCon = new SqlConnection(connectionString)) 
            //{
            //sqlCon.Open();
            //SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * dbo.Table", sqlCon);
            //DataTable dtbl = new DataTable();
            //sqlData.Fill(dtbl);


            //dataGridView1.DataSource = dtbl;
            //}
        }

        private DataTable GetdataGridView1()
        {
            DataTable dtconnectionString = new DataTable(); 
            return dtconnectionString;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "NBAranking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

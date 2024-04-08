using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace RegiterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reg()
        {
            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string pNo = textBox3.Text;
            string email= textBox4.Text;
            string streetNo = textBox5.Text;
            string add = textBox6.Text;

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=registration";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
        }
    }
}

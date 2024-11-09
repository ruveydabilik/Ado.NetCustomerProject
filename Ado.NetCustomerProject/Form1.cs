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
using Ado.NetCustomerProject.Utilities;

namespace Ado.NetCustomerProject
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationHelper.ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connecting to database
            sqlConnection.Open();
            // Help us to execute our queries
            SqlCommand command = new SqlCommand("SELECT * FROM TblCity", sqlConnection);
            // Acts as a bridge to display data stored in memory on the screen
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // After taking the datas, fill the dataTable and supply the spurce of dataGridView that we used in the form
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            // Closing the connection
            sqlConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}

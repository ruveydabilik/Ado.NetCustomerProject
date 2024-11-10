using Ado.NetCustomerProject.Utilities;
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

namespace Ado.NetCustomerProject
{
    public partial class FrmCustomer : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationHelper.ConnectionString);
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName FROM TblCustomer INNER JOIN TblCity ON TblCity.CityId=TblCustomer.CustomerId", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}

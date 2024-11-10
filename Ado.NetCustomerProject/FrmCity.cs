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
    public partial class FrmCity : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationHelper.ConnectionString);
        public FrmCity()
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
            sqlConnection.Open();
            // In SQL, parameters are usually taken with variables defined above the @ symbol.
            SqlCommand command = new SqlCommand("INSERT INTO TblCity (CityName,CityCountry) values " +
                "(@cityName,@cityCountry)", sqlConnection);
            // The value of the parameter is given.
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            // Relevant changes are recorded in the database and it returns the number of rows affected.
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde eklendi");
            // Clear the textboxes
            txtCityName.Text = "";
            txtCityCountry.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCity Where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCityId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCity Set CityName=@cityName, CityCountry=@cityCountry Where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCityId.Text = "";
            txtCityName.Text = "";
            txtCityCountry.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCity Where CityName=@cityName", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}

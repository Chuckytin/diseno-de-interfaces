using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQL_Server_App.Model;

namespace SQL_Server_App
{
    public partial class Form1 : Form
    {

        //string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        //nombre del server (PC03 en este caso)
        string connectionString = "Data Source =PC03;" + 
            "Initial Catalog=library_mysql;" + 
           "Encrypt=False;" + 
            "Integrated Security=true";

        string sqlQuery;
        
        List<Libro> list = new List<Libro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT * FROM libros";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.ExecuteReader();
                connection.Close();
                MessageBox.Show("Conexión realizada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        private void btn_vis_Click(object sender, EventArgs e)
        {

            sqlQuery = "SELECT * FROM libros";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); // Usar ShowDialog en vez de Show para evitar errores de actualización
        }

    }
}

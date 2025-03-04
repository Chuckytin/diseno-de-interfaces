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
using Microsoft.Reporting.WinForms; // Cambiado de WebForms a WinForms
using Microsoft.ReportingServices.Interfaces;

namespace SQL_Server_App
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source =PC03;" +
            "Initial Catalog=library_mysql;" +
           "Encrypt=False;" +
            "Integrated Security=true";

        public Form2()
        {
            InitializeComponent();

            reportViewer1 = new ReportViewer(); 
            reportViewer1.Dock = DockStyle.Fill;
            Controls.Add(reportViewer1);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.EnableExternalImages = true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            try
            { 
                
                reportViewer1.LocalReport.ReportEmbeddedResource = "SQL_Server_App.ReportDefinition.Report1.rdlc";

                
                DataSet dataSet = new DataSet();

               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT title, author, price FROM libros"; // Evita SELECT *
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataSet, "DataSet1");

                }

                // Configurar la fuente de datos del reporte
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", dataSet.Tables["DataSet1"]);
                reportViewer1.LocalReport.DataSources.Add(source);

                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
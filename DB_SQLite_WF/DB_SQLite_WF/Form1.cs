using System.Data;
using System.Data.SQLite;

namespace DB_SQLite_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string db = "database_ex1.db";
            string direccion = $"Data Source = C:\\Users\\alu\\SQLite_DB\\{db}";

            // Validar que la base de datos existe antes de intentar conectar
            string fullPath = Path.Combine("C:\\Users\\alu\\SQLite_DB", $"{db}");
            if (!File.Exists(fullPath))
            {
                MessageBox.Show($"La base de datos no existe en el camino especificado: {fullPath}");
                return;
            }

            // Usar bloques using para manejar recursos automáticamente
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(direccion))
                {
                    string query = "SELECT * FROM SampleTable";

                    // Verificar si la tabla existe antes de consultarla
                    using (SQLiteCommand cmdCheck = new SQLiteCommand(
                        "SELECT name FROM sqlite_master WHERE type='table' AND name='SampleTable'", conn))
                    {
                        conn.Open();
                        object result = cmdCheck.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("La tabla 'SampleTable' no existe en la base de datos.");
                            return;
                        }
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Crear DataTable y llenarlo con los datos
                        DataTable dt = new DataTable();

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);

                            // Actualizar el DataGridView solo si hay datos
                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros en la tabla.");
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error SQLite: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
            }
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            string db = "database_ex1.db";
            string direccion = $"Data Source = C:\\Users\\alu\\SQLite_DB\\{db}";

            SQLiteConnection conn = new SQLiteConnection(direccion);

            string query = "SELECT * FROM SampleTable";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //para llenar el datatable
            DataTable dt = new DataTable();

            //Adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //recibe el command
            adapter.Fill(dt); //recibe el datatable

            //Enlace datable al Data Grid View
            dataGridView1.DataSource = dt;

        }

        */

    }


}

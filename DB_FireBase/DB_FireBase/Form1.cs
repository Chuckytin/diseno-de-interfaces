using System.Data;
using System.Diagnostics;
using DB_FireBase.Modelo;
using DB_FireBase.Servicio;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB_FireBase
{
    public partial class Form1 : Form
    {

        private FirebaseClient client;

        private IFirebaseConfig config;

        DataTable dt = new DataTable();

        Form3 mWin = null;

        public Form1()
        {
            InitializeComponent();

            config = new FirebaseConfig
            {
                AuthSecret = "DHO5fzHVAPyIkBEr72RLdolytS7PIBvIPdiFRgNj", //secretos de la base de datos
                BasePath = "https://db-firebase-21769-default-rtdb.europe-west1.firebasedatabase.app/"
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Print("Prueba de conexión con Firebase");

            try
            {
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                    MessageBox.Show("Conexión establecida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la conexión: {ex.Message}");
                throw;
            }

            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Age");

            dataGridView1.DataSource = dt;

        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {
                /*var data = new Data
                {
                    Id = text_id.Text,
                    Name = text_name.Text,
                    Address = text_address.Text,
                    Age = text_age.Text,
                };

                SetResponse setResponse = await client.SetTaskAsync(
                    "Info/" + text_id.Text, data);
                
                Data result = setResponse.ResultAs<Data>();

                MessageBox.Show("Datos insertados correctamente con ID: " + result.Id);
                */

                //para seguir el conteo:
                FirebaseResponse firebaseResponse = await client.GetTaskAsync("Contador/Node");
                Counter counter = firebaseResponse.ResultAs<Counter>();

                //Auto_Increment
                var data = new Data
                {
                    Id = ((Convert.ToInt32(counter.counter)) + 1).ToString(),
                    Name = text_name.Text,
                    Address = text_address.Text,
                    Age = text_age.Text,
                };

                SetResponse setResponse = await client.SetTaskAsync(
                    "Info/" + text_id.Text, data);

                Data result = setResponse.ResultAs<Data>();

                MessageBox.Show("Datos insertados correctamente con ID: " + result.Id);

                var obj = new Counter
                {
                    counter = data.Id
                };

                SetResponse setResponse1 = await client.SetTaskAsync(
                    "Contador/Node", obj);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar datos: {ex.Message}");
            }

        }



        private async Task bringData()
        {
            try
            {
                dt.Rows.Clear(); // Limpiar la tabla antes de añadir nuevos datos

                // Obtiene el contador correcto desde "Contador/Node/counter"
                FirebaseResponse response = await client.GetTaskAsync("Contador/Node");

                if (response.Body == "null" || string.IsNullOrEmpty(response.Body))
                {
                    //MessageBox.Show("Error: No se encontró el contador.");
                    return;
                }

                // Extrae el número de registros
                Counter obj1 = response.ResultAs<Counter>();

                if (obj1 == null || string.IsNullOrEmpty(obj1.counter))
                {
                    MessageBox.Show("Error: El contador es nulo o inválido.");
                    return;
                }

                int cont = Convert.ToInt32(obj1.counter);

                // Recorre los datos en "Info"
                for (int i = 1; i <= cont; i++)
                {
                    try
                    {
                        FirebaseResponse response1 = await client.GetTaskAsync("Info/" + i);


                        if (response1.Body == "null" || string.IsNullOrEmpty(response1.Body))
                        {
                            //MessageBox.Show($"No hay datos para el ID {i}");
                            continue;
                        }


                        // Convierte la respuesta a un objeto Data
                        Data obj2 = response1.ResultAs<Data>();

                        if (obj2 == null)
                        {
                            MessageBox.Show($"Error: Objeto nulo para el ID {i}. Respuesta: {response1.Body}");
                            continue;
                        }

                        // Agrega los datos a la tabla
                        dt.Rows.Add(obj2.Id, obj2.Name, obj2.Address, obj2.Age);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener datos para el ID {i}: {ex.Message}");
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Información transferida con éxito!");
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico: {ex.Message}");
            }
        }


        private async void btn_visual_Click(object sender, EventArgs e)
        {
            await bringData();
        }

        private async void btn_get_Click(object sender, EventArgs e)
        {

            FirebaseResponse response = await client.GetTaskAsync(
                "Info/" + text_id.Text);

            Data obj = response.ResultAs<Data>();
            text_id.Text = obj.Id;
            text_name.Text = obj.Name;
            text_address.Text = obj.Address;
            text_age.Text = obj.Age;

            MessageBox.Show("Información recuperada con éxito.");

        }



        private async void btn_update_Click(object sender, EventArgs e)
        {

            var data = new Data
            {
                Id = text_id.Text,
                Name = text_name.Text,
                Address = text_address.Text,
                Age = text_age.Text,
            };

            FirebaseResponse response = await client.UpdateTaskAsync(
                "Info/" + text_id.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Datos actualizados con el ID: " + result.Id);

            btn_update.Enabled = false;

            bringData();

        }

        private async void btn_delete_ClickAsync(object sender, EventArgs e)
        {

            FirebaseResponse response = await client.DeleteTaskAsync("Info/" + text_id.Text);

            MessageBox.Show("Información del Id " + text_id.Text + " eliminada.");

            //bringData();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "¿Estás seguro que deseas eliminar todo?",
                "ATENCIÓN!", MessageBoxButtons.YesNo);


            //else if (dialogResult == DialogResult.No)

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            mWin.Show();
        }
    }
}

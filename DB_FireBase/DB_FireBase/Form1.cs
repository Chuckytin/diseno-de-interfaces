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
            }

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
    }
}

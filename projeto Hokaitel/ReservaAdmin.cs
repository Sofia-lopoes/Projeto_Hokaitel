using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Hokaitel
{
    public partial class ReservaAdmin : Form
    {
        public ReservaAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtendo os dados do formulário
            string nome = inputNome.Text;
            int numeroQuarto = int.Parse(inputQuarto.Text);
            string telefone = inputTelefone.Text;
            string email = inputEmail.Text;

            
            using (MySqlConnection con = new MySqlConnection("server=Localhost;userid=root;password=;database=BD_Hokaitel"))
            {
                try
                {
                    con.Open(); 

                    
                    string query = "INSERT INTO Reservas (ClienteID, QuartoID, DataCheckIn, StatusReserva) VALUES (@ClienteID, @QuartoID, NOW(), 'Em Andamento');";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                 
                    cmd.Parameters.AddWithValue("@ClienteID", 1); 
                    cmd.Parameters.AddWithValue("@QuartoID", numeroQuarto); 

                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reserva inserida com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir reserva: " + ex.Message);
                }
            }

        }
    }
}

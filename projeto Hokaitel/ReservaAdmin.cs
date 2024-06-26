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
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace projeto_Hokaitel
{
    public partial class ReservaAdmin : Form
    {
        private string connectionString = "server=localhost;userid=root;password=;database=BD_Hokaitel";

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
            // Validar entrada antes de prosseguir
            if (string.IsNullOrWhiteSpace(inputNome.Text) || string.IsNullOrWhiteSpace(inputQuarto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos necessários.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nome = inputNome.Text;
            int numeroQuarto;
            if (!int.TryParse(inputQuarto.Text, out numeroQuarto))
            {
                MessageBox.Show("Número do quarto inválido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefone = inputTelefone.Text;
            string email = inputEmail.Text;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Reservas (ClienteID, QuartoID, DataCheckIn, StatusReserva) VALUES (@ClienteID, @QuartoID, NOW(), 'Em Andamento')";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ClienteID", 1); // Ajuste conforme sua lógica para obter o ClienteID
                    cmd.Parameters.AddWithValue("@QuartoID", numeroQuarto);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reserva inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir reserva: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
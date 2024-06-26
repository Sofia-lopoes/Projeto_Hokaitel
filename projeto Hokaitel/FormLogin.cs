using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace projeto_Hokaitel
{
    public partial class FormLogin : Form
    {
        // String de conexão com o banco de dados MySQL
        private string connectionString = "Server=Localhost;Database=teste;Uid=root;Pwd=;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnentrar1_Click(object sender, EventArgs e)
        {
            string email = inputUser.Text.Trim();
            string senha = inputSenha.Text.Trim();

            string query = "SELECT COUNT(*) FROM Funcionario WHERE Email = @Email AND SENHA = @Senha";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Login bem-sucedido
                            MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMenu formMenu1 = new FormMenu();
                            formMenu1.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Login ou senha inválidos
                            MessageBox.Show("Login ou senha inválidos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void inputUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

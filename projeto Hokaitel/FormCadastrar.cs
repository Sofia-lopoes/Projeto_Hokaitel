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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if (textNome.Text == "Nome")
            {
                textNome.Text = "";
                textNome.ForeColor = Color.LightGray;

            }
        }
        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNome.Text == null)
            {
                textNome.Text = "Usuario";
                textNome.ForeColor = Color.DimGray;
            }

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.LightGray;
            }
        }
        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == null)
            {
                textEmail.Text = "Usuario";
                textEmail.ForeColor = Color.DimGray;
            }

        }

        private void textCPF_TextChanged(object sender, EventArgs e)
        {
            if (textCPF.Text == "CPF")
            {
                textCPF.Text = "";
                textCPF.ForeColor = Color.LightGray;
            }
        }
        private void textCPF_Leave(object sender, EventArgs e)
        {
            if (textCPF.Text == null)
            {
                textCPF.Text = "Usuario";
                textCPF.ForeColor = Color.DimGray;
            }
        }

        private void textSetor_TextChanged(object sender, EventArgs e)
        {
            if (textSetor.Text == "Setro")
            {
                textSetor.Text = "";
                textSetor.ForeColor = Color.LightGray;
            }
        }
        private void textSetor_Leave(object sender, EventArgs e)
        {
            if (textSetor.Text == null)
            {
                textSetor.Text = "Usuario";
                textSetor.ForeColor = Color.DimGray;
            }

        }


        private void textSenha_TextChanged(object sender, EventArgs e)
        {

            if (textSenha.Text == "Senha")
            {
                textSenha.Text = "";
                textSenha.ForeColor = Color.LightGray;
                textSenha.UseSystemPasswordChar = true;
            }
        }
        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == "")
            {
                textSenha.Text = "Senha";
                textSenha.ForeColor = Color.DimGray;
                textSenha.UseSystemPasswordChar = false;
            }
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {

            if (count > 0)
            {
                FormLogin formLogin1 = new FormLogin();
                formLogin1.Show();
                this.Hide();
            }

        }
    }
}
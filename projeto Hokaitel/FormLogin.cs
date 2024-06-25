using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace projeto_Hokaitel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wmsg, int wparam, int lparam);
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textuser1_Enter(object sender, EventArgs e)
        {

                inputUser.ForeColor = Color.LightGray;

            
        }

        private void textuser1_Leave(object sender, EventArgs e)
        {

                inputUser.ForeColor = Color.DimGray;


            

        }

        private void textsenha1_Enter(object sender, EventArgs e)
        {
            

                inputSenha.ForeColor = Color.LightGray;
                inputSenha.UseSystemPasswordChar = true;
            
        }

        private void textsenha1_Leave(object sender, EventArgs e)
        {


                inputSenha.ForeColor = Color.DimGray;
                inputSenha.UseSystemPasswordChar = false;
            
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnentrar1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu1 = new FormMenu();
            formMenu1.ShowDialog();
        }

        private void linkpass1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastrar formCadastrar = new FormCadastrar();
            formCadastrar.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textuser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(inputSenha.PasswordChar == '\0')
            {
                inputSenha.PasswordChar = '*';
            } else
            {
                inputSenha.PasswordChar = '\0';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            inputUser.Text = "Usuário";
            inputSenha.Text = "Senha";
            inputSenha.PasswordChar = '\0';
        }

        private void textsenha1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

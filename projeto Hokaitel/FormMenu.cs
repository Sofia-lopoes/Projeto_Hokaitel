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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Horafechada_Tick(object sender, EventArgs e)
        {
            bntHora.Text = DateTime.Now.ToString("hh:mm:ss");
            bntData.Text = DateTime.Now.ToLongDateString();
        }

        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnreservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckinout menu = new FormCheckinout();
            menu.Show();
        }

        private void btnrelatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRelatoris menu = new FormRelatoris();
            menu.Show();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastrar menu = new FormCadastrar();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRelatoris menu = new FormRelatoris();
            menu.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

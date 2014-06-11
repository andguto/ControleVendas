using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendasDAL;
using ControleVendasDAL.Classes;
using ControleVendas.Forms;

namespace ControleVendas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UsersDAL clsUsersDAL = new UsersDAL();
            clsUsersDAL.GetUserByName(this.textBoxUser.Text, this.textBoxPassword.Text);
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ConnectionDAL clsConnectionDAL = new ConnectionDAL();
            clsConnectionDAL.DesconectarBanco();
            Application.Exit();
        }
    }
}

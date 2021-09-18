using Gerenciamento_de_débitos;
using Gerenciamento_de_débitos.Api;
using Gerenciamento_de_débitos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_débitos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ttbEmailLogin.TextLength > 0 && ttbEmailLogin.Text.Contains("@") && ttbEmailLogin.Text.Contains(".") && ttbSenhaLogin.TextLength > 0)
            {
                WebApi api = new WebApi();
                Dictionary<string, string> pairValues = new Dictionary<string, string>();
                pairValues.Add("email", ttbEmailLogin.Text);
                pairValues.Add("senha", ttbSenhaLogin.Text);
                Validado auth = api.ValidarUsuario(pairValues, "Login/Logar");
                if (auth.Icon == "success")
                {
                    MessageBox.Show(auth.Message);
                    this.Hide();
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.Show();
                }
                else
                {
                    MessageBox.Show(auth.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos Invalidos!");
            }
        }

        private void limparCamposRegistrar()
        {
            ttbEmailRegistrar.Text = "";
            ttbSenhaRegistrar.Text = "";
            ttbNomeRegistrar.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ttbEmailRegistrar.TextLength > 0 && ttbEmailRegistrar.Text.Contains("@") && ttbEmailRegistrar.Text.Contains(".") && ttbSenhaRegistrar.TextLength > 0 && ttbNomeRegistrar.TextLength > 0)
            {
                WebApi api = new WebApi();
                Dictionary<string, string> pairValues = new Dictionary<string, string>();
                pairValues.Add("nome", ttbNomeRegistrar.Text);
                pairValues.Add("email", ttbEmailRegistrar.Text);
                pairValues.Add("senha", ttbSenhaRegistrar.Text);
                Validado auth = api.ValidarUsuario(pairValues, "Login/Registrar");
                if (auth.Icon == "success")
                {
                    MessageBox.Show(auth.Message);
                    this.limparCamposRegistrar();
                    tabPrincipal.SelectedTab = tabPrincipal.TabPages[0];
                }
                else
                {
                    MessageBox.Show(auth.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos Invalidos!");
            }
        }
    }
}

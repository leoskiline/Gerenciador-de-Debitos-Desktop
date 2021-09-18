using Gerenciamento_de_débitos.Api;
using Gerenciamento_de_débitos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_débitos
{
    public partial class GerenciarDebitos : Form
    {
        public GerenciarDebitos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ttbDescricaoConta.Text) && dtpCobranca.Value.Date >= DateTime.Now.Date && (Convert.ToDouble(mtbValor.Text) > 0))
            {
                WebApi api = new WebApi();
                Dictionary<string, string> pairValues = new Dictionary<string, string>();
                pairValues.Add("descricao",ttbDescricaoConta.Text);
                pairValues.Add("valor",mtbValor.Text);
                pairValues.Add("data", dtpCobranca.Value.Date.ToString());
                Validado valida = api.ValidarCadastroDebito(pairValues, "Debito/CadastrarConta");
                if (valida.Icon == "success")
                {
                    MessageBox.Show(valida.Message);
                }
                else
                {
                    MessageBox.Show(valida.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos de Cadastro.");
            }
        }
    }
}

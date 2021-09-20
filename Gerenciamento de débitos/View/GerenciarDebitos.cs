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

            PnlData.Enabled = false;
            PnlDescricao.Enabled = false;
            PnlValor.Enabled = false;


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ttbDescricaoConta.Text) && dtpCobranca.Value.Date >= DateTime.Now.Date && (Convert.ToDouble(mtbValor.Text) > 0))
            {
                WebApi api = new WebApi();
                Dictionary<string, string> pairValues = new Dictionary<string, string>();
                pairValues.Add("descricao", ttbDescricaoConta.Text);
                pairValues.Add("valor", mtbValor.Text);
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
        private void GerenciarDebitos_Load()
        {

        }

        private void GerenciarDebitos_Load(object sender, EventArgs e)
        {
            DataTable Lista = new DataTable();
        }

        private void AtivarPaineis(Panel ativo, Panel inativo1, Panel inativo2)
        {
            ativo.Enabled = true;
            inativo1.Enabled = false;
            inativo2.Enabled = false;
        }

        private void CbxPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////buscar dados

            if (CbxPesquisa.SelectedIndex == 0)
            {
                AtivarPaineis(PnlDescricao, PnlValor, PnlData);

            }
            else if (CbxPesquisa.SelectedIndex == 1)
            {
                AtivarPaineis(PnlValor, PnlData, PnlDescricao);


            }
            else if (CbxPesquisa.SelectedIndex == 2)
            {
                AtivarPaineis(PnlData, PnlDescricao, PnlValor);


            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            WebApi api = new WebApi();
            Dictionary<string, string> pairValues = new Dictionary<string, string>();
            pairValues.Add("fdescricao", "Ola descricao teste");
            pairValues.Add("fvalor", "12");
            pairValues.Add("fdata", dtpCobranca.Value.Date.ToString());
            IList<DebitoModel> valida = api.ObterDebitos(pairValues, "Debito/filtrarDebitos");
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
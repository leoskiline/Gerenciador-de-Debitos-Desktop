using Gerenciamento_de_débitos.Api;
using Gerenciamento_de_débitos.Model;
using Gerenciamento_de_débitos.View;
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
        private WebApi api = new WebApi();
        public GerenciarDebitos()
        {
            InitializeComponent();

            PnlData.Enabled = false;
            PnlDescricao.Enabled = false;
            PnlValor.Enabled = false;

            //dgvDebitos.DataSource = api.ObterDebitos();
        }

        public void Cadastrar(string descricao, DateTime data, double valor)
        {
            Dictionary<string, string> pairValues = new Dictionary<string, string>();
            pairValues.Add("descricao", descricao);
            pairValues.Add("valor", valor.ToString());
            pairValues.Add("data", data.ToString());
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(mtbValor.Text);
                if (!string.IsNullOrEmpty(ttbDescricaoConta.Text) && dtpCobranca.Value.Date >= DateTime.Now.Date && valor > 0)
                {
                    Cadastrar(ttbDescricaoConta.Text, dtpCobranca.Value.Date, valor);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos de Cadastro.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            else
            {
                AtivarPaineis(PnlData, PnlDescricao, PnlValor);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            WebApi api = new WebApi();
            Dictionary<string, string> pairValues = new Dictionary<string, string>();
            pairValues.Add("fdescricao", "");
            pairValues.Add("fvalor", "12");
            pairValues.Add("fdata", dtpCobranca.Value.Date.ToString());
            IList<DebitoModel> valida = api.ObterDebitos(pairValues, "Debito/obterDebitos");
       
        }

        private void dgvDebitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // clicou no botão Editar
            {
                AlterarDebitos formAlterar = new AlterarDebitos(this);
                formAlterar.ttbDescricaoConta.Text = dgvDebitos.SelectedRows[e.RowIndex].Cells[0].Value.ToString();
                formAlterar.dtpCobranca.Value = Convert.ToDateTime(dgvDebitos.SelectedRows[e.RowIndex].Cells[1].Value);
                formAlterar.mtbValor.Text = dgvDebitos.SelectedRows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Não");
            }
        }
    }
}
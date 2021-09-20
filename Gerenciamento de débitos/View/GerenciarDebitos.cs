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

        List<DebitoModel> debitos;

        public GerenciarDebitos()
        {
            InitializeComponent();

            PnlData.Visible = false;
            PnlDescricao.Visible = false;
            PnlValor.Visible = false;

            debitos = api.ObterDebitos("Debito/obterDebitos");

            MontarDgvDebitos();
        }

        private void MontarDgvDebitos()
        {
            if (dgvDebitos.Rows.Count > 0)
            {
                dgvDebitos.DataSource = null;
                dgvDebitos.Rows.Clear();
            }
            else
            {
                if (debitos.Count > 0)
                {
                    DataTable dtDebitos = new DataTable();

                    dtDebitos.Columns.Add("ID");
                    dtDebitos.Columns.Add("Descrição");
                    dtDebitos.Columns.Add("Data");
                    dtDebitos.Columns.Add("Valor");

                    foreach (var item in debitos)
                    {
                        DataRow linha = dtDebitos.NewRow();
                        linha[0] = item.IdDebito;
                        linha[1] = item.Descricao;
                        linha[2] = item.Data;
                        linha[3] = item.Valor;
                        dtDebitos.Rows.Add(linha);
                    }

                    dgvDebitos.DataSource = dtDebitos;

                    DataGridViewButtonColumn btnAlterar = new();
                    DataGridViewButtonColumn btnExcluir = new();

                    btnAlterar.Text = "Alterar";
                    btnExcluir.Text = "Excluir";
                    btnAlterar.HeaderText = "Alterar";
                    btnExcluir.HeaderText = "Alterar";
                    btnExcluir.UseColumnTextForButtonValue = true;
                    btnAlterar.UseColumnTextForButtonValue = true;

                    dgvDebitos.Columns.Add(btnAlterar);
                    dgvDebitos.Columns.Add(btnExcluir);

                    dgvDebitos.Columns[0].Width = 40;
                    dgvDebitos.Columns[1].Width = 425;
                    dgvDebitos.Columns[2].Width = 180;
                    dgvDebitos.Columns[3].Width = 180;
                    dgvDebitos.Columns[4].Width = 100;
                    dgvDebitos.Columns[5].Width = 100;
                }
                
            }
        }

        public void Alterar(int id, string descricao, DateTime data, double valor)
        {
            DebitoModel debitoModel = new DebitoModel(id, descricao, data, valor * 10);
            Validado valida = api.AlterarDebito(debitoModel, "Debito/AlterarDados");
            if (valida.Icon == "success")
            {
                MessageBox.Show(valida.Message);
                debitos = api.ObterDebitos("Debito/obterDebitos");
            }
            else
            {
                MessageBox.Show(valida.Message);
            }
        }

        public void Excluir(int id)
        {
            DebitoModel debitoModel = new DebitoModel(id);
            Validado valida = api.ExcluirDebito(debitoModel, "Debito/Deletar");
            if (valida.Icon == "success")
            {
                MessageBox.Show(valida.Message);
                debitos = api.ObterDebitos("Debito/obterDebitos");
            }
            else
            {
                MessageBox.Show(valida.Message);
            }
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
                debitos = api.ObterDebitos("Debito/obterDebitos");
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

        private void AtivarPaineis(Panel ativo, Panel inativo1, Panel inativo2)
        {
            ativo.Visible = true;
            inativo1.Visible = false;
            inativo2.Visible = false;
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
            //Validado valida = api.FiltrarDebito($"Debito/filtrarDebitos?fdescricao={ttbDescricaoConta}&fvalor={valor}&fdata={data}");
            //if (valida.Icon == "success")
            //{
            //    MessageBox.Show(valida.Message);
            //    debitos = api.ObterDebitos("Debito/obterDebitos");
            //}
            //else
            //{
            //    MessageBox.Show(valida.Message);
            //}
        }

        private void dgvDebitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // clicou no botão Editar
            {
                AlterarDebitos formAlterar = new AlterarDebitos(this);
                formAlterar.ttbDescricaoConta.Text = dgvDebitos.CurrentRow.Cells[3].Value.ToString();
                formAlterar.dtpCobranca.Value = Convert.ToDateTime(dgvDebitos.CurrentRow.Cells[4].Value);
                formAlterar.mtbValor.Text = dgvDebitos.CurrentRow.Cells[5].Value.ToString();
                formAlterar.Show();
            }
            else if (e.ColumnIndex == 1) // clicou no botão Excluir
            {
                Excluir(Convert.ToInt32(dgvDebitos.CurrentRow.Cells[2].Value));
                MontarDgvDebitos();
            }
        }
    }
}
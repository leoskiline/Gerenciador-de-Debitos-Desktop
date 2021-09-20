using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_débitos.View
{
    public partial class AlterarDebitos : Form
    {
        private GerenciarDebitos _formGerenciarDebitos;

        public AlterarDebitos(GerenciarDebitos gerenciar)
        {
            InitializeComponent();
            _formGerenciarDebitos = gerenciar;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _formGerenciarDebitos.Alterar(
                                            Convert.ToInt32(_formGerenciarDebitos.dgvDebitos.CurrentRow.Cells[2].Value),
                                            ttbDescricaoConta.Text,
                                            dtpCobranca.Value.Date,
                                            Convert.ToDouble(mtbValor.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

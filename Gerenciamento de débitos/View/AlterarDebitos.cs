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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                _formGerenciarDebitos.Cadastrar(ttbDescricaoConta.Text,
                                            dtpCobranca.Value.Date,
                                            Convert.ToDouble(mtbValor.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

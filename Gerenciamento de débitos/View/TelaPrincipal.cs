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
    public partial class TelaPrincipal : Form
    {
        private Form activeForm;

        public Form formAtivo { get => activeForm; set => activeForm = value; }

        public TelaPrincipal()
        {
            InitializeComponent();
            btnFecharForm.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            btnFecharForm.Visible = true;
            lblTitle.Text = "Gerenciador de Débitos";
        }

        private void btnGerenciarDebitos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GerenciarDebitos());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelDesktopPanel.Controls.Clear();
            }
            Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "Home";
            btnFecharForm.Visible = false;
        }
    }
}

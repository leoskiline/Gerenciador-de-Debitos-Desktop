
namespace Gerenciamento_de_débitos
{
    partial class GerenciarDebitos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.dtpCobranca = new System.Windows.Forms.DateTimePicker();
            this.ttbDescricaoConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.PnlValor = new System.Windows.Forms.Panel();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PnlDescricao = new System.Windows.Forms.Panel();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlData = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDebito = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxPesquisa = new System.Windows.Forms.ComboBox();
            this.dgvDebitos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnlValor.SuspendLayout();
            this.PnlDescricao.SuspendLayout();
            this.PnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.mtbValor);
            this.panel1.Controls.Add(this.dtpCobranca);
            this.panel1.Controls.Add(this.ttbDescricaoConta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(983, 180);
            this.panel1.TabIndex = 0;
            // 
            // mtbValor
            // 
            this.mtbValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbValor.Location = new System.Drawing.Point(656, 101);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(167, 23);
            this.mtbValor.TabIndex = 7;
            // 
            // dtpCobranca
            // 
            this.dtpCobranca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCobranca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCobranca.Location = new System.Drawing.Point(492, 101);
            this.dtpCobranca.Name = "dtpCobranca";
            this.dtpCobranca.Size = new System.Drawing.Size(145, 23);
            this.dtpCobranca.TabIndex = 6;
            // 
            // ttbDescricaoConta
            // 
            this.ttbDescricaoConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ttbDescricaoConta.Location = new System.Drawing.Point(160, 101);
            this.ttbDescricaoConta.Name = "ttbDescricaoConta";
            this.ttbDescricaoConta.Size = new System.Drawing.Size(304, 23);
            this.ttbDescricaoConta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Cobranca";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descricao da Conta";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(727, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 33);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(104)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 51);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CONTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Controls.Add(this.PnlValor);
            this.panel3.Controls.Add(this.PnlDescricao);
            this.panel3.Controls.Add(this.PnlData);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.CbxPesquisa);
            this.panel3.Controls.Add(this.dgvDebitos);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-1, 185);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(983, 381);
            this.panel3.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisar.Location = new System.Drawing.Point(213, 126);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 32);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // PnlValor
            // 
            this.PnlValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlValor.Controls.Add(this.tbValor);
            this.PnlValor.Controls.Add(this.label9);
            this.PnlValor.Location = new System.Drawing.Point(611, 72);
            this.PnlValor.Name = "PnlValor";
            this.PnlValor.Size = new System.Drawing.Size(220, 40);
            this.PnlValor.TabIndex = 6;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(54, 8);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(163, 23);
            this.tbValor.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Valor";
            // 
            // PnlDescricao
            // 
            this.PnlDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlDescricao.Controls.Add(this.tbDescricao);
            this.PnlDescricao.Controls.Add(this.label8);
            this.PnlDescricao.Location = new System.Drawing.Point(402, 118);
            this.PnlDescricao.Name = "PnlDescricao";
            this.PnlDescricao.Size = new System.Drawing.Size(429, 40);
            this.PnlDescricao.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(80, 6);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(346, 23);
            this.tbDescricao.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descrição";
            // 
            // PnlData
            // 
            this.PnlData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlData.Controls.Add(this.label7);
            this.PnlData.Controls.Add(this.dtpDebito);
            this.PnlData.Location = new System.Drawing.Point(402, 72);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(203, 40);
            this.PnlData.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data";
            // 
            // dtpDebito
            // 
            this.dtpDebito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebito.Location = new System.Drawing.Point(52, 8);
            this.dtpDebito.Name = "dtpDebito";
            this.dtpDebito.Size = new System.Drawing.Size(139, 23);
            this.dtpDebito.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pesquisar por";
            // 
            // CbxPesquisa
            // 
            this.CbxPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxPesquisa.FormattingEnabled = true;
            this.CbxPesquisa.Items.AddRange(new object[] {
            "Descricao",
            "Valor",
            "Data"});
            this.CbxPesquisa.Location = new System.Drawing.Point(164, 78);
            this.CbxPesquisa.Name = "CbxPesquisa";
            this.CbxPesquisa.Size = new System.Drawing.Size(148, 23);
            this.CbxPesquisa.TabIndex = 2;
            this.CbxPesquisa.SelectedIndexChanged += new System.EventHandler(this.CbxPesquisa_SelectedIndexChanged);
            // 
            // dgvDebitos
            // 
            this.dgvDebitos.AllowUserToDeleteRows = false;
            this.dgvDebitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDebitos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgvDebitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDebitos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dgvDebitos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDebitos.Location = new System.Drawing.Point(5, 164);
            this.dgvDebitos.Name = "dgvDebitos";
            this.dgvDebitos.ReadOnly = true;
            this.dgvDebitos.RowHeadersVisible = false;
            this.dgvDebitos.RowTemplate.Height = 25;
            this.dgvDebitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebitos.Size = new System.Drawing.Size(973, 212);
            this.dgvDebitos.TabIndex = 1;
            this.dgvDebitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitos_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(104)))), ((int)(((byte)(244)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(973, 51);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "CONTAS CADASTRADAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Descricao";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 400;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 186;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 186;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "(none)";
            this.Column4.HeaderText = "Excluir";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "Excluir";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Editar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Editar";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // GerenciarDebitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "GerenciarDebitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarDebitos";
            this.Load += new System.EventHandler(this.GerenciarDebitos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnlValor.ResumeLayout(false);
            this.PnlValor.PerformLayout();
            this.PnlDescricao.ResumeLayout(false);
            this.PnlDescricao.PerformLayout();
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpCobranca;
        private System.Windows.Forms.TextBox ttbDescricaoConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.DataGridView dgvDebitos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxPesquisa;
        private System.Windows.Forms.Panel PnlDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDebito;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Panel PnlValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}
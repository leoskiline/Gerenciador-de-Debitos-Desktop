
namespace Gerenciamento_de_débitos
{
    partial class Login
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ttbEmailLogin = new System.Windows.Forms.TextBox();
            this.ttbSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbSenhaRegistrar = new System.Windows.Forms.TextBox();
            this.ttbEmailRegistrar = new System.Windows.Forms.TextBox();
            this.ttbNomeRegistrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabLogin);
            this.tabPrincipal.Controls.Add(this.tabRegistrar);
            this.tabPrincipal.ItemSize = new System.Drawing.Size(264, 30);
            this.tabPrincipal.Location = new System.Drawing.Point(-2, -2);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(531, 285);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.ttbEmailLogin);
            this.tabLogin.Controls.Add(this.ttbSenhaLogin);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Location = new System.Drawing.Point(4, 34);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(523, 247);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(218, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ttbEmailLogin
            // 
            this.ttbEmailLogin.Location = new System.Drawing.Point(198, 62);
            this.ttbEmailLogin.Name = "ttbEmailLogin";
            this.ttbEmailLogin.Size = new System.Drawing.Size(148, 23);
            this.ttbEmailLogin.TabIndex = 1;
            // 
            // ttbSenhaLogin
            // 
            this.ttbSenhaLogin.Location = new System.Drawing.Point(198, 130);
            this.ttbSenhaLogin.Name = "ttbSenhaLogin";
            this.ttbSenhaLogin.Size = new System.Drawing.Size(148, 23);
            this.ttbSenhaLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.btnRegistrar);
            this.tabRegistrar.Controls.Add(this.label5);
            this.tabRegistrar.Controls.Add(this.ttbSenhaRegistrar);
            this.tabRegistrar.Controls.Add(this.ttbEmailRegistrar);
            this.tabRegistrar.Controls.Add(this.ttbNomeRegistrar);
            this.tabRegistrar.Controls.Add(this.label4);
            this.tabRegistrar.Controls.Add(this.label3);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 34);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(523, 247);
            this.tabRegistrar.TabIndex = 1;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(218, 213);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 29);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(227, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha";
            // 
            // ttbSenhaRegistrar
            // 
            this.ttbSenhaRegistrar.Location = new System.Drawing.Point(196, 169);
            this.ttbSenhaRegistrar.Name = "ttbSenhaRegistrar";
            this.ttbSenhaRegistrar.Size = new System.Drawing.Size(148, 23);
            this.ttbSenhaRegistrar.TabIndex = 5;
            // 
            // ttbEmailRegistrar
            // 
            this.ttbEmailRegistrar.Location = new System.Drawing.Point(196, 105);
            this.ttbEmailRegistrar.Name = "ttbEmailRegistrar";
            this.ttbEmailRegistrar.Size = new System.Drawing.Size(148, 23);
            this.ttbEmailRegistrar.TabIndex = 4;
            // 
            // ttbNomeRegistrar
            // 
            this.ttbNomeRegistrar.Location = new System.Drawing.Point(196, 41);
            this.ttbNomeRegistrar.Name = "ttbNomeRegistrar";
            this.ttbNomeRegistrar.Size = new System.Drawing.Size(148, 23);
            this.ttbNomeRegistrar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(227, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(227, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(529, 286);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabPrincipal.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox ttbEmailLogin;
        private System.Windows.Forms.TextBox ttbSenhaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbSenhaRegistrar;
        private System.Windows.Forms.TextBox ttbEmailRegistrar;
        private System.Windows.Forms.TextBox ttbNomeRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
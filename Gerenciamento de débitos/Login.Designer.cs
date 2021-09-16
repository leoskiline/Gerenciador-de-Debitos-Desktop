
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ttbEmailLogin = new System.Windows.Forms.TextBox();
            this.ttbSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbNomeRegistrar = new System.Windows.Forms.TextBox();
            this.ttbEmailRegistrar = new System.Windows.Forms.TextBox();
            this.ttbSenhaRegistrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegistrar);
            this.tabControl1.ItemSize = new System.Drawing.Size(264, 30);
            this.tabControl1.Location = new System.Drawing.Point(-2, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 380);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.ttbEmailLogin);
            this.tabLogin.Controls.Add(this.ttbSenhaLogin);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Location = new System.Drawing.Point(4, 34);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogin.Size = new System.Drawing.Size(523, 342);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(191, 239);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ttbEmailLogin
            // 
            this.ttbEmailLogin.Location = new System.Drawing.Point(168, 87);
            this.ttbEmailLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbEmailLogin.Name = "ttbEmailLogin";
            this.ttbEmailLogin.Size = new System.Drawing.Size(169, 27);
            this.ttbEmailLogin.TabIndex = 1;
            // 
            // ttbSenhaLogin
            // 
            this.ttbSenhaLogin.Location = new System.Drawing.Point(168, 177);
            this.ttbSenhaLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbSenhaLogin.Name = "ttbSenhaLogin";
            this.ttbSenhaLogin.Size = new System.Drawing.Size(169, 27);
            this.ttbSenhaLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
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
            this.tabRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrar.Size = new System.Drawing.Size(523, 342);
            this.tabRegistrar.TabIndex = 1;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(205, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // ttbNomeRegistrar
            // 
            this.ttbNomeRegistrar.Location = new System.Drawing.Point(169, 45);
            this.ttbNomeRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbNomeRegistrar.Name = "ttbNomeRegistrar";
            this.ttbNomeRegistrar.Size = new System.Drawing.Size(169, 27);
            this.ttbNomeRegistrar.TabIndex = 3;
            // 
            // ttbEmailRegistrar
            // 
            this.ttbEmailRegistrar.Location = new System.Drawing.Point(169, 131);
            this.ttbEmailRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbEmailRegistrar.Name = "ttbEmailRegistrar";
            this.ttbEmailRegistrar.Size = new System.Drawing.Size(169, 27);
            this.ttbEmailRegistrar.TabIndex = 4;
            // 
            // ttbSenhaRegistrar
            // 
            this.ttbSenhaRegistrar.Location = new System.Drawing.Point(169, 216);
            this.ttbSenhaRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbSenhaRegistrar.Name = "ttbSenhaRegistrar";
            this.ttbSenhaRegistrar.Size = new System.Drawing.Size(169, 27);
            this.ttbSenhaRegistrar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(205, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(195, 275);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 39);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 381);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
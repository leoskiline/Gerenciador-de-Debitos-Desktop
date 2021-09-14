
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
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegistrar);
            this.tabControl1.ItemSize = new System.Drawing.Size(231, 30);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 285);
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
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(457, 247);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(167, 179);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ttbEmailLogin
            // 
            this.ttbEmailLogin.Location = new System.Drawing.Point(147, 65);
            this.ttbEmailLogin.Name = "ttbEmailLogin";
            this.ttbEmailLogin.Size = new System.Drawing.Size(148, 23);
            this.ttbEmailLogin.TabIndex = 1;
            // 
            // ttbSenhaLogin
            // 
            this.ttbSenhaLogin.Location = new System.Drawing.Point(147, 133);
            this.ttbSenhaLogin.Name = "ttbSenhaLogin";
            this.ttbSenhaLogin.Size = new System.Drawing.Size(148, 23);
            this.ttbSenhaLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(184, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Location = new System.Drawing.Point(4, 34);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(457, 247);
            this.tabRegistrar.TabIndex = 1;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
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
    }
}
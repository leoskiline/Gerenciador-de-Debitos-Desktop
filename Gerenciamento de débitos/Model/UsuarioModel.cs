using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_débitos.Model
{
    class UsuarioModel
    {
        private int idUsuario;
        private string nome;
        private string email;
        private string senha;
        private string nivel;

        public UsuarioModel(string email, string senha)
        {
            this.idUsuario = 0;
            this.nome = "";
            this.email = email;
            this.senha = senha;
            this.nivel = "COMUM";
        }

        public UsuarioModel(int idUsuario, string nome, string email, string senha, string nivel)
        {
            this.idUsuario = idUsuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivel = nivel;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}

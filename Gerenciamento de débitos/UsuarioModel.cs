using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_débitos
{
    public class UsuarioModel
    {
        private string email;
        private string nome;
        private string senha;
        private string nivel;


        public UsuarioModel()
        {
            this.email = "";
            this.nome = "";
            this.senha = "";
            this.nivel = "COMUM";
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}

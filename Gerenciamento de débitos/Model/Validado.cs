using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_débitos.Model
{
    class Validado
    {
        private string icon;
        private string message;

        public Validado(string icon, string message)
        {
            this.icon = icon;
            this.message = message;
        }

        public string Icon { get => icon; set => icon = value; }
        public string Message { get => message; set => message = value; }
    }
}

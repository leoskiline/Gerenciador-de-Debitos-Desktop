using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_débitos.Model
{
    public class DebitoModel
    {

      
        private string descricao;
        private DateTime data;
        private double valor;

        public DebitoModel(string descricao, DateTime data, double valor)
        {
      
            this.Descricao = descricao;
            this.Data = data;
            this.Valor = valor;
     
        }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }

    }
}

using Gerenciamento_de_débitos.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script.Serialization;

namespace Gerenciamento_de_débitos.Api
{
    class WebApi
    {
        public string BaseUrl
        {
            get
            {
                return "https://localhost:44377/";
            }
        }
        // Metodo para Validar se fez Login ou Registro
        public Validado ValidarUsuario(Dictionary<string,string> pairValues,string action)
        {
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().PostAsync(BaseUrl+action,new FormUrlEncodedContent(pairValues)).Result;
            JObject authJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            JToken icon = authJson.GetValue("icon");
            JToken message = authJson.GetValue("message");
            Validado auth = new Validado(icon.ToString(),message.ToString());
            return auth;
        }

        // Metodo para Validar se Despesa foi Cadastrada ou Nao
        public Validado ValidarCadastroDebito(Dictionary<string, string> pairValues, string action)
        {
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().PostAsync(BaseUrl + action, new FormUrlEncodedContent(pairValues)).Result;
            JObject authJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            JToken icon = authJson.GetValue("icon");
            JToken message = authJson.GetValue("msg");
            Validado auth = new Validado(icon.ToString(), message.ToString());
            return auth;
        }
        public IList<DebitoModel> ObterDebitos(Dictionary<string, string> pairValues, string action) /// TERIA QUE SER UMA LISTA PARA RETORNAR
        {
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().GetAsync(BaseUrl + action).Result;

            //JavaScriptSerializer

            //string Json = response.Content.ReadAsStringAsync().Result;

            //dynamic resultado =


            JObject authJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            JToken descricao = authJson.GetValue("descricao");
            JToken data = authJson.GetValue("data");
            JToken valor = authJson.GetValue("valor");

            DebitoModel debito = new DebitoModel(descricao.ToString(), Convert.ToDateTime(data), Convert.ToInt32(valor));

            return default;
        }

    }
}

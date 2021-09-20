using Gerenciamento_de_débitos.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        // Método para alterar o débito
        public Validado AlterarDebito(DebitoModel debitoModel, string action)
        {
            var jsonString = JsonConvert.SerializeObject(debitoModel);
            
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().PutAsync(BaseUrl + action, httpContent).Result;

            JObject authJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            JToken icon = authJson.GetValue("icon");
            JToken message = authJson.GetValue("msg");
            Validado auth = new(icon.ToString(), message.ToString());
            return auth;
        }

        public Validado ExcluirDebito(DebitoModel debitoModel, string action)
        {
            var jsonString = JsonConvert.SerializeObject(debitoModel);

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().DeleteAsync(BaseUrl + action).Result;

            JObject authJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            JToken icon = authJson.GetValue("icon");
            JToken message = authJson.GetValue("msg");
            Validado auth = new(icon.ToString(), message.ToString());
            return auth;
        }

        // Metodo para obter todos os débitos
        public List<DebitoModel> ObterDebitos(string action)
        {
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().GetAsync(BaseUrl + action).Result;
            JArray authJson = JArray.Parse(response.Content.ReadAsStringAsync().Result);
            DebitoModel model;
            List<DebitoModel> listaDebitos = new List<DebitoModel>();
            foreach (JObject obj in authJson)
            {
                model = new DebitoModel(Convert.ToInt32(obj.GetValue("idDebito")),
                                        obj.GetValue("descricao").ToString(), 
                                        Convert.ToDateTime(obj.GetValue("data").ToString()), 
                                        Convert.ToDouble(obj.GetValue("valor").ToString()));
                listaDebitos.Add(model);
                model = null;
            }
            return listaDebitos;
        }

        public List<DebitoModel> FiltrarDebito(string action)
        {
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().GetAsync(BaseUrl + action).Result;
            JArray authJson = JArray.Parse(response.Content.ReadAsStringAsync().Result);
            DebitoModel model;
            List<DebitoModel> listaDebitos = new List<DebitoModel>();
            foreach (JObject obj in authJson)
            {
                model = new DebitoModel(Convert.ToInt32(obj.GetValue("idDebito")),
                                        obj.GetValue("descricao").ToString(),
                                        Convert.ToDateTime(obj.GetValue("data").ToString()),
                                        Convert.ToDouble(obj.GetValue("valor").ToString()));
                listaDebitos.Add(model);
                model = null;
            }
            return listaDebitos;
        }
    }
}

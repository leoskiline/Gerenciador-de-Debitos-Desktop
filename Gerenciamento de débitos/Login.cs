using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    public partial class Login : Form
    {
        private JsonSerializerOptions _jsonOptions;
        private JsonSerializerSettings _jsonSettings;
        private HttpClient _httpClient;
        private string _url;

        public Login()
        {
            InitializeComponent();
            _url = "https://localhost:44377/";
            _httpClient = new HttpClient();
            _jsonOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            _jsonSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DateParseHandling = DateParseHandling.None
            };
        }

        public async Task<object> PostAsync<T>(string url)
        {
            try
            {
                var data = new Dictionary<string, string>();
                data.Add("email", ttbEmailLogin.Text);
                data.Add("senha", ttbSenhaLogin.Text);
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = _httpClient.PostAsync(_url + "Login/Logar", new FormUrlEncodedContent(data)).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                ValidaAutenticado json = System.Text.Json.JsonSerializer.Deserialize<ValidaAutenticado>(content, _jsonOptions);;
            }
            catch (Exception e)
            {
                Console.WriteLine(2);
            }
            return default;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ttbEmailLogin.TextLength > 0 && ttbEmailLogin.Text.Contains("@") && ttbEmailLogin.Text.Contains(".") && ttbSenhaLogin.TextLength > 0)
            {
                Task<object> ret = PostAsync<ValidaAutenticado>("Login/Logar");
            }
            else
            {
                MessageBox.Show("Campos Invalidos!");
            }
        }
    }
}

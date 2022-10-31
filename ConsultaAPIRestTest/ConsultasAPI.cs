using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsultaAPIRestTest
{
    internal class ConsultasAPI
    {
        readonly RestClient _client;

        public ConsultasAPI()
        {
            _client = new RestClient("http://[::1]:3000")
                .AddDefaultHeader(KnownHeaders.Accept, "application/json");
        }

        public Usuario? GetUsuarioPorID(string ID)
        {
            return _client.GetJson<Usuario>("/usuarios/" + ID);
        }

        public RestResponse PostUsuario(Usuario usuario)
        {
            string jsonString = JsonSerializer.Serialize(usuario);
            var request = new RestRequest("/usuarios");
            request.AddJsonBody(jsonString);
            return _client.Post(request);
        }
    }
}

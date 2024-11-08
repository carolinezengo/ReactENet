
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReactENET.Entidades;
using ReactENET.Servicos;
using System.Text;

namespace ReactENET.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpDelete]
        public async Task<bool> Apagar(int id)
        {
            using (var client = new HttpClient())
            {
                AutenticacaoAPI.GetHeaderTokenAuthorization(client);

                var response = await client.DeleteAsync($"https://xjwtshjrajflumotjyuf.supabase.co/rest/v1/Usuario?Codigo=eq.{id}");
                var responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        [HttpPost]
        public async Task<bool> Incluir(UsuarioEntities usuario)
        {
            using (var client = new HttpClient())
            {
                AutenticacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://xjwtshjrajflumotjyuf.supabase.co/rest/v1/Usuario", content);
                var responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        [HttpGet("{email}")]
        public async Task<bool> Login(string email)
        {

            using (var client = new HttpClient())
            {
                AutenticacaoAPI.GetHeaderTokenAuthorization(client);


                using (var response = await client.GetAsync($"https://xjwtshjrajflumotjyuf.supabase.co/rest/v1/Usuario?Email=eq.{email}"))
                {

                    if (response.IsSuccessStatusCode)
                    {

                        return true;
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter o Cliente: " + response.StatusCode);


                    }


                }



            }
        }

    }
}

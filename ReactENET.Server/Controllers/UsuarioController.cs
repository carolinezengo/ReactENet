
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReactENET.Entidades;
using ReactENET.Servicos;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace ReactENET.Server.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet]
        public async Task<string > Login()
        {
            using (var client = new HttpClient())
            {
                AutenticacaoAPI.GetHeaderTokenAuthorization(client);
                
                var response = await client.GetAsync($"https://xjwtshjrajflumotjyuf.supabase.co/rest/v1/Usuario?select=*") ;
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent );
              
                 Console.WriteLine(response);


                if (response.IsSuccessStatusCode)
                {
                    return responseContent;
                }else
                {
                    return "";
                }
                    //  var content = await response.Content.ReadAsStringAsync();
                    //JsonSerializerOptions options = new JsonSerializerOptions
                    //{
                    ///  IncludeFields = true,
                    //PropertyNameCaseInsensitive = true
                    //};


                    // List<UsuarioEntities> usuario = JsonSerializer.Deserialize<List<UsuarioEntities>>(content, options);

                    //}
                    /// else {
                    //  return null;

                    //}



                }
            
        }

    }
}

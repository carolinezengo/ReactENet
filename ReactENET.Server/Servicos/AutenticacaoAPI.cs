
using ReactENET.Entidades;
using System.Net.Http.Headers;

namespace ReactENET.Servicos

{
    public class AutenticacaoAPI
    {
       
       public static void GetHeaderTokenAuthorization(HttpClient client)

        {
            string password = AcessoTokenEUrl.PASSWORD();


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("apikey", password);
            client.DefaultRequestHeaders.Accept.Add(

            new MediaTypeWithQualityHeaderValue("application/json"));


            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", password);
        }
    }
}



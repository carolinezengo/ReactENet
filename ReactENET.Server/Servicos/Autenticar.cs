
using ReactENET.Entidades;
using System.Net.Http.Headers;

namespace ReactENET.Servicos

{
    public class Autenticar
    {



        public static HttpResponseMessage AutenticarBanco()
        {

            using (var client = new HttpClient())
            {

                // Envio da requisição a fim de autenticar
                // e obter o token de acesso


                string _urlBase = AcessoTokenEUrl.URl();
                var password = AcessoTokenEUrl.PASSWORD();
                string urlbase = _urlBase;



                var request = new HttpRequestMessage(HttpMethod.Get, _urlBase);
                request.Headers.Add("apikey", password);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", password);
                var responseMensagem = client.SendAsync(request);

                var responseResult = responseMensagem.Result;

                var requestMenssagem = responseResult.RequestMessage;
                var content = requestMenssagem.Headers.ToString();


                if (responseResult.IsSuccessStatusCode)
                {


                    return responseResult;
                }
                else
                {
                    return null;
                }


            }
        }
    }
}

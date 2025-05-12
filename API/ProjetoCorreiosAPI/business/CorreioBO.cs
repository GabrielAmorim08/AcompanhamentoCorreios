using System.Text;
using System.Xml;
using System;
using Microsoft.AspNetCore.Mvc;
using ProjetoCorreiosAPI.Interface;
using ProjetoCorreiosAPI.Model;
using ProjetoCorreiosAPI.VO;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ProjetoCorreiosAPI.Bussines
{
    public class CorreioBO : ICorreio
    {
        protected readonly DbCorreiosContext _context;
        public CorreioBO(DbCorreiosContext context) { _context = context; }
        public async Task<ReturnVO<AuthVO>> GetToken()
        {
            try
            {
                string apiCorreios = "https://api.correios.com.br/token/v1/autentica";
                using (HttpClient httpClient = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, apiCorreios);


                    string credenciais = Convert.ToBase64String(Encoding.UTF8.GetBytes("" + ":" + ""));


                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credenciais);

                    var content = new StringContent(string.Empty,Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PostAsync(apiCorreios, content);

                    string responseContent = await response.Content.ReadAsStringAsync();

                    var retorno = JsonConvert.DeserializeObject<AuthVO>(responseContent);
                    if (response.IsSuccessStatusCode)
                    {
                        return new ReturnVO<AuthVO>(true, $"Token gerado com sucesso {retorno.token}", retorno);
                    }
                    else
                    {
                        return new ReturnVO<AuthVO>(false, responseContent, new AuthVO());
                    }
                }
            }
            catch (Exception e)
            {
                return new ReturnVO<AuthVO>(false, e.Message, new AuthVO());
            }
        }
    }
}

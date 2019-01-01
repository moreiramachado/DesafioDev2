using DadosWhois.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DadosWhois.Client
{
	public class ClientWhois
	{
		public HttpClient client;
	
		public ClientWhois()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://jsonwhoisapi.com/api/v1/");
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("46BQ1Z6h10HSp8p0ubc27A");
		}

		public Models.DadosWhois PesquisaDominio(string dominio)
		{
			var resposta = client.GetAsync("whois?identifier=" + dominio).Result;

			var resultadoJson = resposta.Content.ReadAsStringAsync().Result;
			var dadosWhois = JsonConvert.DeserializeObject<Models.DadosWhois>(resultadoJson);

			if (resposta.IsSuccessStatusCode) {
				return dadosWhois;
			}

			return null;
		}



	}
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadosWhois.Models
{
	public class DadosWhois
	{
		[JsonProperty(PropertyName = "name")]
		public string Dominio { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "nameservers")]
		public List<string> NameServer { get; set; }

		[JsonProperty(PropertyName = "changed")]
		public string DataAlteracao { get; set; }

		[JsonProperty(PropertyName = "created")]
		public string DataCriacao { get; set; }

		[JsonProperty(PropertyName = "expires")]
		public string DataExpiracao { get; set; }


	}
}
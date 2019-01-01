using DadosWhois.BancoDados;
using DadosWhois.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DadosWhois.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult ConsultaDominio(string dominio)
		{

			var whoisClient = new ClientWhois();
			var resultadoPesquisa = whoisClient.PesquisaDominio(dominio);

			new ConexaoBanco().SalvaDominio(resultadoPesquisa.Dominio);

			return View("ResultadoConsulta", resultadoPesquisa);
		}


	}

}
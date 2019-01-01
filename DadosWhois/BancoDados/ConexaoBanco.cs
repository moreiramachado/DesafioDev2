using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DadosWhois.BancoDados
{
	public class ConexaoBanco
	{
		public SqlConnection conexao;

		public ConexaoBanco()
		{
			conexao = new SqlConnection(@"Data Source=LENOVO-PC\TEW_SQLEXPRESS;Initial Catalog=DadosWhois;Integrated Security=True;Pooling=False");
		}

		public void SalvaDominio(string dominio)
		{
			conexao.Open();
			var cmd = new SqlCommand("INSERT INTO dominios VALUES('" + dominio + "')", conexao);
			cmd.ExecuteNonQuery();
			conexao.Close();
		}

	}
}



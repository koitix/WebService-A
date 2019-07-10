using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://localhost/WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string URLBanco = "Server=127.0.0.1;User Id=postgres;Password=senha;Database=Geral;";

        [WebMethod(Description = "Seleção de Salas.")]
        public int BuscarSalasDisponiveis()
        {
            int retorno = 0;
            using (NpgsqlConnection conn = new NpgsqlConnection(URLBanco))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome FROM public.\"Sala\"", conn))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        retorno++;
                    }
                }
                conn.Close();
            }

            return retorno;
        }


        [WebMethod(Description = "Limpar Salas.")]
        public string LimparSalas()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(URLBanco))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("Update public.\"Sala\" set status =0", conn))
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        conn.Close();

                        return "Todas as salas estão Disponíveis.";
                    }
                    else
                    {
                        conn.Close();
                        return "Não foi possível executar a operação.";
                    }

                }
            }
        }

        [WebMethod(Description = "Reservar Sala.")]
        public string ReservarSala(string titulo,string sala,string data)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(URLBanco))
            {
                string retorno = "";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("Select status from public.\"Sala\" where id_sala = " + sala, conn))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        retorno = dr[0].ToString();
                    }
                    conn.Close();
                }

                if (retorno == "0")
                {
                    conn.Open();
                    using (NpgsqlCommand cmdatualiza = new NpgsqlCommand("update public.\"Sala\" set status = 1 where id_sala = " + sala, conn))
                    {

                        if (cmdatualiza.ExecuteNonQuery() > 0)
                        {
                            conn.Close();

                            return "A sala foi Reservada com Sucesso.";
                        }
                        else
                        {
                            conn.Close();
                            return "Não foi possível reservar a sala.";
                        }
                    }

                }
                else
                {
                    return "Não foi possível reservar a sala.";
                }
            }
        }
    }
}

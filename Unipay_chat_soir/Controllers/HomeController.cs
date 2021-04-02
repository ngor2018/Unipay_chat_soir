using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unipay_chat_soir.Models;
using System.Data.SqlClient;

namespace Unipay_chat_soir.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Compte
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source=PAPE_NGOR_FAYE; database=unipay_chat; integrated security = SSPI;";
        }
        [HttpPost]
        [Route("Verifier")]
        public ActionResult Verifier(Compte comp)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM unipay_chat_db WHERE unipay_user='" + comp.login + "' AND password='" + comp.password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("unipay_page_connexion");
            }
            else
            {
                con.Close();
                return View("Index");
            }

        }
    }
}
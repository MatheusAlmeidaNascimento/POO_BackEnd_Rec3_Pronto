using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POO_Back_End_Rec3.Models;

namespace POO_Back_End_Rec3.Controllers
{

   [Route("Login")]
    public class LoginController : Controller
    {
        Musico m1 = new Musico();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = m1.ReadAllLinesCSV("Database/Usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado =
            csv.Find(
                x =>
                x.Split(";")[2] == form["Email"] &&
                x.Split(";")[3] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if (logado != null)
            {
                // Definimos os valores a serem salvos na sessão
                HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);

                return LocalRedirect("~/Home");
            }
            return LocalRedirect("~/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }

    }
}


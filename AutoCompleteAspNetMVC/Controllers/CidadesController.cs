using AutoCompleteAspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompleteAspNetMVC.Controllers
{
    public class CidadesController : Controller
    {
        // GET: Cidades
        public JsonResult ListarCidadesPorUF(string uf)
        {
            var db = new ClientesContext();
            var cidades = db.Cidades
                        .Where(c => c.UF == uf)
                        //Codigo abaixo necessário para apresentar apenas o que nós queremo, que no caso é ID e NOME
                        .Select(c => new { Id = c.Id, Nome = c.Nome });

            //A lista de objetos chamada "cidades" é convertida para Json
            return Json(cidades, JsonRequestBehavior.AllowGet);
        }

        //    public JsonResult DadosCEP(string cep)
        //    {
        //        var ListaCEP = "https://viacep.com.br/ws/" + cep.Replace("-", "") + "/json/";

        //        return Json(ListaCEP,JsonRequestBehavior.AllowGet);
        //    }
    }
}
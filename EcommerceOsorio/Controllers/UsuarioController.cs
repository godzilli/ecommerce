using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using System.Net;
using Newtonsoft.Json;

namespace EcommerceOsorio.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroUsuario()
        {
            Usuario u = new Usuario();

            if (TempData["Usuario"] != null)
            {
                string resultado = TempData["Usuario"].ToString();
                u.Endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult BuscarCep(Usuario u)
        {
            
            string url = "https://viacep.com.br/ws/" + u.Endereco.cep + "/json/";
            WebClient client = new WebClient();
            TempData["Usuario"] = client.DownloadString(url);
            return RedirectToAction(nameof(CadastroUsuario));
        }

        [HttpPost]
        public IActionResult CadastroUsuario(Usuario u)
        {
            return RedirectToAction("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using formy.Models;

namespace formy.Controllers
{
   
    public class MatriculaController : Controller
    {
        private readonly ILogger<MatriculaController> _logger;

        public MatriculaController(ILogger<MatriculaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Matricula objMatricula){
            bool mate=objMatricula.Matematica;
            bool leng=objMatricula.Lenguaje;
            bool hist=objMatricula.Historia;
            double preMate=0,preLen=0,preHis=0;
                if(mate==true){
                    preMate=300;
                }
                if(leng==true){
                    preLen=300;
                }
                if(hist==true){
                    preHis=300;
                }
                double subTotal,IGV,total;
                subTotal=preMate+preLen+preHis;
                IGV=(subTotal*18)/100;
                total=subTotal+IGV;
                ViewData["Mensaje"]="Se ha registrado Satisfactoriamente";
                ViewData["SubTotal"]="Sub Total: S/."+subTotal;
                ViewData["IGV"]="IGV(18%): S/."+IGV;
                ViewData["Total"]="Total: S/."+total;
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
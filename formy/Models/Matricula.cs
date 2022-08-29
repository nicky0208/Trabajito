using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace formy.Models
{
    public class Matricula
    {
        [Display(Name ="Nombre",Prompt ="Nombres Completo")]
        public String? Nombre{get;set;}
        public bool Matematica{get;set;}
        public bool Lenguaje{get;set;}
        public bool Historia{get;set;}

    }
}
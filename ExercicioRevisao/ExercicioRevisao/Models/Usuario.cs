using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExercicioRevisao.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string nickname { get; set; }
        public string senha { get; set; }
    }
}
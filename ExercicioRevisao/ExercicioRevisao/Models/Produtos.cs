using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExercicioRevisao.Models
{
    public class Produtos
    {
        [Key]
        public int idProdutos { get; set; }
        public string nome { get; set; }
        public Decimal valor { get; set; }
    }
}
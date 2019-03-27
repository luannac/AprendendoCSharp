using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Adicionado
using System.Web.Mvc;

namespace CadastroBancoWEB.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }
        public String nome { get; set; }
        public String email { get; set; }
        public byte dia_nascimento { get; set; }
        public byte mes_nascimento { get; set; }
        public int ano_nascimento { get; set; }
        public char[] uf { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Adicionado

namespace ExerCRUD.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public byte[] foto { get; set; }
        public string fone { get; set; }
        public string cpf { get; set; }
        public string Endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string nomePai { get; set;}
        public string nomeMae { get; set; }
        public string nacionalidade { get; set; }
        public string naturalidade { get; set; }
        public DateTime dataNascimento { get; set; }
        public string estadoCivil { get; set; }
        public string grauInstrucao { get; set; }
        public string cedIdentidade { get; set; }
        public string carteiraProfissional{ get; set; }
        public string carteiraReservista { get; set; }
        public string tituloEleitor { get; set; }
        public string carteiraHabilitacao { get; set; }
    }
}
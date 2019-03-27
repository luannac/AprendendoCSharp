using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;// Adicionar

namespace CadastroBancoWEB.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
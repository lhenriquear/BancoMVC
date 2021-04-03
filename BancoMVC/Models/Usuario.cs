using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Mome { get; set; }

        public Conta contas { get; set; }
    }
}

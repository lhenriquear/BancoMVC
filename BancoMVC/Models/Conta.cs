using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoMVC.Models
{
    public class Conta
    {
        public int Id { get; set; }

        public double Saldo { get; set; }

        public double Credito { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}

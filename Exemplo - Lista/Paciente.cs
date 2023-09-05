using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Lista
{
    internal class Paciente
    {
        public int Id_paciente { get; set; }
        public string Nome { get; set; } 
        
        public string Cpf { get; set; }

        public string Email { get; set; }

        public DateTime DataNasc { get; set; }

        public Paciente(int id_paciente, string nome, string cpf, string email, DateTime dataNasc)
        {
            this.Id_paciente = id_paciente;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataNasc = dataNasc;
        }
    }
}

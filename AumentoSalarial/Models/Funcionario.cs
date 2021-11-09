using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalarial.Models
{
    class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public string cargo { get; set; }

        public double aumentoSalario { get; set; }
        public Funcionario(string Nome, double Salario, string Cargo, double AumentoSalario)
        {
            this.nome = Nome;
            this.salario = Salario;
            this.cargo = Cargo;
            this.aumentoSalario = AumentoSalario;
        }
    }
    
}

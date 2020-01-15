using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    class Funcionario {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao() {
            return Salario;
        }
        public override string ToString() {
            return $"Nome: {Nome} | Idade: {Idade} | Salário: {Bonificacao()}";
        }
    }
}

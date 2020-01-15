using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    class Vendedor : Funcionario {
        public override double Bonificacao() {
            return Salario + 3000;
        }
    }
}

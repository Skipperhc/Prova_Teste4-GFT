using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    class Program {
        static void Main(string[] args) {
            Vendedor vendedor = new Vendedor() {Nome = "jose", Salario = 2000, Idade = 26};
            Supervisor supervisor = new Supervisor() {Nome = "Carlos", Salario = 3600, Idade = 30};
            Gerente gerente = new Gerente() {Nome = "Mariana", Salario = 6000, Idade = 20/*uau*/};

            Console.WriteLine(vendedor);
            Console.WriteLine(supervisor);
            Console.WriteLine(gerente);
        }
    }
}

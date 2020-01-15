using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_teste4_fase2 {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa = new Pessoa();
            int maiorIdade = 0;
            string MaisVelho = "", procurarnome;

            pessoa.AdicionarPessoa(pessoa, 15, "joão");
            pessoa.AdicionarPessoa(pessoa, 21, "leandro");
            pessoa.AdicionarPessoa(pessoa, 17, "paulo");
            pessoa.AdicionarPessoa(pessoa, 18, "jessica");
            foreach (var person in pessoa.Lista) {
                if (person.Idade > maiorIdade) {
                    maiorIdade= person.Idade;
                    MaisVelho = person.Nome;
                }
            }

            Console.WriteLine("\no mais velho é: " + MaisVelho + " com " + maiorIdade + " anos");
            Console.WriteLine($"\na Lista tem {pessoa.Lista.Count} pessoas");

            for (int i = 0; i < pessoa.Lista.Count; i++) {
                if (pessoa.Lista[i].Idade < 18) {
                    pessoa.ExcluirPessoa(pessoa.Lista[i].Nome, pessoa);
                }
            }

            Console.WriteLine($"\ne agora depois de excluir tem apenas {pessoa.Lista.Count}");
            procurarnome = pessoa.ProcurarPessoa(pessoa, "jessica");
            Console.WriteLine($"\njessica {procurarnome} na lista");

        }

    }

    class Pessoa {
        public List<Pessoa> Lista = new List<Pessoa>();

        public string Nome { get; set; }
        public int Idade { get; set; }
        public override string ToString() {
            return Nome + "tem " + Idade + "anos";
        }

        public void AdicionarPessoa(Pessoa pessoa, int idade, string nome) {
            pessoa.Lista.Add(new Pessoa() {
                Nome = nome, Idade = idade
            });
        }

        public void ExcluirPessoa(string nome, Pessoa pessoa) {
            int local = pessoa.Lista.FindIndex(p => p.Nome == nome);
            pessoa.Lista.RemoveAt(local);
        }

        public string ProcurarPessoa(Pessoa pessoa, string nome) {
            bool existe = pessoa.Lista.Exists(p => p.Nome == nome);

            if (existe) {
                return "existe";
            }
            return "não existe";
        }
    }
}

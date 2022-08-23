using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA2208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração e instanciação do objeto
            Produto prod = new Produto();
            Cliente cli = new Cliente();

            Console.Write("Digite o nome do Cliente: ");
            cli.setNome(Console.ReadLine());
            Console.Write("Digite o CPF do cliente: ");
            cli.setCpf(Console.ReadLine());
            Console.Write("Digite o Endereço do cliente: ");
            cli.setEndereco(Console.ReadLine());
            Console.Write("Digite a idade do cliente: ");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descrição: ");
            prod.setDescricao(Console.ReadLine());
            Console.Write("Digite a categoria: ");
            prod.setCategoria(Console.ReadLine());
            Console.Write("Digite o valor: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Nome = " + cli.getNome() + "\nEndereco = " +
                cli.getEndereco() + "\nCPF = " + cli.getCpf() + "\nIdade = "
                + cli.getIdade());

            Console.WriteLine("Código = " + prod.getCodigo() + "\nDescrição: " +
               prod.getDescricao() + "\nCategoria = " + prod.getCategoria() +
               "\nValor = " + prod.getValor().ToString("C"));
            {
                Console.ReadKey();
            }
        }
    }
}
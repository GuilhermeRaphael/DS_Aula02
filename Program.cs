//Models é onde ficam as classes

using System;
using System.Runtime.InteropServices.Marshalling;
using Aula_02.Models;
using Aula_02.Models.Enuns;

namespace Aula_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

           /* func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "1245678910";
            func.DataAdmissao = DateTime.Parse ("01/01/1991");
            func.Salario = 10000.00M; //M o compilador entende que o dado é um decimal
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("==========================================");
            Console.WriteLine(mensagem);
            Console.WriteLine("==========================================");

            */ 

            Console.WriteLine ("Digite o id do funcionario");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o seu cpf: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissao: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de funcionario (1-CLT / 2-Aprendiz)");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1 ) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal CalcularDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("================================");
            Console.WriteLine($"O salario reajustado do é {func.Salario}.\n");
            Console.WriteLine($"O Desconto do VT é {CalcularDescontoVT}.\n");
            Console.WriteLine("================================");
            
        }
    }
}
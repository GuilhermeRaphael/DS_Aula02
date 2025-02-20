using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_02.Models.Enuns;

namespace Aula_02.Models
{
    public class Funcionario
    {
        //prop + TAB --> Cria propriedade
        // string.Empty --> inicia no vazio
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }

        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100); //calculando um reajuste de 10%
        }

        public decimal CalcularDescontoVT(decimal percentual) //parametro é como se fosse uma variavel mas que so vai existir dentro desse bloco, que é onde ela esta declarada
        {
            decimal desconto = Salario * percentual / 100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length; //Ela retonar o tamanho do que esta dentro
        }

        public bool ValidarCpf() //identar o codigo shift + alt + F
        {
            if (ContarCaracteres(Cpf) == 11)
                return true;
            else
                return false;
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
                string.Format("Periodo de Experiencia: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
        return periodoExperiencia;
        }

        

    }
}
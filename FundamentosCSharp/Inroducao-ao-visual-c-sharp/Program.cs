using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inroducao_ao_visual_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeDoFuncionario = "Juliano";
            string cargoDoFuncionario = "Programador";
            decimal salario = 100.00m;
            DateTime dataDeAniversario = DateTime.Now.Date;
            char tipoDeSexo = 'M';
            bool possuiFerias = true;

            Console.WriteLine("Nome do funcionario:" + nomeDoFuncionario);
            Console.WriteLine("Cargo do funcionario:" + cargoDoFuncionario);
            Console.WriteLine("Salario do funcionario:" + salario);
            Console.WriteLine("Tipo do Sexo:" + tipoDeSexo);
            Console.WriteLine("Date de Aniversario:" + dataDeAniversario);
            Console.WriteLine("Possui ferias:" + possuiFerias);

            Console.ReadKey();

            OperadoresAritmeticos();

            Console.WriteLine(ONumeroEPar(3));

            Console.ReadKey();


            int precedencia = 2 + 3 * 4;

            Console.WriteLine(precedencia);

            Console.ReadKey();

            IncrementoDecremento();
        }

        static void OperadoresAritmeticos()
        {
            double meuPrimeiroNumero = 10;
            double meuSegundoNumero = 20;

            double retornoDaAdicao = meuPrimeiroNumero + meuSegundoNumero;

            Console.WriteLine("Adicao" + retornoDaAdicao);

            double retornoDaSubtracao = meuPrimeiroNumero - meuSegundoNumero;

            Console.WriteLine("Subtracao" + retornoDaSubtracao);

            double retornoMultiplicacao = meuPrimeiroNumero * meuSegundoNumero;


            Console.WriteLine("Multiplicacao" + retornoMultiplicacao);

            double retornoDivisao = meuPrimeiroNumero / meuSegundoNumero;
            Console.WriteLine("Divisao" + retornoDivisao);

            Console.ReadKey();
        }

        static bool ONumeroEPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }

            return false;
        }

        static void IncrementoDecremento()
        {

            int saldo = 0;

            saldo++;

            Console.WriteLine(saldo);
            Console.ReadKey();
        }
    }
}

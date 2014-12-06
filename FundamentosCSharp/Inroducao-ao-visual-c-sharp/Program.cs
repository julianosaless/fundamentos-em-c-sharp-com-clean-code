using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal primeiroNumero = 10;
            const decimal segundoNumero = 20;

            var calculadora = new Calculadora(primeiroNumero, segundoNumero);

            Console.WriteLine(calculadora.Calcular());
            Console.WriteLine(calculadora.Subtrair());
            Console.ReadKey();
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

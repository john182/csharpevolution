using System;
using System.Linq;
using System.Text.RegularExpressions;
using CharpEvolution.Ext;
using CharpEvolution.Tests01.Calculados;
using CsharpEvolution.Tests01.Calculos;

namespace CsharpEvolution.Tests01
{
    public class Calculadora
    {
        public void Iniciar()
        {
            CriarMenu();
            var operador = "";

            while (operador != "q")
            {
                operador = Console.ReadLine();

                if (operador is not ("+" or "*" or "-" or "/") )
                {
                    Console.WriteLine("Operador invalido!! informe um operador validor ou precione 'q' para sair\n");
                    continue;
                }

                Console.WriteLine("Informe um ou mais operando\n");
                Console.WriteLine("Exmplo 10 20.5 30\n");
                var entrada = Console.ReadLine();

                decimal[] operandos;
                try
                {
                    operandos = entrada.Split(" ")
                        .Select(value => decimal.Parse(String.Join("", Regex.Split(value, @"[\D]")))).ToArray();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Dados de entrada invalido a aplicação será finalizada");
                    break;
                }

                RealizarOperacoes(operador, operandos);

                Console.WriteLine("\nInforme a operação ou precione 'q' para sair\n");
            }
        }


        private void RealizarOperacoes(string operador, decimal[] operandos)
        {
            var result = operador.GetEnumValueFromDescription<Operadores>();
            
            var dividir = new Dividir();
            var multiplicar = new Multiplicar(dividir);
            var subtrair = new Subtrair(multiplicar);
            var soma = new Somar(subtrair);

            soma.Calcular(result, operandos);
        }

        private void CriarMenu()
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Operacoes\n");
            Console.WriteLine("'+' : soma\n");
            Console.WriteLine("'-' : subtracao\n");
            Console.WriteLine("'*' : multiplicao\n");
            Console.WriteLine("'/' : divisao\n");
            Console.WriteLine("\nInforme a operação ou precione 'q' para sair\n");
        }
    }
}
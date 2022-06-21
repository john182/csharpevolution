using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CharpEvolution.Tests01
{
    public class Calculadora:ICalculadora
    {
        
        public void Iniciar()
        {

            CriarMenu();
            var operador = "";
            
            while (operador!= "q")
            {
                operador = Console.ReadLine();
              
                if (operador!= "+")
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

                RealizarOperacoes(operador,operandos);
                
                
                Console.WriteLine("\nInforme a operação ou precione 'q' para sair\n");
                
            }
          
        }

        
        public void Somar( params decimal[] operandos)
        {

            if (operandos.Length < 2)
            {
                Console.WriteLine("É preciso informar ao menos dois operandos");
                return;
            }

            var total = operandos.Sum();

            Console.WriteLine("O Resultado é {0}",total);
        }

      
        public void Subtrair( params decimal[] operandos)
        {

            if (operandos.Length < 2)
            {
                Console.WriteLine("É preciso informar ao menos dois operandos");
                return;
            }

            var total = operandos[0];
            for (var i = 1;i< operandos.Length;i++)
            {
                total -= operandos[i];
            }
            
            
            Console.WriteLine("O Resultado é {0}",total);
        }
      

        public void Multiplicar( params decimal[] operandos)
        {

            if (operandos.Length < 2)
            {
                Console.WriteLine("É preciso informar ao menos dois operandos");
                return;
            }

         
            var total = operandos[0];
            for (var i = 1;i< operandos.Length;i++)
            {
                total *= operandos[i];
            }

            
            Console.WriteLine("O Resultado é {0}",total);
        }
        
        public void Dividir( params decimal[] operandos)
        {
        
            if (operandos.Length < 2)
            {
                Console.WriteLine("É preciso informar ao menos dois operandos");
                return;
            }
        
         
            var total = operandos[0];
        
            if (total == 0)
            {
                Console.WriteLine("O Resultado é Indeterminado");
                return;
            }
        
            var concluiu = true;
            for (var i = 1;i< operandos.Length;i++)
            {
                if (operandos[i] == 0)
                {
                    Console.WriteLine("O Resultado é indefinido");
                    concluiu = false;
                    break;
                }
                
                total /= operandos[i];
            }
        
            if (concluiu)
                Console.WriteLine("O Resultado é {0}",total);
        }

        private void RealizarOperacoes(string operador, decimal[] operandos)
        {
            switch (operador)
            {
                case "+":
                    Somar(operandos);
                    break;
                case "-":
                    Subtrair(operandos);
                    break;
                    
                case "*":
                    Multiplicar(operandos);
                    break;
                    
                case "/":
                    Dividir(operandos);
                    break;
                   
            }
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
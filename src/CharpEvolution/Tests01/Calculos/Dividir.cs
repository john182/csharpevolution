using System;
using CharpEvolution.Tests01.Calculados;

namespace CsharpEvolution.Tests01.Calculos;

public class Dividir:ICalculoSimples
{
    public ICalculoSimples OutraOperacao { get; set; }


    public void Calcular(Operadores operador, params decimal[] operandos)
    {

        if (operador != Operadores.DIVIDIR)
        {
            return;
        }
        
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
}
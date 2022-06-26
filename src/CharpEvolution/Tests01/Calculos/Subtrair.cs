using System;
using CharpEvolution.Tests01.Calculados;

namespace CsharpEvolution.Tests01.Calculos;

public class Subtrair: OperacaoBase
{


    public Subtrair(ICalculoSimples outraOperacao):base(Operadores.SUBTRAIR,outraOperacao)
    {
        
    }

    protected override void RealizarCalculo(decimal[] operandos)
    {
        var total = operandos[0];
        for (var i = 1;i< operandos.Length;i++)
        {
            total -= operandos[i];
        }

        Console.WriteLine("O Resultado é {0}",total);
    }
}
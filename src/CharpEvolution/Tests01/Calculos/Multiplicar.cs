using System;
using CharpEvolution.Tests01.Calculados;

namespace CsharpEvolution.Tests01.Calculos;

public class Multiplicar : OperacaoBase
{
    public Multiplicar(ICalculoSimples outraOperacao) : base(Operadores.MULTIPLICAR, outraOperacao)
    {
    }

    protected override void RealizarCalculo(decimal[] operandos)
    {
        var total = operandos[0];
        for (var i = 1; i < operandos.Length; i++)
        {
            total *= operandos[i];
        }
        Console.WriteLine("O Resultado é {0}", total);
    }
}
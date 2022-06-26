using System;
using System.Linq;
using CharpEvolution.Tests01.Calculados;

namespace CsharpEvolution.Tests01.Calculos;

public class Somar:OperacaoBase
{

    public Somar(ICalculoSimples outraOperacao):base(Operadores.SOMAR,outraOperacao)
    {

    }
    protected override void RealizarCalculo(decimal[] operandos)
    {
        var total = operandos.Sum();

        Console.WriteLine("O Resultado é {0}",total);
    }
}
using System;

namespace CsharpEvolution.Tests01.Calculos;

public class Potencia
{
    public void Calcular(double valorBase, double expoente )
    {
        Console.WriteLine("A Potencia de {0} elevado a {1} é {2}",valorBase,expoente ,Math.Pow(valorBase,expoente));;
    }
}
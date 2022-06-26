using System;

namespace CsharpEvolution.Tests01.Calculos;


public class AreaCirculo
{
    public void Calcular(double raio )
    {
        Console.WriteLine("A area do ciruclo é {0}", Math.PI * Math.Sqrt(raio));
    }
}
using System;

namespace CsharpEvolution.Tests01.Calculos;

public class AreaQuadrado
{
    public void Calcular(double tamanhoLado)
    {
        Console.WriteLine("A area do quadado é {0}", Math.Pow(tamanhoLado,2));
    }
}
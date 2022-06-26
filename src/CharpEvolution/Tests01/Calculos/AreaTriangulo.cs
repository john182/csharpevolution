using System;

namespace CsharpEvolution.Tests01.Calculos;


public class AreaTriangulo
{
    public void Calcular(double tamanhoBase, double tamanhoAltura )
    {
        Console.WriteLine("A area do triangulo é {0}", tamanhoBase * tamanhoAltura / 2);
    }
}
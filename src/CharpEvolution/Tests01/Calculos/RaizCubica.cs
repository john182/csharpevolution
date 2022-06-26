using System;

namespace CsharpEvolution.Tests01.Calculos;

public class RaizCubica
{
    public void Calcular(double valor)
    {
        Console.WriteLine("A Raiz cúbica de {0} é {1}",valor, Math.Cbrt(valor));;
    }
}
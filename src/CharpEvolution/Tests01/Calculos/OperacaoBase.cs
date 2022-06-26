using System;
using CharpEvolution.Tests01.Calculados;

namespace CsharpEvolution.Tests01.Calculos;

public abstract class OperacaoBase:ICalculoSimples
{
    public ICalculoSimples OutraOperacao { get; set; }
    private readonly Operadores _operador;

    protected OperacaoBase(Operadores operador, ICalculoSimples outraOperacao)
    {
        _operador = operador;
        OutraOperacao = outraOperacao;
    }

    public void Calcular(Operadores operador, params decimal[] operandos)
    {
        if (operador != _operador)
        {
            OutraOperacao.Calcular(operador,operandos);
            return;
        }
        
        if (operandos.Length < 2)
        {
            Console.WriteLine("É preciso informar ao menos dois operandos");
            return;
        }

        RealizarCalculo(operandos);
    }

    protected abstract void RealizarCalculo(decimal[] operandos);

}
using System.ComponentModel;

namespace CharpEvolution.Tests01.Calculados;

public enum Operadores
{
    [Description("+")]
    SOMAR,
    [Description("-")]
    SUBTRAIR,
    [Description("/")]
    DIVIDIR,
    [Description("*")]
    MULTIPLICAR
}

public interface ICalculoSimples
{

    public ICalculoSimples OutraOperacao { get; set; }
    void Calcular(Operadores operador,params decimal[] operandos);
}
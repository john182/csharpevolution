namespace CharpEvolution.Tests01;

public interface ICalculadora
{
    void Dividir(params decimal[] operandos);
    void Multiplicar(params decimal[] operandos);
    void Subtrair(params decimal[] operandos);
    void Somar(params decimal[] operandos);

    void Iniciar();
}
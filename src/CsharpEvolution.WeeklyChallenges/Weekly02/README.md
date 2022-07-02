## Exceções
É qualquer condição ou comportamento inesperado econtrado por um programado em execução.

Exceções sempre ocorre em lugares previsiveis de um programa, ou seja,
é possivel identificar onde possiveis exceções podem ocorer.  
Ex:

Exceções Aritimentiscas onde temos o mais famoso no qual é feito uma operação de divisão por 0;

30/0

Exceções com banco de dados onde tentanto fecha uma conexão que já pode está fechada.

```
  Passivo de erro
  conn.Close();
  
  Evitando uma acessão
  if (conn.State != ConnectionState.Closed)
  {
    conn.Close();
  }

```
 Como podemos ter uma previsibildiade de onde pode ocorrer uma exceção, logo também nos convem a escrever classes
que podem evitar exceções, ou seja, sua classe pode ter propriedades ou metodos que evitem o disparo de uma exceção.  
Ex:

```
class FileRead
{
    public void ReadAll(FileStream fileToRead)
    {
        // This if statement is optional
        // as it is very unlikely that
        // the stream would ever be null.
        if (fileToRead == null)
        {
            throw new ArgumentNullException();
        }

        int b;

        // Set the stream position to the beginning of the file.
        fileToRead.Seek(0, SeekOrigin.Begin);

        // Read each byte to the end of the file.
        for (int i = 0; i < fileToRead.Length; i++)
        {
            b = fileToRead.ReadByte();
            Console.Write(b.ToString());
            // Or do something else with the byte.
        }
    }
}
```

## Pilha de chamada
É uma pilha que armazena informações sobre as sub-rotinas ativas num programa de computador

## Pilha de chamada vs Exceções
No mecanismo de exceção (Desempilhamento), o controle move-se da instrução throw para a primeira instrução catch que pode manipular o tipo lançado.

Ex:

![img.png](img.png)

No programa acima ao ser execupado séra buscado um metodo Main e logo o programa ira tenta resolver o
**MetodoPrincipal()** antes de parti para **Console.ReadLine()** e ira 
ser feito o processo de empilhamento de execução ficando da seguinte forma:

```
Dividir <-
TestaDivisao
MetodoPrincipal
Main

```

No exemplo acima tentamos realizar uma divisão por 0 no qual o mecanimos ira desipilhar até encontrar um tratamento adequando para seu tratamento.

```
Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
   at Progam.Dividir(Int32 numero, Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 36
   at Progam.TestaDivisao(Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 29
   at Progam.MetodoPrincipal() in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 24
   at Progam.Main(String[] args) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 17
```

Note que ao rola a execução é feito um desimpilhamento até chega ao final que é o caso do metodo Man já que no foi encontrado nenhum tratamento.


## Caputar Exceções
Quando você precisa trata exceções que foram lançadas vc precisa envover o codigo com bloco **try{ }** seguido por um bloco **catch { }**

Ex: 
```
public static void Main(String[] args)
{
    MetodoPrincipal();

    Console.ReadLine();
}

private static void MetodoPrincipal()
{
    TestaDivisao (0);
}

private static void TestaDivisao(int divisor)
{
    try
    {
        var resultado = Dividir(10, divisor);

        Console.WriteLine("Resultado da divisão de 10 por {0} é {1}", divisor , resultado);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Não é possível dividir um número por 0!");
    }
}

private static int Dividir(int numero, int divisor)
{
    return numero / divisor;
}

Saida:
Não é possível dividir um número por 0!

```

## Relança Exceções

Geralmente precisa relação exceções quando queremos realizar alum procedimento e depois repassa a exceção como uma possivel geração de LOG ou etc.

Devemos ter cuidado em como iremos relançao essa exceção para não perdemos o controle de pilhar de exercução como foi mostrado acima.  
Irei mostra como relação uma exceções no qual perdemos o controle da Pilhar e outro matendo o controle de pilhar de exceção.

Ex:

![img_1.png](img_1.png)

No exemplo acima teremos o seguinte **StackTrace**:

```
Não é possível dividir um número por 0!
Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
   at Progam.MetodoPrincipal() in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 29
   at Progam.Main(String[] args) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 15
```

Note que relaçamos a exceção porem perdemos o controle total da pilhar como ocorreu no exemplo aterior que foi:

```
Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
   at Progam.Dividir(Int32 numero, Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 36
   at Progam.TestaDivisao(Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 29
   at Progam.MetodoPrincipal() in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 24
   at Progam.Main(String[] args) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 17
```

Para que possamos ter todo o controle de pilhar devemos fazer da seguinte forma:


```
public class Progam
{
    public static void Main(String[] args)
    {
        MetodoPrincipal();

        Console.ReadLine();
    }

    private static void MetodoPrincipal()
    {
        try
        {
            TestaDivisao(0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Não é possível dividir um número por 0!");
            throw;
        }
    }

    private static void TestaDivisao(int divisor)
    {
        var resultado = Dividir(10, divisor);

        Console.WriteLine("Resultado da divisão de 10 por {0} é {1}", divisor, resultado);
    }

    private static int Dividir(int numero, int divisor)
    {
        return numero / divisor;
    }
}
Saida:

Não é possível dividir um número por 0!
Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
   at Progam.Dividir(Int32 numero, Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 42
   at Progam.TestaDivisao(Int32 divisor) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 35
   at Progam.MetodoPrincipal() in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 24
   at Progam.Main(String[] args) in /home/john/projetos/c#/sololearn/atividade01/atividade01/Program.cs:line 15

```

## Finaly 

Imagine agora que mesmo ocorrendo uma exceção vc quer garantir algumas coisas como por exemplo o fechamento de um arquivo.
Nessa situação usando o bloco **finaly{}** para que possamos fechar uma coneção ou tr abertura de arquivo, algo que você precisa
que seja fechado ou liberado, para que libere recurso.

Ex :

```

StreamWriter stream = null;
try
{
    stream = File.CreateText(“meu_aquivo.txt”);
    throw new InvalidOperationException("ocorreu qualquer erro");
}
catch (InvalidOperationException ex)
{
   
   Console.WriteLine(ex.Message);
}
finally
{
   if (stream != null)
   {
      stream.Close();
   }
}

```

## NullReferenceException
A exceção que é gerada quando ocorre uma tentativa de desreferenciar um objeto de referência nula.

Um dos maiores problemas da linguagem Java e C#, realmente ai é que o bixo pega, porque significar que você deixou de fazer algo rsss.  
Exceção é gerada quando você tenta acessar um membro em um tipo cujo valor é null.

Pra evitar esse tipo de erro é aconselhavel criar Classe com uma tipagem que refletem bem o cenário, assim os compiladores atuais
podem lhe avisar que aquela propriedade ou objeto podem ser nulo.

Iniciar as variaveis sempre que possivel.


## Classes

É um conjunto de características e comportamentos que definem o conjunto de objetos ou propriedades ou metodos em comum.

Imagine um Carro, todo carro tem algumas caracteristas e comportamento como

Cor, portencia do motor, quantidade de portas, cãmbio automático e etc. Como o mesmo também possui comportamento como 
acelerar, desacelerar,acender farois, tocar musicar e etc.  
Podemos dizer então que que um carro novo é um objeto onde suas caracteristicas são seus atributos e que seu comportamento são 
ações ou métodos.

![img_2.png](img_2.png)


Abstraindo um pouco a analogia, uma classe é um conjunto de características e comportamentos que definem o conjunto de objetos pertencentes à essa classe.

### Exemplo


```

public class Carro
{
    public string Cor { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public int QuantidadePortas { get; set; }

    public void Acelerar()
    {
        // implementar
    }
    
    public void Frear()
    {
        // implementar
    }
    
    public void TocaMusica()
    {
        // implementar
    }
    
    public void LigarArCondicionado()
    {
        // implementar
    }
}

```

## Encapsulamento

Ainda usando a analogia do carro, sabemos quer ele possui algumas caracteristicas e comportamentos. O método acelerar altera
a velocidade atual do carro, como tambem seu consumo de combustivel.

No entando se algumas dessas caracteristicas que sofrem alteração diante de um comportamente, que apenas o comportamente deve alterar o seu valor
puder ser alterado facilmente, podemos ter como resultado efeitos colaterais imprevisiveis.

Tais como seu carro está acelerando e se encontra em uma velocidade atual de 100km e do nada ele passa a valer 0km, sem ter ocorrido uma
frenagem ou falta de combustivel. 

Então nesse caso a velocidade atual do carro não está visil para alteração por fora do proprio carro.

Então como sabemos como nosso carro acelerar, não sabemos, o que precisamos saber é que para acelerar precisamos pisar no 
acelerador, cabe ao carro saber como é feito para acelerar o carro. Assim podemos dizer que a velocidade do carro está 
**encapsulada**.


![img_3.png](img_3.png)

### Exemplo


```
public class Carro
{
    public string Cor { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public int QuantidadePortas { get; set; }
    public double VelocidadeAtual { get;private set; }
    public double CombustivelAtual { get;private set; }
    
    public void Acelerar(int tempoSeg)
    {
        VelocidadeAtual += tempoSeg * 10;
        UsarMaisCombustivel();
        
    }
    
    public void Frear(int tempoSeg)
    {
        VelocidadeAtual -= tempoSeg * 15;
    }
    
    public void LigarArcondicionado()
    {
        
    }

    private void UsarMaisCombustivel()
    {
        CombustivelAtual -= VelocidadeAtual * 0.0003;
    }
}

```

Como pode nota tanto a foi encapsulada a propriedade CombustivelAtual e VelocidadeAtual, para não sofre alterações externas
como também o método UsarMaisCombustivel está visivel somente para o carro. Assim podemos evitar efeitos colaterais como do nada o carro ficar sem combustivel
ou ficar parado.

## Herança
No nosso exemplo anterior você viu que nosso carro ele possuei algumas caracteristicas e também comportamentos agora imagine o seguinte
Imagine que possar ter um modelo de carro no qual ele faz as mesmas coisa e tenha quase todas as suas caracteristicas
abstraindo para o mundo real imagine que na nossa loja de carros podemo ter um Honda Civic com Cambio manual e automatico
podemos nota que temos somente nota que temos uma pequena diferença no caso.

![img_4.png](img_4.png)

Podemos dizer quer uma Classe A é um tipo de classe B, dizemos que a classe **A** herda as caracteristica da classe **B**

## Exemplo


```

public enum TipoCambio
{
    AUTOMATICO,
    MANUAL
}

public class Carro
{
    public string Cor { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public int QuantidadePortas { get; set; }
    public double VelocidadeAtual { get;private set; }
    public double CombustivelAtual { get;private set; }
    public TipoCambio TipoCambio { get; set; }
    
    
    public Carro(string modelo,TipoCambio tipoCambio)
    {
        modelo = modelo;
        TipoCambio = tipoCambio;    
    }

}

public class HondaCivicPeDuro:Carro
{

    public HondaCivicPeDuro() : base("HondaCivicPeDuro",TipoCambio.MANUAL)
    {
    
    }
}

public class HondaCivicSit:Carro
{

    public HondaCivicPeDuro() : base("HondaCivicSit",TipoCambio.AUTOMATICO)
    {
    
    }
}

```

Como podem observa temos dois modelo de carros diferente, porem com as mesma caracteristica da **Classe Carro**.

## Polimorfismo


















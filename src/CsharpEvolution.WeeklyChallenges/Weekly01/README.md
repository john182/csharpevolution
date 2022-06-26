
## Condicionais

É uma estrutura que indica quais instruções o sistema deve processar de acordo com uma expressão booleana
Exemplo:

#### IF/ELSE

```
if (expressão booleana)
{
  // se verdade entra aqui
}
else
{
  // se falso entra aqui
}
```

Para facilitar o entendimento segue um fluxo grama:

![img.png](img.png)

Estrutura condicional composta:

![img_1.png](img_1.png)

Há uma outra forma também de escrever a mesma estrutura, conhecido como operador ternario;

```
expressão booleana ? código 1 : código 2;
exmeplo:

var numero = 10;

parOuImpa = numero % 2 == 0 "é par": "é impar":

Console.WrteLine(parOuImpa);

Saida: é par
 
```

## Switch/Case

É uma estrutura de condição que define o código a ser executado com base em uma comparação de valores.


```
switch (variável)
{
case valor1:
      // código 1      
break;
case valor2:
      // código 2
}
```

Note o uso do **break** é utilizado para especificar a última linha de código a ser executada, caso
não exista ele iria exeucat o outro trecho de comparação.
Exemplo:

```
switch (variável)
{
case valor1:
case valor2:
      // código para caso que ocorra no valor1 e valor2
break;
case valor3:
     // codigo
break;     

}
```

![img_2.png](img_2.png)

## Loops
Executam repetidamente uma instrução ou um bloco de instruções, são eles:

* **FOR**
* **FOREACH**
* **WHILE**
* **DO WHILE**


#### FOR

Executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true.

```

for (int i = 0; i < 3; i++)
{
    Console.Write(i);
}

// Saida:
// 012

```

#### FOREACH
Executa uma instrução ou um bloco de instruções para cada elemento.

```
var frutas = new List<string> { "Laranja", "Limão", "Uva"};


foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

 Saida:
 Laranja
 Limão
 Uva

```

#### WHILE

Executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true.

```
int n = 0;
while (n < 5)
{
    Console.Write(n);
    n++;
}
 Saida:
 01234

```

#### DO WHILE

Executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true.
Diferente do **WHILE** ele ao menos é executado pelo meno uma unica vez.

```
int n = 0;
do
{
    Console.Write(n);
    n++;
} while (n < 5);
 saida:
 01234
 
int n = 5;
do
{
    Console.Write(n);
    n++;
} while (n < 5);
 saida:
 5 

```

## Operadores

Os operadores são divididos em alguns grupos:

- Operadores aritméticos: que executam operações aritméticas com operandos numéricos
- Operadores de comparação: que comparam operandos numéricos
- Operadores lógicos boolianos: que executam operações lógicas com bool operandos
- Operadores bit a bit e shift que executam operações bit a bit ou shift com operandos dos tipos integrais
- Operadores de igualdade: que verificam se seus operandos são iguais ou não

#####Operadores Aritméticos:


| Símbolo | Operação      | Exemplo | Descrição                                                                |
| ---------- | ----------------- | --------- | ---------------------------------------------------------------------------- |
| **+**    | Adição        | a + b   | Soma os dois operandos                                                     |
| **-**    | Subtração     | a - b   | Subtrai o segundo operando do primeiro                                     |
| \*       | Multiplicação | a\* b   | Multiplica os dois operandos                                               |
| **/**    | Divisão        | a / b   | Divide o primeiro operando pelo segundo                                    |
| **%**    | Módulo         | a % b   | Divide o primeiro operando pelo segundo operando e produz a parte restante |

Vale Resaltar que as operações seguem a procedencia como nas operações matematicas.

##### Operadores de comparação:


| Símbolo | Operação         | Exemplo | Descrição                                      |
| ---------- | -------------------- | --------- | -------------------------------------------------- |
| **>**    | Maior que          | a > b   | Verdadeira se**a** for maior que **b**.          |
| <        | Menor que          | a < b   | Verdadeira se**a** for menor que **b**           |
| **>=**   | Maior ou igual que | a >= b  | Verdadeira se**a** for maior ou igual que **b**. |
| <=       | Menor ou igual que | a <>= b | Verdadeira se**a** for menor ou igual que **b**. |
| **==**   | Igual a            | a == b  | Verdadeira se**a** igual a **b**.                |
| **!=**   | Diferente de       | a != b  | Verdadeira se**a** for diferente de **b**.       |

##### Operadores Lógico:


| Símbolo | Operação | Exemplo                      | Descrição                                                                                                                                                                           |
|---------|----------|------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **&**   | E        | Exp1 **&** Exp2              | Verdadeira se expr1 e expr2 forem verdadeiras.                                                                                                                                      |
| **&&**  | E        | Exp1 **&&** Exp2 **&&** Exp3 | Verdadeira se expr1 e expr2 e exp3 forem verdadeiras. Detalhe aqui é que se a expressão 1 ou 2 forem false ele não ira vericar a expressão 3. Também conhecido como curto circuito  |
| **!**   | Ou       | Exp1 **!**  Exp2             | Verdadeira se expr1 ou expr2 forem verdadeiras.                                                                                                                                     |
| **!!**  | Ou       | Exp1 **!!** Exp2 **!!** Exp3 | Verdadeira se expr1 ou expr2 ou exp3 forem verdadeiras. Detalhe aqui é que se a expressão 1 ou 2 forem true ele não ira vericar a expressão 3. Também conhecido como curto circuito |  

OBS: coloquei o **!** como **OU** porque não conseguir representa ele aqui, por ser uma palavra reservada


## Métodos
É um bloco de código que contém uma série de instruções que podem ou não retorna algum valor ou podem ou não receber algum parametro. Métodos são declarados em uma classe,struct ou interface.


```

public decimal Somar(decimal valor1, decimal valor2)
{
  return valor1 + valor2;
}

public void Imprimir()
{
  Console.WriteLine("alguma informação");
}

```
## Sobrecarga
O C# permite que nós tenhamos vários métodos com o mesmo nome desde que sua assinatura seja diferente.
O compilador trata um método sobrecarregado, quando este método for chamado, da seguinte maneira: primeiramente o compilador selecionará o método correto examinando o numero, em seguida os tipos e por fim a ordem dos argumentos da chamada

```

public void Imprimir()
{
  Console.WriteLine("alguma informação será impressa");
}

public void Imprimir(string info)
{
  Console.WriteLine(" a informação {0} foi  impressa {0}",info);
}

```



## NameSpace

São usado com frequência para Organizar tipos, outra coisa que podemos fazer também é fazer o uso de qualquer classe quando importando o seu nameSpace usando a palavra reservada using.
Exemplos:

Sem o uso do nameSpance:

```
System.Console.WriteLine("Hello World!");
string path = @"c:\temp\MyTest.txt";
bool exist = Sistem.IO.File.Exists(path);

```

Com o uso do NameSpace:

```
using System;
using System.IO;

Console.WriteLine("Hello World!");
string path = @"c:\temp\MyTest.txt";
bool exist = File.Exists(path);
```

Como também podemos nota foi organizado dentro de outro NameSpace IO o File Classe, ou seja em projetos de muitos arquivo é fundamento o uso de NameSpace para melhor organizar e da ideia de onde podemos encontrar o que desejamos.

## Classes

É um tipo de dados formado por dados e comportamento

```
class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Imprimir()
    {
        Console.WriteLine("{0}, {1} anos.", nome, idade);
    }
}

Pessoa joao = new Pessoa("João",30);
Pessoa maria = new Pessoa("Maria",25);
Pessoa jose = new Pessoa("Jose",36);

joao.Imprimir();
maria.Imprimir();
jose.Imprimir();


/* saida:
    Pessoa #1: João, 30 anos.
    Pessoa #2: Maria, 25 anos.
    Pessoa #3: Jose, 36 anos.
*/
```

Observe que a propriedade nome e idade só teve acesso no metodo construto da class no qual será preenchido ao instancia um novo objeto.

## Structs

É um tipo de valor(Value Types) que pode encapsular dados e funcionalidades relacionadas.

```
public struct Pessoa
{
     public string nome { get; }
     public int idade { get; }

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Imprimir()
    {
        Console.WriteLine("{0}, {1} anos.", nome, idade);
    }
}

Pessoa joao = new Pessoa("João",30);
Pessoa maria = new Pessoa("Maria",25);
Pessoa jose = new Pessoa("Jose",36);

joao.Imprimir();
maria.Imprimir();
jose.Imprimir();


/* saida:
    Pessoa #1: João, 30 anos.
    Pessoa #2: Maria, 25 anos.
    Pessoa #3: Jose, 36 anos.
*/

```

Apesar da grande semenhança em relação a classe temos algumas diferente:

- Struct são tipos de valores e Classes são tipo de referencia(Reference Types)
- Quando se atribui um valor de uma variável com valor de outra variável, é sempre feita uma cópia do conteúdo e não feita a referência
- Um tipo de estrutura não pode herdar de outro tipo de classe ou estrutura e não pode ser a base de uma classe. No entanto, um tipo de estrutura pode implementar interfaces.
  Você não pode declarar um finalizador dentro de um tipo de estrutura.
- Antes do C# 11, um construtor de um tipo de estrutura deve inicializar todos os campos de instância do tipo.
- Antes do C# 10, você não pode declarar um construtor sem parâmetros.
- Antes do C# 10, você não pode inicializar um campo de instância ou propriedade em sua declaração.

## Certo então quando devemos usar Struct ao ivens de Class??? o.O

Bom os melhores candidatos para viram Struct são os Data Transfer Objects, que são os famosos DTO.
OBS: é a minha opinião, você também pode usa onde a classe faz apenas simples operações.

# Contrutores
São metodos cujo seu nome é igual ao seu tipo. Construtores são executado quando uma Slasse ou Struct é criada.  
Contrutores permitem que sejá definidos valores padrão quando for executado.

Exempo:

```
public Class Pessoa {

    public string nome { get;set; }
    public int idade { get;set; }

    public Pessoa()
    {
 
    }
    
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

}

Pessoa joao = new Pessoa("João",30);
Pessoa maria = new Pessoa();

maria.Nome = "Maria";
maria.idade = 20;

```

Obseve que no objeto do tipo pessoa joão iniciamos como alguns valores, equanto no objeto maria setamos seus valores individualmente
veja que no exemplo acima temos mais de um construtor, podemos ter mais de um construto mais com assinaturas diferente.


## Destrutores
São metodos cujo seu nome é igual ao seu tipo precedido por **~**. Destrutores são executado quando um objeto é destruido, quem fica a cargo dessa tarefa é o
GC(Garbage Collector). não possivel chamado diretamente.

```
class First
{
    ~First()
    {
        System.Diagnostics.Trace.WriteLine("First's finalizer is called.");
    }
}

class Second : First
{
    ~Second()
    {
        System.Diagnostics.Trace.WriteLine("Second's finalizer is called.");
    }
}

class Third : Second
{
    ~Third()
    {
        System.Diagnostics.Trace.WriteLine("Third's finalizer is called.");
        
    }
}

class Program
{
    static void Main()
    {
        Third t = new Third();
        t = null;
        
    }
}

Saida:
Third's finalizer is called.
Second's finalizer is called.
First's finalizer is called.

```
* Os finalizadores não podem ser definidos em structs. Eles são usados somente com classes.
* Uma classe pode ter somente um finalizador.
* Os finalizadores não podem ser herdados ou sobrecarregados.
* Os finalizadores não podem ser chamados. Eles são invocados automaticamente.
* Um finalizador não usa modificadores ou não tem parâmetros.




## Níveis de acessibilidade

Niveis de acesso também conhecido como **Modificadores de acesso** ou como **Encapsulamento** que é um dos pilares da programação OO.  
Usamos modificadores de acesso para evitar que algum dados ou metodos sofram acesso indevidos, dentros os modificadores de acesso temos:
* **public:**	O acesso não é restrito.
* **protected:**	O acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
* **internal:**	O acesso é limitado ao assembly atual.
* **protected internal:**	O acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.
* **private:**	O acesso é limitado ao tipo recipiente.
* **private protected**:	O acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual. Disponível desde o C# 7.2.



## System.Text

#### StringBuilder
O StringBuilder é usado quando vc deseja manipular diversas vezes uma cadeia de caractres sem ser preciso criar um novo objeto já que o System.String é imutavel 
e todas vez que uma cadeias de caractres é alterado é criado um novo objeto na mémoria.

Segue alguns metodos:
* Append: pode ser usado para adicionar texto
* Insert: pode ser usado para adicionar texto em uma posição especifica
* Remove: pode ser usado para remover uma parte especifica do texto
* Replace: pode ser usado para substitui texto

Exemplos:

```
StringBuilder myStringBuilder = new StringBuilder("Bem vido ao mundo de desenvolvimento");
myStringBuilder.Append(" em C#.");
Console.WriteLine(myStringBuilder);

saida: Bem vido ao mundo de  desenvolvimento em C#.

StringBuilder myStringBuilder = new StringBuilder("Bem vindo ao mundo de desenvolvimento em C#.");
myStringBuilder.Insert(9," brow");
Console.WriteLine(myStringBuilder);

saida: Bem vindo brow ao mundo de desenvolvimento em C#.

StringBuilder myStringBuilder = new StringBuilder("Bem vindo brow ao mundo de desenvolvimento em C#.");
myStringBuilder.Remove(10,5);
Console.WriteLine(myStringBuilder);

saida: Bem vindo ao mundo de desenvolvimento em C#.

StringBuilder myStringBuilder = new StringBuilder("Bem vindo brow ao mundo de desenvolvimento em C#.");
myStringBuilder.Replace(".","!!!");
Console.WriteLine(myStringBuilder);

saida: Bem vindo brow ao mundo de desenvolvimento em C#!!!

```
#### Encoding

Converte um conjunto de caracteres em uma sequência de bytes

```

string texto = "Convertendo string para array de byte";  
  
byte[] bytes = Encoding.ASCII.GetBytes(texto);

string textoConvertido = Encoding.UTF8.GetString(bytes);
        
Console.WriteLine(textoConvertido);

saida: Convertendo string para array de byte

```

#### Normalize

Retorna uma nova cadeia de caracteres cuja representação binária está em um formulário de normalização Unicode específico.


```
var teste = "café".Normalize(NormalizationForm.FormKD) .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)  
            .ToArray();
        
Console.WriteLine(teste);

saida: cafe

```

## System.Threading

#### Thread
São mecanimos que permite ter mais de um fluxo de controle na aplicação.

```

    public static void Main(String[] args)
    {
        Thread.CurrentThread.Name = "Principal";
        
        Thread t1 = new Thread(ThreadProc)
        {
            Name = "Secundária - "
        };
        t1.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread Atual - {0} {1}", Thread.CurrentThread.Name, i);

            Thread.Sleep(1000);
        }
    }

    private static void ThreadProc() {
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Thread Atual - {0} {1}", Thread.CurrentThread.Name, i);
            Thread.Sleep(1000);
        }
    }
    
saida:
    
Thread Atual - Principal 0
Thread Atual - Secundária 0
Thread Atual - Principal 1
Thread Atual - Secundária 1
Thread Atual - Principal 2
Thread Atual - Secundária 2
Thread Atual - Principal 3
Thread Atual - Secundária 3
Thread Atual - Principal 4
Thread Atual - Secundária 4

```

#### Time
Permite chamar um delegado continuamente em intervalos de tempo especificado.

Segue um exemplo de uma aplicação pratica ondem temos uma aplicação que criar orcamentos em tempos e tempos é verificado a existencias de novos orcamentos e faturado.

```

public class Progam
{
    
    private static Timer? _timer;

    private static readonly IList<Orcamento> _orcamentos = new List<Orcamento>();

    private static bool _exiteProcessamento = true;

    public static void Main(String[] args)
    {
        var timerState = new TimerState { Counter = 0 };

        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: iniciado processo");
        
        _timer = new Timer(
            callback: TimerTask,
            state: timerState,
            dueTime: 1000,
            period: 2000);
        
        Thread t1 = new Thread(ThreadCriarOrcamentos)
        {
            Name = "Thread Orcamentos - "
        };
        t1.Start();

        while (_exiteProcessamento)
        {
            Task.Delay(2000).Wait();
        }
        
        Console.WriteLine("Total de Orcamentos faturado {0} ",timerState.Counter);

        _timer.Dispose();
        
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: processo finalizado.");
    }

    private static void TimerTask(object timerState)
    {
       
       
        var state = timerState as TimerState;

        var orcamentosAberto = _orcamentos.Where(o => o.Faturado == false);
        
        foreach (var orcamento in orcamentosAberto)
        {
            Console.WriteLine("Orcamento de Número {0} faturado",orcamento.Numero);
            orcamento.Faturado = true;
        }
        
     
        
        Interlocked.Increment(ref state.Counter);
    }
    
    private static void ThreadCriarOrcamentos() {
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: iniciada janela de criação de orcamento.");
        for (int i = 0; i < 5; i++) {
            _orcamentos.Add(new Orcamento(i +1));
            Thread.Sleep(1000);
        }
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: finalizada janela de criação de orcamento.");
        _exiteProcessamento = false;
    }

    class TimerState
    {
        public int Counter;
    }
    
    class Orcamento
    {
        public bool Faturado { get; set; }
        public int Numero { get; }
        public Orcamento(int numero)
        {
            Numero = numero;
        }
    }
}

```

#### ThreadPool

Fornece um pool de threads que podem ser usados para executar tarefas.

Podemos ter um conjuto de threads(ThreadPool), deixando disponivel conforme o uso nescessário.


```

public class Progam
{
    


    public static void Main(String[] args)
    {
        ThreadPool.QueueUserWorkItem(UmaThreadQualquer);  
        Console.WriteLine("Thread Principal");  
        Thread.Sleep(500);  
        
        Pessoa p = new Pessoa("Fulano");  
        ThreadPool.QueueUserWorkItem(ThreadComInformacoes, p);  
        
        
        int threads, portas;  
      
        // Buscando numero de threads 
        ThreadPool.GetMaxThreads(out threads, out portas);  
        Console.WriteLine($"Maximo  threads: {threads} ");  
        Console.WriteLine($"Minimo port threads: {portas}");  
        
        
        // Recupera a diferença entre o número máximo de threads do pool de thread
        ThreadPool.GetAvailableThreads(out threads, out portas);  
        Console.WriteLine($"Availalbe worker threads: {threads} ");  
        Console.WriteLine($"Available completion port threads: {portas}");  


        // definimo minimo de thread  
        int minWorker, minIOC;  
        ThreadPool.GetMinThreads(out minWorker, out minIOC);  
        ThreadPool.SetMinThreads(4, minIOC);  
        
        // número total de processos disponíveis na máquina
        int processCount = Environment.ProcessorCount;  
        Console.WriteLine($"No. of processes available on the system: {processCount}"); 
    }


    static void UmaThreadQualquer(Object stateInfo)  
    {  
        Console.WriteLine("Outra Thread trabalhando dentro do pool");  
        Thread.Sleep(1000);          
    }  
    
    static void ThreadComInformacoes(Object stateInfo)
    {
        var pessoa = stateInfo as Pessoa;
        Console.WriteLine($"{pessoa.Nome} realizando algo dentro da ThreadPool.");  
        Thread.Sleep(1000);  
    }  

    class Pessoa
    {
        public string Nome { get; }
       

        public Pessoa(string nome)
        {
            Nome = nome;
       
        }
    }
}

```

## System.Linq

#### Enumerable

* São coleçoes somente leitura, não permite ser alterado.
* Possui um método para retornar o próximo item, ou seja, não precisa que toda lista seja já armazenado na memoria.


```
    IEnumerable<int> numeros = new[] { 5, 15,69,45 };
        
    Console.WriteLine("Maior número {0}", numeros.Max());
    Saida: 69
    
    Console.WriteLine("Menor número {0}", numeros.Min());
    Saida: 5
    Console.WriteLine("Soma número {0}", numeros.Sum());
    Saida: 134
    
    Console.WriteLine("Quantidade  {0}", numeros.Count());
    Saida: 4
```

#### Queryable

Fornece um conjunto de métodos static (Shared no Visual Basic) para consultar estruturas de dados que implementam IQueryable<T>.
Geralmente é usada quando estamos fazendo queries com LINQ.

A IQueryable<T> interface destina-se à implementação por provedores de consulta.

Essa interface herda a IEnumerable<T> interface para que, se ela representa uma consulta, os resultados dessa consulta possam ser enumerados. A enumeração força a árvore de expressão associada a um IQueryable<T> objeto a ser executado. As consultas que não retornam resultados enumeráveis são executadas quando o Execute<TResult>(Expression) método é chamado.

```
   int[] array = new int[2];
   array[0] = 230;
   array[1] = 186;

   var items = array.AsQueryable(); 
   Console.WriteLine($"Média: {items.Average()}");
   Console.WriteLine($"Soma: {items.Sum()}");
   
   Saida:
   Média: 208
   Soma: 416


```
A interface IQueryable é útil quando você esta consultando uma coleção que foi carregada usando LINQ ou Entity Framework e você quer aplicar um filtro nesta coleção.






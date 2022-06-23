
## Condicionais

É uma estrutura que indica quais instruções o sistema deve processar de acordo com uma expressão booleana
Exemplo

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
Há uma outra forma também de escrever a mesma estrutura, conhecido como operador ternario;

```
expressão booleana ? código 1 : código 2;
exmeplo:

var numero = 10;

parOuImpa = numero % 2 == 0 "é par": "é impar":

Console.WrteLine(parOuImpa);

Saida: é par
 
```

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






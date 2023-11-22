-StackOverflow: site pra ajudar como faz as coisas.

!C#!
//Em C# Usa {} para determinar oq vai dentro, não usa : q nem python
//Cada comando tem q terminar com ";"(semicolons). So coisas q tem corpo q nao precisam, tipo o if.

!Variaveis!
//Nome das variaveis é assim "firstName" não "first_name"
//Em C# as variaveis tem q ser declaradas antes, e não podem ser mudadas depois
Ex: int x;   ou   int x = 5;
//MAS da pra mudar o tipo do valor antesde colocar na variavel usando int.Parse(). 
Ex: 
Console.Write("What is your favorite number? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
//Pra mudar de int pra string usa .ToString()
Ex: int number = 42;
string textVersion = number.ToString();

Variaveis comuns:
int // Integers (whole numbers, positive and negative)
string // Strings (a sequence of characters, including letters, numbers, or symbols)
float // Floating point numbers (numbers that use decimals)
double // Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
bool // Boolean variables (true or false)

!Print!
Console.WriteLine("Hello World!"); Vai criar uma nova linha no final
Console.Write("There will not be a newline after this."); Não vai criar uma nova linha no final
//Pra printa uma variavel usa $, que nem o f no python
Ex: Console.WriteLine($"I am studying at {school}.");

!Input!
Console.ReadLine() Retorna uma string, não importa oq escreverem, sera uma string
//Não escreve nada, entao tem q printa antes 
Ex:Console.Write("What is your favorite color? ");
string color = Console.ReadLine();

!if!
//A condição tem q ta dentro do ()
if (x > y)
{
  Console.WriteLine("greater");
}
//'else' e 'else if' são q nem em python, so que não é elif, é else if

!Operators!
== 
!=
>=
<=
&& é o and em python
|| é o or em python
! é o not em python
Ex:if (!(name == "Peter" || name == "James" || name == "John"))
{
    Console.WriteLine("This is a not one of those three");
}

!Loops!
//While: igual ao python
Ex: string response = "yes";
while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}
//Do-While: Faz uma vez, dai ve se vai fazer de nv se cumprir as paradas
Ex: string response;
do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");
//For: É como so fosse o "for range" do python. O "i++" quer dizer q vai de um a um, se for "i + 2" vai de 2 em 2
Ex: for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}                           Vai de 0 a 9
//Foreach: É tipo o "for" do python
Ex: foreach (string color in colors)
{
    Console.WriteLine(color);
}

!Random!
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);
//Inclui o primeiro numero, mas não o segundo, entao vai de 1 a 10.

!List! (Listas)
//Tem q declarar q é uma lista(e qual tipo de lista), depois criar a lista
Ex: List<int> numbers = new List<int>();
List<string> words = new List<string>();  // O parenteses no final vem sempre depois q cria algo
//Any file that uses Lists (or any other standard collection), must refer to that library at the top of the file. (This is so common that sometimes your settings for C# can be specified so that you do not not have include this, but it is important to know about it, in case you run into problems.)
Ex: using System.Collections.Generic;
//Add(). Adicionar itens na lista
Ex: using System.Collections.Generic;
...
List<string> words = new List<string>();
words.Add("phone");
words.Add("keyboard");
words.Add("mouse");
//Contar o tamanho da lista usar "Count" 
Ex: Console.WriteLine(words.Count);
//The easiest (and safest) way to iterate through a list in C# is to use the foreach loop:
Ex: foreach (string word in words)
{
    Console.WriteLine(word);
}
-Index. 
Ex: for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}

!Function!
//Nome tem q começar com letra maiuscula
//Tem q declarar q tipo de retorno vai dar e dos parametros, string, int ou nada (void)
Ex: returnType FunctionName(dataType parameter1, dataType parameter2)
//void
Ex: void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}
//static. This tells C# that you want your functions to be able to be called without any other context.
Ex: static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}

!Classes! (class)
//São para simplificar coisas mais complexas
//Tem o nome, atributos e metodos.
//Classe e metodos usam nomes em TitleCase
//E para member variable names usa _underscoreCamelCase
Ex: // A code template for the category of things known as Person. The
// responsibility of a Person is to hold and display personal information.
public class Person
{
    // The C# convention is to start member variables with an underscore _
    public string _givenName = "";
    public string _familyName = "";
    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Person()
    {
    }
    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}
//Classe é so um template, não a parada util em si
//Pra ser util faz assim:
Ex: Person person = new Person();
person._givenName = "Joseph";
person._familyName = "Smith";
person.ShowWesternName();
person.ShowEasternName();
//O resultado: 
Joseph Smith
Smith, Joseph
//O bom de usar classes é que da pra trabalhar com multiplas situações
Ex: person1 = new Person();
person1._givenName = "Emma";
person1._familyName = "Smith";
person1.ShowWesternName();
person2 = new Person();
person2._givenName = "Joseph";
person2._familyName = "Smith";
person2.ShowWesternName();
//O resultado:
Emma Smith
Joseph Smith
//Muitas pessoas usam a palavra "objeto" para se referir a uma instância de uma classe também
Classe // Um novo tipo de dados personalizado que define atributos (variáveis de membro) e métodos. Isso é como um projeto para criar instâncias ou objetos dessa classe. 
Ex: //Uma pessoa deu nome e sobrenome.
Instância // Uma variável cujo tipo de dados é a classe. Muitas vezes usamos o termo Objeto de forma intercambiável. 
Ex: //Podemos ter duas instâncias da classe Pessoa: uma para João e outra para Maria.
Instanciar // Um verbo que significa "criar uma instância de". 
Ex: //Podemos instanciar a classe Person para criar um novo objeto.
Método // Uma função de membro. Os métodos são chamados usando "notação de ponto" com uma instância da classe antes do ponto. 
Ex: //pessoa1.GetEasternName()

!Constructors! (construtores)
Person p = new Person(); // This calls a no-argument constructor and doesn't need any information

Ex: public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
    public Person() {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }
    public Person(string first, string last){
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last){
        _title = title;
        _firstName = first;
        _lastName = last;
    }
Person p1 = new Person(); // Don't pass any information to get the default values
Person p2 = new Person("Jane", "Doe"); // pass the first and last names
Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables



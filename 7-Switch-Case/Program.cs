//Calculadora utilizando Switch Case

//Entrada
 Console.WriteLine(@$"
 Programa Calculadora
 Informe a operação matemática que deseja efetuar:
 '+' para somar;
 '*' para multiplicação;
 '-' para subtração;
 '/' para divisão.
 ");
 

//Recebe a operação escolhida
char operacao = char.Parse(Console.ReadLine());

//Entrada do primeiro número
Console.WriteLine($"Digite o primeiro número: ");
float numero1 = float.Parse(Console.ReadLine());

//Entrada do segundo número
Console.WriteLine($"Digite o segundo número: ");
float numero2 = float.Parse(Console.ReadLine());

//Declarando a variável que receberá o resultado
float resultado = 0;

//Processamento
switch (operacao)
{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é {resultado}");
        break;

    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        break;

    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"O resultado da subtração é {resultado}");
        break;

    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"O resultado da divisão é {resultado}");
        break;

    default:
        Console.WriteLine($"A operação informada não é suportada pela nossa calculadora");
        break;
}
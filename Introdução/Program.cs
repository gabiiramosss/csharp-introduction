// string name = "gabi";
// Console.WriteLine(name);

// int idade = 36;
// Console.WriteLine("A idade da " + name + " é " + idade + " anos");

// float preco = 10.95F; caso hajam casas decimais é necessário colocar o f no final para indicar que é flutuante.

// bool careca = false;
// Console.WriteLine(careca);

// Operadores

// atribuição = 
// int x = 15;

// Operadores aritméticos
// soma 
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5 + x);

// subtração
// Console.WriteLine(15 - 3);

// divisão
// Console.WriteLine(10 / 10);

// multiplicação
// Console.WriteLine(5 * 5);

// modular
// Console.WriteLine(5 % 2); usado para descobrir se o número é par ou impar

//Operadores de comparação (responde com true ou false)
// igual a 
// Console.WriteLine(5 == 5);

// maior ou igual a 
// Console.WriteLine(5 >= 4);

// menor ou igual a 
// Console.WriteLine(4 <= 10);

// maior que
// Console.WriteLine(150 > 95);

// menor que 
// Console.WriteLine(54 < 87);

// diferente de 
// Console.WriteLine(5 != 6);

// Operadores lógicos
// || : ou
// && : e
// ! : não

// Console.WriteLine(5 == 5 && 8 == 8); TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 5); TRUE && FALSE = FALSE
// Console.WriteLine(5 == 7 && 8 == 8); FALSE && TRUE = FALSE
// Console.WriteLine(9 == 5 && 8 == 5); FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 && 3 == 3); TRUE && TRUE = TRUE
// Console.WriteLine(2 == 2 && 3 == 4); TRUE && FALSE = TRUE
// Console.WriteLine(2 == 4 && 3 == 3); FALSE && TRUE = TRUE
// Console.WriteLine(2 == 4 && 3 == 5); FALSE && FALSE = FALSE

// A ordem do resultado depende do operador. O programa lê na mesma ordem de precedência da lista
// Console.WriteLine((2 == 4 || 4 == 4) && (7 == 6)) FALSE

// Crie um programa para calcular o IMC de uma pessoa

// Algoritmo
// entrada: nome, idade, peso, altura
// processamento: peso dividido por altura ao quadrado

//entrada
string nome = "Gabi";
// int idade = 17;
float peso = 53.5f;
float altura = 1.53f;

//processamento
float imc = peso / (altura * altura);

//saída
Console.WriteLine("O IMC da " + nome + " é de : " + Math.Round(imc, 2)); //Math.Round é usado para arredondar números, o 2 após a vírgula é a quantidade de casas desejadas
// Faça um programa que receba o nao de nascimento de uma pessoa e calcule a idade dessa pessoa em anos e semanas e imprima o resultado no console

//Obs.:obter a data atual do sistema (pesquisar na documentação)

int anoNascimento;
int idade;
int idadeEmSemanas;
int anoAtual = DateTime.Now.Year;

Console.WriteLine($"Digite seu ano de nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
idadeEmSemanas = (idade * 52);

Console.WriteLine($"Sua idade em anos é {idade} anos, corresponde também a {idadeEmSemanas} semanas.");
// //criamos um array (lista) que vai armazenar até 3 elementos
// string[] carros = new string[3];

// //atribuimos para cada posição um valor
// carros[0] = "Tesla";
// carros[1] = "Maverick";
// carros[2] = "Celta 94";

// // carros[3] = "Ferrari";

// Console.WriteLine($"Os carros cadastrados são: {carros[0]}, {carros[1]}, {carros[2]}");

//criar um array de strings para armazenar 3 carros
// string[] carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Informe o nome do carro: ");    
//     carros[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Lista dos carros cadastrados: ");

// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");    
// }

// foreach (var item in carros)
// {
//     Console.WriteLine(item);    
// }




// //Criar um programa em C# que receba 5 números inteiros e ao final exiba o seu dobro
// //Deve-se utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estruitura foreach para exibí-los

// //entrada
//     //criar o array tamanho 5
//     int[] arrayNumeros = new int[5];
// //processamento
//     //receber os números (for)
//     for (int indice = 0; indice < 5; indice++)
//     {
//         Console.WriteLine($"Insira o {indice + 1} número");
//         arrayNumeros[indice] = int.Parse(Console.ReadLine());
//     }
// //saída
//     //exibir os números (foreach)
//     foreach (var numero in arrayNumeros)
//     {
//         Console.WriteLine($"O dobro de {numero} é {numero * 2}");  
//     }

//Exercício de fixação

//Escreva um programa que receba e imprima o nome e idade de 5 pessoas

//entrada
    //criar os arrays
    string[] nomes = new string[5];
    int[] idades = new int[5];

//processamento
    //receber os dados (for)
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Digite o {i + 1}º nome:");
        nomes[i] = Console.ReadLine();

        Console.WriteLine($"Digite a {i + 1}ª idade:");
        idades[i] = int.Parse(Console.ReadLine());
    }

//saída
    //imprimir os dados
    for (int i = 0; i < 5; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{i + 1}º Nome: {nomes[i]}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"   Idade: {idades[i]} anos");

        Console.WriteLine($"");

        Console.ResetColor();
    }
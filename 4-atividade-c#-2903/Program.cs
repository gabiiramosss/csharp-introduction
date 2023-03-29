//Entrada
Console.WriteLine($"Digite seu nome: ");
string nome = (Console.ReadLine());

Console.WriteLine($"Digite sua nota 1: ");
float nota1 = float.Parse (Console.ReadLine());

Console.WriteLine($"Digite sua nota 2: ");
float nota2 = float.Parse (Console.ReadLine());

Console.WriteLine($"Digite sua nota 3: ");
float nota3 = float.Parse (Console.ReadLine());

Console.WriteLine($"Digite sua nota 4: ");
float nota4 = float.Parse (Console.ReadLine());

Console.WriteLine($"Digite sua nota 5: ");
float nota5 = float.Parse (Console.ReadLine());

//Processamento
float media = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

//Saída
Console.WriteLine($"A média do aluno " + nome + " é " + media);
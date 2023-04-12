//Criar um método para SOMAR 2 números

// static float Somar(float n1, float n2)
// {
//     return (n1 + n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é : {Somar(primeiroNumero,segundoNumero)}");

//Criar os métodos para as DEMAIS OPERAÇÕES matemáticas (-, *, /)
//Subtração
// static float Subtrair(float n1, float n2)
// {
//     return (n1 - n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"A subtração de {primeiroNumero} - {segundoNumero} é : {Subtrair(primeiroNumero,segundoNumero)}");

//Multiplicação
//static float Multiplicar(float n1, float n2)
// {
//     return (n1 * n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"A multiplicação de {primeiroNumero} * {segundoNumero} é : {Multiplicar(primeiroNumero,segundoNumero)}");

//Divisão
// static float Dividir(float n1, float n2)
//  {
//      return (n1 / n2);
//  }

//  Console.WriteLine($"Informe o primeiro número: ");
//  float primeiroNumero = float.Parse(Console.ReadLine());

//  Console.WriteLine($"Informe o segundo número: ");
//  float segundoNumero = float.Parse(Console.ReadLine());

//  Console.WriteLine($"A divisão de {primeiroNumero} / {segundoNumero} é : {Dividir(primeiroNumero,segundoNumero)}");


//Método para trazer a HORA DO SISTEMA
// static int MostrarHora()
// {
//     return DateTime.Now.Hour;
// }

// Console.WriteLine($"Agora são {MostrarHora()} horas");

//ou
// static int MostrarHoras()
// {
//     return DateTime.Now.Hour;
// }
// static int MostrarMinutos()
// {
//     return DateTime.Now.Minute;
// }

// Console.WriteLine($"Agora são {MostrarHoras()}h{MostrarMinutos()}");

//Método para criar BARRA DE CARREGAMENTO
// static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
// {
//     Console.Write(texto);

//     for (var i = 0; i < quantidadePontinhos; i++)
//     {
//         Console.Write($".");
//         Thread.Sleep(tempo);
//     }
// }

// BarraCarregamento("Carregando", 8, 1000);


//Entrada
Console.WriteLine($"How old are you? ");
int age = int.Parse(Console.ReadLine());

//Processamento 
//Months: {age * 12}
//Days: {age * 365}
//Hours: {age * 365 * 24}
//Minutes: {age * 365 * 24 * 60}

//Saída
Console.WriteLine($"You are {age * 12} months, or {age * 365} days, or {age * 365 * 24} hours or {age * 365 * 24 * 60} minutes old :)");

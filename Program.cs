int numero1, numero2;

// Espacamento
Console.WriteLine();

// Pedindo e armazenando os números
Console.Write("Digite o primeiro número..: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número...: ");
numero2 = Convert.ToInt32(Console.ReadLine());

// Espacamento
Console.WriteLine();

// Testando qual dos dois é maior
if (numero1 > numero2)
{
    // Escrevendo o maior
    Console.WriteLine($"O maior número é {numero1}");
}
else if (numero1 < numero2)
{
    // Escrevendo o maior
    Console.WriteLine($"O maior número é {numero2}");
}

// Espacamento
Console.WriteLine();
double n, contador, produto;

Console.Write("Tabuada do numero: ");
n = Convert.ToDouble(Console.ReadLine()!);

if (n < 0 || n > 10)
{
    Console.WriteLine("Digite o numeros de 0 a 10");
}
else
{
    contador = 0;
    while (contador <= 10)
    {   
    produto = n * contador;

    Console.WriteLine($"{n} x {contador++} = {produto}");
     }
}
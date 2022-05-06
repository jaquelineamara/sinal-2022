int numero;

Console.Write("digite um Número: ");
numero = Convert.ToInt32(Console.ReadLine ());

if (numero < 0 )

{
    Console.WriteLine("Negativo");
}

else if (numero > 0)
{
    Console.WriteLine("Positivo");
}

else
{
    Console.WriteLine("Zero");
}

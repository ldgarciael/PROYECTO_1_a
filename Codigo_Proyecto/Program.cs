using System;
class proyecto1A
{
    public static void Main()
    {
        Console.WriteLine("===\tBienvenido a Patoaventuras\t===");
        Console.Write("Ingresa tu nombre: ");
        string patoNombre = Console.ReadLine().ToString();
        Console.WriteLine("Elije a tu pato guerrero:");
        Console.WriteLine("Pato caballero\tPato mago\tPato arquero");
        Console.WriteLine("Vida: 100\tVida: 70\tVida: 85");
        Console.WriteLine("Atq: 20\t\tAtq: 30\t\tAtq: 25\n");
        Console.WriteLine("Para elejir un personaje: ");
        Console.Write("(1) pato caballero\t(2) pato mago\t(3) pato arquero ");

    }    
}

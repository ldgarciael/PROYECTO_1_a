using System;
class proyecto1A
{
    public static void Main()
    {
        int patoVida=0, patoAtaque=0;
        bool patoAvanzar;
        Console.WriteLine("===\tBienvenido a Patoaventuras\t===");
        Console.Write("Ingresa tu nombre: ");
        string patoNombre = Console.ReadLine().ToString();
        do
        {
            Console.WriteLine("Elije a tu pato guerrero:");
            Console.WriteLine("Pato caballero\tPato mago\tPato arquero");
            Console.WriteLine("Vida: 100\tVida: 70\tVida: 85");
            Console.WriteLine("Atq: 20\t\tAtq: 30\t\tAtq: 25\n");
            Console.WriteLine("Para elejir un personaje: ");
            Console.WriteLine("(1) pato caballero\t(2) pato mago\t(3) pato arquero ");
            int.TryParse(Console.ReadLine(), out int patoPersonaje);
            switch (patoPersonaje)
            {
                case 1:
                    patoAvanzar=false;
                    patoVida = 100;
                    patoAtaque = 20;
                    Console.Clear();
                    break;
                case 2:
                    patoAvanzar=false;
                    patoVida = 70;
                    patoAtaque = 30;
                    Console.Clear();
                    break;
                case 3:
                    patoAvanzar=false;
                    patoVida = 85;
                    patoAtaque = 25;
                    Console.Clear(); 
                    break;  
                default:
                    patoAvanzar=true;
                    Console.WriteLine("Parece que ese no es un pato personaje disponible, vuelve a intentar");
                    Console.WriteLine("Presiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            } 
        }while(patoAvanzar==true);
    }    
}

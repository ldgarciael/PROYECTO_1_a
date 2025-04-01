﻿using System;
class proyecto1A
{
    static  int patoVida, patoAtaque, patoEnemigosDerrotados = 0;
    static bool patoAvanzar;
    static string patoMapaNombre = "",patoNombre = "";
    public static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║      🐤 ¡Bienvenido a PatoAventuras! 🐤    ║");
        Console.WriteLine("║ ¡Explora el multiverso mágico de los patos!║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.Write("👉 Ingresa tu Pato Nombre: ");
        patoNombre = Console.ReadLine().ToString();
        Console.Clear();
        EleccionDePersonaje();
        EleccionDeMapa();
        MenuPrincipal();
        PatoPelea();
    }
    static void EleccionDePersonaje()
    {
        do
        {
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║             🐤 Elige tu Pato Guerrero 🐤           ║");
            Console.WriteLine("╠════════════════════════════════════════════════════╣");
            Console.WriteLine("║ (1) 🛡 Pato Caballero                               ║");
            Console.WriteLine("║     Vida: 100   |  Ataque: 20                      ║");
            Console.WriteLine("║     Un guerrero resistente con defensa sólida.     ║");
            Console.WriteLine("╠────────────────────────────────────────────────────╣");
            Console.WriteLine("║ (2) 🔥 Pato Mago                                   ║");
            Console.WriteLine("║     Vida:  70   |  Ataque: 30                      ║");
            Console.WriteLine("║     Maestro de la magia con hechizos devastadores. ║");
            Console.WriteLine("╠────────────────────────────────────────────────────╣");
            Console.WriteLine("║ (3) 🏹 Pato Arquero                                ║");
            Console.WriteLine("║     Vida:  85   |  Ataque: 25                      ║");
            Console.WriteLine("║     Ágil y letal a distancia con su arco.          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.WriteLine("Selecciona tu guerrero ingresando su número:");
            int.TryParse(Console.ReadLine(), out int patoPersonaje);
            switch (patoPersonaje)
            {
                case 1:
                    Console.Clear();
                    patoAvanzar=false;
                    patoVida = 100;
                    patoAtaque = 20;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato caballero 🛡        ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    patoAvanzar=false;
                    patoVida = 70;
                    patoAtaque = 30;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato mago 🔥         ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    patoAvanzar=false;
                    patoVida = 85;
                    patoAtaque = 25;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato arquero 🏹        ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear(); 
                    break;  
                default:
                    Console.Clear();
                    patoAvanzar=true;
                    Console.WriteLine("Parece que ese no es un pato personaje disponible, vuelve a intentar");
                    Console.Write("Presiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            } 
        }while(patoAvanzar==true);
    }    
    static void EleccionDeMapa()
    {
        Console.WriteLine("======================================================================================="); 
        Console.WriteLine($"                    Elige el camino que recorrerá nuestro pato viajero {patoNombre}");
        Console.WriteLine("=======================================================================================");
        do
        {   
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            Elige uno de los siguientes caminos:                      ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║     1. Bosque Oscuro 🌑                                              ║");
            Console.WriteLine("║            Puede que haya tesoros sorprendentes... o quizá no.       ║");
            Console.WriteLine("╠──────────────────────────────────────────────────────────────────────╣");
            Console.WriteLine("║     2. Cueva Sombría 🦇                                              ║");
            Console.WriteLine("║            Los enemigos atacan primero y puede haber visitas         ║");
            Console.WriteLine("║            inesperadas...                                            ║");
            Console.WriteLine("╠──────────────────────────────────────────────────────────────────────╣");
            Console.WriteLine("║     3. Camino de Piedra 🪨                                            ║");
            Console.WriteLine("║            Es el camino más seguro, pero la recompensa podría        ║");
            Console.WriteLine("║            no ser tan buena...                                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝"); 
            Console.WriteLine("Selecciona tu camino ingresando su número:");
            int.TryParse(Console.ReadLine(),out int patoMapa);
            switch (patoMapa)
            {
                case 1:
                    patoAvanzar = false;
                    patoMapaNombre = "BOSQUE OSCURO";
                    Console.Clear();
                    break;
                case 2:
                    patoAvanzar = false;
                    patoMapaNombre = "CUEVA SOMBRÍA";
                    Console.Clear();

                    break;
                case 3:
                    patoAvanzar = false;
                    patoMapaNombre = "CAMINO DE PIEDRA";
                    Console.Clear();
                    break;
                default:
                    patoAvanzar = true;
                    Console.WriteLine("Parece ser que el camino que elegiste no existe en este mundo, vuelve a intentar");
                    Console.WriteLine("Pulsa cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }while(patoAvanzar==true);
    }
    static void MenuPrincipal()
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║            MENÚ PRINCIPAL              ║");
        Console.WriteLine("╠════════════════════════════════════════╣");
        Console.WriteLine($"  📍 Ubicación: {patoMapaNombre}        ");
        Console.WriteLine("╠════════════════════════════════════════╣");
        Console.WriteLine($"║ ❤️  Vida Actual: {patoVida}                    ║");
        Console.WriteLine($"║ ⚔️  Poder Actual: {patoAtaque}                    ║");
        Console.WriteLine($"║ 🏆 Enemigos Derrotados: {patoEnemigosDerrotados}              ║");
        Console.WriteLine("╠════════════════════════════════════════╣");
        Console.WriteLine("║ ¿Deseas continuar esta pato aventura?  ║");
        Console.WriteLine("║ (1) Continuar     |     (2) Rendirse   ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        int.TryParse(Console.ReadLine(), out int patoElección); 
        if (patoElección==1)
        {
            Console.WriteLine("Has decidido tomar el camino dificil de los patos");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║  La vida de un pato es difícil... ║");
            Console.WriteLine("║  Un día eres un héroe...          ║");
            Console.WriteLine("║  Y al otro eres sopa de pato. 🍲  ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Environment.Exit(0);
        }
    }
    static void PatoPelea ()
    {
        Console.WriteLine("Han aparecido enemigos");
    }
    static void ManejoDeCofres()
    {
        Console.WriteLine("Ha aparecido un cofre");
    }
}
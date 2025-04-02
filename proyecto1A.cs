using System;
using System.Collections;
class proyecto1A
{
    static  int patoVida, patoAtaque, patoEnemigosDerrotados = 0, patoCofre, patoPersonaje, i=1,patoCantidadEnemigos, patoVidaEnemigos;
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
        ManejoDeCofresMapas();
        PatoPelea1();

        Console.WriteLine("¡En hora buena! parece que has conseguido un cofre ¿deseas abrirlo?");
        Console.WriteLine("(1) Si\t(2) No");
        int.TryParse(Console.ReadLine(), out patoCofre);
        ManejoDeCofres();

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
            int.TryParse(Console.ReadLine(), out patoPersonaje);
            CleanPantalla();
            switch (patoPersonaje)
            {
                case 1:
                    patoAvanzar=false;
                    patoVida = 100;
                    patoAtaque = 20;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato caballero 🛡        ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    CleanPantalla();
                    break;
                case 2:
                    patoAvanzar=false;
                    patoVida = 70;
                    patoAtaque = 30;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato mago 🔥         ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    CleanPantalla();
                    break;
                case 3:
                    patoAvanzar=false;
                    patoVida = 85;
                    patoAtaque = 25;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"      {patoNombre} ha elegido al pato arquero 🏹        ");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║  ¡Prepárate para la aventura, valiente pato!       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    CleanPantalla(); 
                    break;  
                default:
                    patoAvanzar=true;
                    Console.WriteLine("Parece que ese no es un pato personaje disponible, vuelve a intentar");
                    CleanPantalla();
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
            CleanPantalla();
            switch (patoMapa)
            {
                case 1:
                    patoAvanzar = false;
                    patoMapaNombre = "BOSQUE OSCURO";
                    break;
                case 2:
                    patoAvanzar = false;
                    patoMapaNombre = "CUEVA SOMBRÍA";

                    break;
                case 3:
                    patoAvanzar = false;
                    patoMapaNombre = "CAMINO DE PIEDRA";
                    break;
                default:
                    patoAvanzar = true;
                    Console.WriteLine("Parece ser que el camino que elegiste no existe en este mundo, vuelve a intentar");
                    CleanPantalla();
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
        Console.WriteLine($" ❤️  Vida Actual: {patoVida}                    ");
        Console.WriteLine($" ⚔️  Poder Actual: {patoAtaque}                    ");
        Console.WriteLine($" 🏆 Enemigos Derrotados: {patoEnemigosDerrotados}              ");
        Console.WriteLine("╠════════════════════════════════════════╣");
        Console.WriteLine("║ ¿Deseas continuar esta pato aventura?  ║");
        Console.WriteLine("║ (1) Continuar     |     (2) Rendirse   ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        int.TryParse(Console.ReadLine(), out int patoElección); 
        if (patoElección==1)
        {
            Console.WriteLine("Has decidido tomar el camino dificil de los patos");
            CleanPantalla();
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
    static void ManejoDeCofresMapas()
    {
        if (patoMapaNombre=="BOSQUE OSCURO")
        {
            Random random = new Random();
            {
                int patoMapa1Random = random.Next(1,3);
                switch (patoMapa1Random)
                {
                    case 1:
                        Console.WriteLine("Parece que has encontrado un cofre misterioso\n¿deseas abrirlo?");
                        Console.WriteLine("(1) Si\t(2) No");
                        int.TryParse(Console.ReadLine(), out patoCofre);
                        ManejoDeCofres();
                        break;
                    default:
                        Console.WriteLine("¡Oh no! Parece ser que caiste en una trampa ¡¡que mala pata!!\nSalud -2");
                        patoVida-=2;
                        CleanPantalla();
                        break;
                }
            }
        }
        else if (patoMapaNombre=="CUEVA SOMBRÍA")
        {
            Random random1 = new Random();
            {
                int patoMapa2Random = random1.Next(1,3);
                switch (patoMapa2Random)
                {
                    case 1:
                        Console.WriteLine($"/enemigo sigiloso atacó a {patoNombre}/\nSalud -2");
                        patoVida-=2;
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("Parece que no pasa nada... por ahora...");
                        CleanPantalla();
                        break;
                }
            }
        }
        else
        {
            Random random = new Random();
            {
                int patoMapa1Random = random.Next(1,3);
                switch (patoMapa1Random)
                {
                    case 1:
                        Console.WriteLine("Parece que has encontrado un cofre misterioso\n¿deseas abrirlo?");
                        Console.WriteLine("(1) Si\t(2) No");
                        int.TryParse(Console.ReadLine(), out patoCofre);
                        ManejoDeCofres1();
                        break;
                    default:
                        Console.WriteLine("Parece que no tuvimos suerte encontrando recompensas esta vez patito...");
                        CleanPantalla();
                        break;
                }
            }
        }
    }
    static void ManejoDeCofres()
    {
        if (patoCofre==1)
        {
            Random random2 = new Random();
            {
                int patoCofreEfectos=random2.Next(1,4);
                switch (patoCofreEfectos)
                {
                    case 1:
                        if (patoPersonaje==1)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,100);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==2)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,70);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==3)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,85);
                            CleanPantalla();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Parece que te has hecho más fuerte...\nAtq +7");
                        patoAtaque+=7;
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("Parece que fuiste envenenado... mas suerte a la próxima paito\nSalud -5");
                        patoVida-=5;
                        CleanPantalla();
                        break;
                }
            }
        }
    }
    static void ManejoDeCofres1()
    {
        if (patoCofre==1)
        {
            Random random2 = new Random();
            {
                int patoCofreEfectos=random2.Next(1,5);
                switch (patoCofreEfectos)
                {
                    case 1:
                        if (patoPersonaje==1)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,100);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==2)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,70);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==3)
                        {
                            Console.WriteLine("Recuperaste salud ¡YAY!");
                            patoVida=Math.Min(patoVida+10,85);
                            CleanPantalla();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Parece que te has hecho más fuerte...\nAtq +7");
                        patoAtaque+=7;
                        CleanPantalla();
                        break;
                    case 3:
                        Console.WriteLine("Parece que fuiste envenenado... mas suerte a la próxima patito\nSalud -5");
                        patoVida-=5;
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("¡Oops! parece que esta vez encontramos un cofre sin nada :c");
                        CleanPantalla();
                        break;
                }
            }
        }
    }
    static void FinDelJuego()
    {
        if (patoVida<=0)
        {
            Console.WriteLine("GAME OVER\nHoy no es tu día patito, pero ¡volverás más fuerte!");
            Environment.Exit(0);
        }
    }
    static void CleanPantalla()
    {
        Console.WriteLine("Pulsa cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    static int CantidadEnemigos(int patoCantidadEnemigos)
    {
        if (i==1)
        {
            Random random3 = new Random();
            {
                patoCantidadEnemigos = random3.Next(1,4);
            }
        }
        else if (i==2)
        {
            Random random4 = new Random();
            {
                patoCantidadEnemigos = random4.Next(1,3);
            }
        }
        return patoCantidadEnemigos;
    }
    static void PatoPelea1()
    {
        // Console.WriteLine(patoVidaEnemigos);
        // Console.WriteLine("Han aparecido enemigos");
        if (i==1)
        {
            patoVidaEnemigos=20;
            patoVidaEnemigos*=CantidadEnemigos(patoCantidadEnemigos);
            Console.WriteLine(patoVidaEnemigos);
            Console.WriteLine("Parece que han aparecido "+ CantidadEnemigos(patoCantidadEnemigos) +" ||bandidos");
        }
    }
}

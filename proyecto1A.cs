using System;
using System.Collections;
class proyecto1A
{
    static  int patoVida, patoAtaque, patoEnemigosDerrotados = 0, patoCofre, patoPersonaje, i=1,patoCantidadEnemigos, patoVidaEnemigos, BMJ, ataque, patoTurno;
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
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃  🎁 Encontraste un ¡Tesoro Misterioso! 🎁 ┃");
        Console.WriteLine("┃  🦆🗿 ESTATUAS ANCESTRALES DE PIEDRA 🗿🦆  ┃");
        Console.WriteLine("┃  ¡Un cofre protegido por antiguos guardianes! ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        Console.WriteLine("Parece que has encontrado un cofre misterioso\n¿deseas abrirlo?");
        Console.WriteLine("(1) Si\t(2) No");
        int.TryParse(Console.ReadLine(), out patoCofre);
        ManejoDeCofres();
        i=2;
        PatoPelea1();
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃  🎁 Encontraste un ¡Tesoro Misterioso! 🎁 ┃");
        Console.WriteLine("┃  🦆🗿 ESTATUAS ANCESTRALES DE PIEDRA 🗿🦆  ┃");
        Console.WriteLine("┃  ¡Un cofre protegido por antiguos guardianes! ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        Console.WriteLine("Parece que has encontrado un cofre misterioso\n¿deseas abrirlo?");
        Console.WriteLine("(1) Si\t(2) No");
        int.TryParse(Console.ReadLine(), out patoCofre);
        ManejoDeCofres();
        i=3;
        PatoPelea1();
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
            Console.WriteLine("║     3. Camino de Piedra 🛤️                                           ║");
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
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃  🎁 Encontraste un ¡Tesoro Misterioso! 🎁 ┃");
                        Console.WriteLine("┃  🏛️  RUINAS ANCESTRALES DEL BOSQUE 🏛️       ┃");
                        Console.WriteLine("┃  ¡Un cofre entre templos olvidados!       ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                        Console.WriteLine("¿Abrimos el cofre y vemos qué pato-locura hay dentro?");
                        Console.WriteLine("(1) Si\t(2) No");
                        int.TryParse(Console.ReadLine(), out patoCofre);
                        ManejoDeCofres();
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║           🌫️  ¡Caíste en una trampa! 🌫️               ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Un movimiento en falso y... ¡zas!              ║");
                        Console.WriteLine("║   El suelo te jugó una mala pasada, patito. 🐤   ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║             💔 Salud -5 💔                        ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
                        patoVida-=5;
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
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine($"║     🌀 ¡Un enemigo sigiloso atacó a {patoNombre}!        ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Todo fue un parpadeo, una ilusión...           ║");
                        Console.WriteLine("║   ¿O acaso fue magia? 🐤🪄                        ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║             🌪️  Salud -5 🌪️                        ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
                        patoVida-=5;
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
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃  🎁 Encontraste un ¡Tesoro Misterioso! 🎁 ┃");
                        Console.WriteLine("┃  🦆🗿 ESTATUAS ANCESTRALES DE PIEDRA 🗿🦆  ┃");
                        Console.WriteLine("┃  ¡Un cofre protegido por antiguos guardianes! ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                        Console.WriteLine("Parece que has encontrado un cofre misterioso\n¿deseas abrirlo?");
                        Console.WriteLine("(1) Si\t(2) No");
                        int.TryParse(Console.ReadLine(), out patoCofre);
                        ManejoDeCofres1();
                        CleanPantalla(); 
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
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,100);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==2)
                        {
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,70);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==3)
                        {
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,85);
                            CleanPantalla();
                        }
                        break;
                    case 2:
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║               💥 ¡Te has fortalecido! 💥             ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Sientes el poder fluir por tus alas. 🐤🔥         ║");
                        Console.WriteLine("║   ¡Estás listo para enfrentar cualquier reto! ⚔️   ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║               🗡️ Ataque +7 🗡️                      ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
                        patoAtaque+=7;
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║            ☠️ ¡Has sido envenenado! ☠️           ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Parece que fuiste envenenado...                ║");
                        Console.WriteLine("║   Más suerte a la próxima, patito. 🐤            ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║              💔 Salud -5 💔                      ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
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
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,100);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==2)
                        {
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,70);
                            CleanPantalla();
                        }
                        else if (patoPersonaje==3)
                        {
                            Console.WriteLine("╔══════════════════════════════════════════════════╗");
                            Console.WriteLine("║             💖 ¡Recuperaste Salud! 💖            ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║   Recuperaste fuerzas, patito valiente. 🐤       ║");
                            Console.WriteLine("║   ¡Tu energía vuelve como un río mágico! 💧✨    ║");
                            Console.WriteLine("║                                                  ║");
                            Console.WriteLine("║              ❤️  +10 Salud ❤️                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════╝");
                            patoVida=Math.Min(patoVida+10,85);
                            CleanPantalla();
                        }
                        break;
                    case 2:
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║               💥 ¡Te has fortalecido! 💥             ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Sientes el poder fluir por tus alas. 🐤🔥         ║");
                        Console.WriteLine("║   ¡Estás listo para enfrentar cualquier reto! ⚔️   ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║               🗡️ Ataque +7 🗡️                      ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
                        patoAtaque+=7;
                        CleanPantalla();
                        break;
                    case 3:
                       Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║              ☠️ ¡Has sido envenenado! ☠️             ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   Parece que fuiste envenenado...                ║");
                        Console.WriteLine("║   Más suerte a la próxima, patito. 🐤             ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║              💔 Salud -5 💔                       ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");
                        patoVida-=5;
                        CleanPantalla();
                        break;
                    default:
                        Console.WriteLine("╔══════════════════════════════════════════════════╗");
                        Console.WriteLine("║            📦 ¡El cofre estaba vacío! 📦             ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║   ¡Oops! Esta vez no hubo suerte, patito. 😢       ║");
                        Console.WriteLine("║                                                  ║");
                        Console.WriteLine("║              📭 Cofre sin contenido               ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════╝");

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
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║  Hoy no es tu día patito,         ║");
            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
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
    static int PoderEnemigos(int patoAtaqueEnemigos)
    {
        if (i==1)
        {
            Random random5 = new Random();
            {
                patoAtaqueEnemigos = random5.Next(1,6);
            }
        }
        else if (i==2)
        {
            Random random6 = new Random();
            {
                patoAtaqueEnemigos = random6.Next(5,11);
            }
        }
        else
        {
            Random random7 = new Random();
            {
                patoAtaqueEnemigos = random7.Next(10,21);
            }
        }
        return patoAtaqueEnemigos;
    }
    static void PatoPelea1()
    {
        if (patoMapaNombre=="CUEVA SOMBRÍA")
        {
            if (i==1)
            {
                BMJ = CantidadEnemigos(patoCantidadEnemigos);
                patoVidaEnemigos=20;
                patoVidaEnemigos*=BMJ;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine($"║🏴‍☠️  ¡Alerta! {BMJ} bandidos se aproximan a toda prisa! ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║   Se oyen pasos, gritos y espadas chocar...        ║");
                Console.WriteLine("║   ¡Una batalla está por comenzar, patito! 🐤💣     ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║              ⚠️  ¡En guardia! ⚠️                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while (patoVidaEnemigos>0)
                {
                    Console.WriteLine("A pelear patito");
                    ataque = PoderEnemigos(patoCantidadEnemigos);
                    patoVida-=ataque;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    FinDelJuego();
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("    ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("    ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("Ahora es tu turno\n(1) atacar\t(2) huir");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🏆  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   Venciste a todos los enemigos con valentía. 💪   ║");
                                Console.WriteLine("║   Sigamos avanzando en nuestra aventura. 🗺️✨      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║      ¡Eres un verdadero Pato héroe! 🐤👑       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                break;
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                    }
                }
            }
            else if (i==2)
            {
                BMJ = CantidadEnemigos(patoCantidadEnemigos);
                patoVidaEnemigos=25;
                patoVidaEnemigos*=BMJ;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine($"║🏴‍☠️  ¡Alerta! {BMJ} mounstros se aproximan a toda prisa! ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║¡Cuidado! En este mapa los enemigos atacan primero...   ║");
                Console.WriteLine("║   ¡Una batalla está por comenzar, patito! 🐤💣     ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║              ⚠️  ¡En guardia! ⚠️                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while (patoVidaEnemigos>0)
                {
                    Console.WriteLine("A pelear patito");
                    ataque = PoderEnemigos(patoCantidadEnemigos);
                    patoVida-=ataque;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    FinDelJuego();
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("    ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("    ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("Ahora es tu turno\n(1) atacar\t(2) huir");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🏆  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   Venciste a todos los enemigos con valentía. 💪   ║");
                                Console.WriteLine("║   Sigamos avanzando en nuestra aventura. 🗺️✨      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║      ¡Eres un verdadero Pato héroe! 🐤👑       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                break;
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else 
            {
                patoVidaEnemigos=70;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║       ⚔️  Parece que ha aparecido el Jefe final    ║");
                Console.WriteLine("║        ¡¡Ten cuidado patito!!                       ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║¡Cuidado! En este mapa los enemigos atacan primero... ║");
                Console.WriteLine("║   ¡Mantente firme, patito valiente! 🐤🛡️           ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while (patoVidaEnemigos>0)
                {
                    Console.WriteLine("A pelear patito");
                    ataque = PoderEnemigos(patoCantidadEnemigos);
                    patoVida-=ataque;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    FinDelJuego();
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("    ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("    ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("Ahora es tu turno\n(1) atacar\t(2) huir");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🎉  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   ¡Has vencido al Jefe Final en una batalla épica! ║");
                                Console.WriteLine("║   ¡¡ARRIBA LA SUPREMACÍA DE LOS PATOS!! 🦆🔥       ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║     ¡Patito chiquito, corazón gigante! 💛🐤       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                Console.WriteLine("Esta cruzada llega a su fin ¡¡¡pero nunca sera el final de la historia de este legendario pato!!!");
                                break;
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        } 
        else
        {
            if (i==1)
            {
                BMJ = CantidadEnemigos(patoCantidadEnemigos);
                patoVidaEnemigos=20;
                patoVidaEnemigos*=BMJ;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine($"║🏴‍☠️  ¡Alerta! {BMJ} bandidos se aproximan a toda prisa! ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║¡Cuidado! En este mapa los enemigos atacan primero...   ║");
                Console.WriteLine("║   ¡Una batalla está por comenzar, patito! 🐤💣     ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║              ⚠️  ¡En guardia! ⚠️                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while(patoVidaEnemigos>0)
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("    ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("    ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("¡¡Venga ataca patito!!\n(1) atacar\t(2) huír");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🏆  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   Venciste a todos los enemigos con valentía. 💪   ║");
                                Console.WriteLine("║   Sigamos avanzando en nuestra aventura. 🗺️✨      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║      ¡Eres un verdadero Pato héroe! 🐤👑       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                break;
                            }
                            ataque = PoderEnemigos(patoCantidadEnemigos);
                            patoVida-=ataque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            FinDelJuego();
                            CleanPantalla();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (i==2)
            {
                BMJ = CantidadEnemigos(patoCantidadEnemigos);
                patoVidaEnemigos=25;
                patoVidaEnemigos*=BMJ;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine($"║🏴‍☠️  ¡Alerta! {BMJ} mounstros se aproximan a toda prisa! ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║¡Cuidado! En este mapa los enemigos atacan primero...   ║");
                Console.WriteLine("║   ¡Una batalla está por comenzar, patito! 🐤💣     ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║              ⚠️  ¡En guardia! ⚠️                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while(patoVidaEnemigos>0)
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("         ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("         ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("¡¡Venga ataca patito!!\n(1) atacar\t(2) huír");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🎉  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   ¡Has vencido al Jefe Final en una batalla épica! ║");
                                Console.WriteLine("║   ¡¡ARRIBA LA SUPREMACÍA DE LOS PATOS!! 🦆🔥       ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║     ¡Patito chiquito, corazón gigante! 💛🐤       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                break;
                            }
                            ataque = PoderEnemigos(patoCantidadEnemigos);
                            patoVida-=ataque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            FinDelJuego();
                            CleanPantalla();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                patoVidaEnemigos=70;
                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                Console.WriteLine("║       ⚔️  Parece que ha aparecido el Jefe final    ║");
                Console.WriteLine("║        ¡¡Ten cuidado patito!!                       ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("║¡Cuidado! En este mapa los enemigos atacan primero║");
                Console.WriteLine("║   ¡Mantente firme, patito valiente! 🐤🛡️           ║");
                Console.WriteLine("║                                                    ║");
                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                while(patoVidaEnemigos>0)
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("         ⚠️ ¡ENEMIGO ACECHA! ⚠️    ");
                    Console.WriteLine("         ¡Defiende tu honor!    ");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Console.WriteLine("¡¡Venga ataca patito!!\n(1) atacar\t(2) huír");
                    int.TryParse(Console.ReadLine(), out patoTurno);
                    switch (patoTurno)
                    {
                        case 1:
                            patoVidaEnemigos-=patoAtaque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💥  {patoNombre} ha atacado al enemigo feroz        ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   ¡El enemigo ha perdido {patoAtaque} puntos de vida! 💢   ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Buen golpe, patito guerrero! 🐤⚔️          ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            if (patoVidaEnemigos<=0)
                            {
                                Console.WriteLine("╔════════════════════════════════════════════════════╗");
                                Console.WriteLine($"║🎉  ¡Bien hecho, {patoNombre}!                      ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║   ¡Has vencido al Jefe Final en una batalla épica! ║");
                                Console.WriteLine("║   ¡¡ARRIBA LA SUPREMACÍA DE LOS PATOS!! 🦆🔥       ║");
                                Console.WriteLine("║                                                    ║");
                                Console.WriteLine("║     ¡Patito chiquito, corazón gigante! 💛🐤       ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════╝");
                                patoEnemigosDerrotados+=BMJ;
                                CleanPantalla();
                                MenuPrincipal();
                                Console.WriteLine("Esta cruzada llega a su fin ¡¡¡pero nunca sera el final de la historia de este legendario pato!!!");
                                break;
                            }
                            ataque = PoderEnemigos(patoCantidadEnemigos);
                            patoVida-=ataque;
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine($"║💢  ¡{patoNombre} ha recibido un ataque enemigo!    ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine($"║   Ha perdido {ataque} puntos de vida... ¡auch! 🩸           ║");
                            Console.WriteLine("║                                                    ║");
                            Console.WriteLine("║        ¡Resiste, patito! Aún puedes pelear 🐤💪     ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");
                            FinDelJuego();
                            CleanPantalla();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine("║     ☠️  GAME OVER PATITO ☠️         ║");
                            Console.WriteLine("╠═══════════════════════════════════╣");
                            Console.WriteLine("║  Hoy no es tu día patito,         ║");
                            Console.WriteLine("║  pero ¡volverás más fuerte!       ║");
                            Console.WriteLine("╚═══════════════════════════════════╝");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}

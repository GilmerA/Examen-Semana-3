using Semana_3;

using System;
using System.Collections.Generic;

namespace Semana_3

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DungeonMaster dm = new DungeonMaster();
                dm.CrearEnemigos();

                Console.WriteLine("Bienvenido al RPG de Caballeros y Dragones!");
                Console.WriteLine("Determina cuántos stages tendrá el juego:");

                int cantidadStages = 0;
                bool esValido = false;
                while (!esValido)
                {
                    try
                    {
                        cantidadStages = int.Parse(Console.ReadLine());
                        if (cantidadStages > 0)
                        {
                            esValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingresa un número mayor que 0.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Número demasiado grande. Por favor, ingresa un número menor.");
                    }
                }

                for (int i = 0; i < cantidadStages; i++)
                {
                    Console.WriteLine($"Configurando Stage {i + 1}");
                    dm.CrearStage(2); 
                }

                Console.WriteLine("Crea a tu jugador. Introduce un nombre:");
                string nombreJugador = Console.ReadLine();
                Jugador jugador = new Jugador(nombreJugador, 100, 20, new Espada());

                foreach (var stage in dm.Stages)
                {
                    Console.WriteLine($"Iniciando Stage con {stage.Enemigos.Count} enemigos.");
                    while (!stage.Completo() && jugador.EstaVivo())
                    {
                        try
                        {
                            // Mostrar opciones del jugador
                            Console.WriteLine("1. Atacar\n2. Usar ítem");
                            int accion = 0;
                            bool accionValida = false;
                            while (!accionValida)
                            {
                                try
                                {
                                    accion = int.Parse(Console.ReadLine());
                                    if (accion == 1 || accion == 2)
                                    {
                                        accionValida = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Por favor, elige una opción válida (1 o 2).");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                                }
                            }

                            if (accion == 1)
                            {
                                jugador.Atacar(stage.Enemigos[0]);
                                if (!stage.Enemigos[0].EstaVivo())
                                {
                                    Console.WriteLine($"{stage.Enemigos[0].Nombre} ha muerto!");
                                    jugador.Inventario.AddRange(stage.Enemigos[0].Recompensas);
                                }
                            }
                            else if (accion == 2)
                            {
                                if (jugador.Inventario.Count > 0)
                                {
                                    Console.WriteLine("Selecciona un ítem para usar:");
                                    for (int i = 0; i < jugador.Inventario.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {jugador.Inventario[i].Nombre}");
                                    }

                                    int itemIndex = 0;
                                    bool itemValido = false;
                                    while (!itemValido)
                                    {
                                        try
                                        {
                                            itemIndex = int.Parse(Console.ReadLine()) - 1;
                                            if (itemIndex >= 0 && itemIndex < jugador.Inventario.Count)
                                            {
                                                itemValido = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Índice de ítem no válido. Intenta de nuevo.");
                                            }
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            Console.WriteLine("Índice fuera de rango. Selecciona un ítem válido.");
                                        }
                                    }

                                    jugador.UsarItem(itemIndex);
                                }
                                else
                                {
                                    Console.WriteLine("No tienes ítems para usar.");
                                }
                            }

                            
                            if (stage.Enemigos[0].EstaVivo())
                            {
                                stage.Enemigos[0].Atacar(jugador);
                                if (!jugador.EstaVivo())
                                {
                                    Console.WriteLine("Has muerto. Juego terminado.");
                                    return;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
                        }
                    }

                    if (!jugador.EstaVivo())
                    {
                        Console.WriteLine("Has sido derrotado.");
                        break;
                    }
                }

                if (jugador.EstaVivo())
                {
                    Console.WriteLine("¡Has completado todos los stages! ¡Felicidades!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado en el juego: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLogica2
{
    internal class Program
    {
        /*
             * Juego:
                Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en
                adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en
                memoria sin ser revelado.
                Por ejemplo: El sistema escoge aleatoriamente un número entre 0 y 100, ese número NO SE PUEDE
                REVELAR ya que es el número que se adivinará, por ende, dicho número se almacenará en memoria.
                Los participantes comenzarán en orden a jugar y se turnarán para ingresar por pantalla un número
                ℕ hasta acertar el número oculto y salir ganador.
                El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y
                máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generará
                en los siguientes rangos:
                - Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50
                - Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
                - Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200
                Cada jugador comenzará su turno intentando adivinar ese número ℕ aleatorio. El programa deberá
                mostrarle al jugador la siguiente información:
                - Si el número ingresado es mayor al número aleatorio, entonces mostrar por pantalla la
                palabra “MENOR” y darle la oportunidad al siguiente jugador.
                - Si el número ingresado es menor al número aleatorio, entonces mostrar por pantalla la
                palabra “MAYOR” y darle la oportunidad al siguiente jugador.
                - Si el número ingresado coincide con el número aleatorio, entonces mostrar por pantalla la
                palabra “¡HAS GANADO!”. Aquí ya finaliza el juego.
                El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para
                volver a jugar y borrar consola, de lo contrario, finalizar el programa.
                Peso: 50%
               
             * 
             */
        static void Main(string[] args)
        {
            int numero = 0, numeroIngresado = 0, limite = 0, participantes=0, ganador =0;
            Random random = new Random();
            bool sinGanador = true;
            bool juego=true, decisionJuego=true; 
            string decision = "";


            do
            {
                sinGanador = true;
                juego = true;
                decisionJuego = true;
                
                
                do
                {
                    Console.Write("Por favor ingrese el numero de jugadores, recuerde, deben de haber minimo 2 jugadores y maximo 4 jugadores: ");
                    participantes = int.Parse(Console.ReadLine());
                    if (participantes>=2 && participantes<=4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un numero de participantes correcto.");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }

                } while (true);

                switch (participantes)
                {
                    case 2:
                        limite = 51;
                        break;
                    case 3:
                        limite = 101;
                        break;
                    case 4:
                        limite = 201;
                        break;
                    default:
                        break;
                }

                numero = random.Next(0, limite);

                Console.WriteLine("###################################################");
                Console.WriteLine("#   Bienvenidos al Juego a los {0} participantes  #",participantes);
                Console.WriteLine("###################################################\n");


                do
                {
                    for (int i = 1; i <=participantes; i++)
                    {
                        Console.Write("Jugador {0}, por favor ingrese su numero entre 0 y {1}: ",i,limite-1);
                        numeroIngresado = int.Parse(Console.ReadLine());

                        if (numeroIngresado==numero)
                        {
                            Console.WriteLine("GANASTE, FELICITACIONES, EL NUMERO {0} ES EL NUMERO CORRECTO\n", numeroIngresado);
                            ganador = i;
                            sinGanador = false;
                            break;
                        }
                        else if (numeroIngresado>numero)
                        {
                            Console.WriteLine("Fallaste, el numero secreto es menor al numero que ingresaste, sigue intentando\n");
                        }
                        else
                        {
                            Console.WriteLine("Fallaste, el numero secreto es mayor al numero que ingresaste, sigue intentando\n");
                        }
                    }
                } while (sinGanador);

                Console.WriteLine("EL GANADOR ES EL JUGADOR {0}\n", ganador);
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    Console.WriteLine("Desea volver a jugar? s/n");
                    decision = Console.ReadLine().ToLower();

                    switch (decision)
                    {
                        case "s":
                            decisionJuego = false;
                            Console.Clear();
                            break;
                        case "n":
                            decisionJuego = false;
                            juego = false;
                            break;
                        default:
                            Console.WriteLine("Porfavor escoja una opción valida s = Si y n= No");
                            Console.WriteLine("Presiones cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                } while (decisionJuego);
                
            } while (juego);
        }
    }
}

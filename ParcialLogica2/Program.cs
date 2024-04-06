using System;
using System.Collections.Generic;
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
            int numero = 0, numeroingresado = 0, limite = 0, participantes=0, ganador =0;
            Random random = new Random();

            do
            {
                numero = random.Next(0, 101);
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

                

                

            } while (true);
        }
    }
}

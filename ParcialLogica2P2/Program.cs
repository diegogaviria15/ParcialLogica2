using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLogica2P2
{
    internal class Program
    {
        /*
         * Natillera, PARTE 2!
            Como ustedes recuerdan, resolvimos el Ejercicio #18 del Taller de Algoritmos, que se trata de una
            Natillera Navideña. A este ejercicio, le van a añadir una solución a lo siguiente:
            Ya tenemos nuestra natillera navideña diseñada para calcular los aportes y bonos durante un año de
            1 socio y liquidación de dicha natillera al final del año. Ahora quiero modificar el código para que me
            haga lo siguiente:
            - La posibilidad de ingresar 2 socios y calcular el mes de ambos (o sea, mostrar el ahorro del
            mes, si ganó bono, cuánto fue su rendimiento, etc.) tal como se hace con 1 solo, pero esta
            vez que sean 2.
            - Si el socio no aportó/ahorró nada ($0), entonces cobrar una multa de $20.000 en ese mes.
            - Si el socio quiere hacer un préstamo en cualquiera de los meses, solo se le aprueba siempre
            y cuando el valor del préstamo no supere lo ahorrado hasta ese momento. Si supera el valor
            aportado, mostrar un mensaje que informe a ese socio que no se aprobó la solicitud de
            préstamo.
            - Al liquidar la natillera a final de año, hacer la deducción del préstamo y calcular los intereses
            generados contados a partir del mes que hizo el préstamo. Por ejemplo, si el préstamo lo
            solicitó en Abril, entonces calcular la tasa desde Mayo hasta Diciembre. La tasa mensual para
            cobrar será del 2.5% sobre el préstamo.
            - Adicional a lo que el algoritmo ya está mostrando en el momento de liquidar la natillera de
            los dos socios, también la aplicación deberá mostrar valor del préstamo (si la hicieron),
            cuántas multas pagó en el año y el valor neto a liquidarle a ambos socios.
         */
        static void Main(string[] args)
        {
            decimal abonoSocio1 = 0, ahorroTotalSocio1 = 0, bonificacionesSocio1 = 0, interesesSocio1 = 0, interesesTotalesSocio1 = 0, prestamoSocio1=0;
            decimal abonoSocio2 = 0, ahorroTotalSocio2 = 0, bonificacionesSocio2 = 0, interesesSocio2 = 0, interesesTotalesSocio2 = 0, prestamoSocio2=0;
            int cantidadSocios = 0, multaSocio1 = 0, multaSocio2 = 0;
            bool hayPrestamoSocio1 = false, hayPrestamoSocio2 = false, natillera = true;

            Random random= new Random();

            do
            {
                Console.WriteLine("###################################################");
                Console.WriteLine("#      Bienvenido al Sistema de la Natillera      #");
                Console.WriteLine("###################################################\n");

                do
                {
                    Console.WriteLine("Ingrese el numero de socios, recuerde minimo 1 y maximo 2");
                    Console.Write("Socios: ");
                    cantidadSocios = int.Parse(Console.ReadLine());

                    if (cantidadSocios>=1 && cantidadSocios<=2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un numero correcto de socios");
                        Console.WriteLine("Presiones cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("###################################################");
                        Console.WriteLine("#      Bienvenido al Sistema de la Natillera      #");
                        Console.WriteLine("###################################################\n");
                    }
                } while (true);

            } while (natillera);


        }
    }
}

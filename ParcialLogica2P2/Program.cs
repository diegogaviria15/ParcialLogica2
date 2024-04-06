﻿using System;
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
            decimal abonoSocio1 = 0, ahorroTotalSocio1 = 0, bonificacionesSocio1 = 0, interesesSocio1 = 0, interesesTotalesSocio1 = 0, prestamoSocio1=0, abonosTotalesSocio1=0, bonoSocio1=0;
            decimal abonoSocio2 = 0, ahorroTotalSocio2 = 0, bonificacionesSocio2 = 0, interesesSocio2 = 0, interesesTotalesSocio2 = 0, prestamoSocio2=0, abonosTotalesSocio2 = 0, bonoSocio2 = 0;
            int cantidadSocios = 0, multaSocio1 = 0, multaSocio2 = 0;
            bool hayPrestamoSocio1 = false, hayPrestamoSocio2 = false, natillera = true;
            double intereMes = 0;
            string desicionSocio1 = "", desicionSocio2 = "", desicionNatillera="";

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

                for (int i = 1; i <=12; i++)
                {
                    intereMes = random.Next(1, 51);
                    intereMes = intereMes * 0.001;
                    Console.Write("Por favor ingrese el aporte del mes {0} del socio 1: ", i);
                    abonoSocio1 = decimal.Parse(Console.ReadLine());
                    interesesSocio1 = abonoSocio1 * Convert.ToDecimal(intereMes);
                    abonosTotalesSocio1 += abonoSocio1;
                    interesesTotalesSocio1 += interesesSocio1;
                    if (abonoSocio1==0)
                    {
                        multaSocio1++;
                    }
                    if (intereMes<0.015)
                    {
                        bonoSocio1 = 25000;
                        bonificacionesSocio1 += bonoSocio1;
                    }
                    else
                    {
                        bonoSocio1 = 0;
                    }
                    if (hayPrestamoSocio1)
                    {
                        prestamoSocio1 += prestamoSocio1 * Convert.ToDecimal(0.025);
                    }
                    ahorroTotalSocio1 = abonosTotalesSocio1 + interesesTotalesSocio1 + bonificacionesSocio1-(multaSocio1*20000);
                    if (hayPrestamoSocio1==false)
                    {
                        Console.WriteLine("\n¿El socio 1 desea tomar un prestamos? s/n");
                        desicionSocio1 = Console.ReadLine().ToLower();
                        if (desicionSocio1 == "s")
                        {
                            desicionSocio1 = "";
                            Console.WriteLine("Ingrese monto del prestamos a solicitar, recuerde que debe ser menor que su ahorro actual");
                            Console.Write("Prestamo para el socio 1: ");
                            prestamoSocio1 = decimal.Parse(Console.ReadLine());
                            if (prestamoSocio1 > ahorroTotalSocio1)
                            {
                                Console.WriteLine("Su solicitud es rechazada debido a que el monto del prestamos es mayor al monto de su ahorro actual");
                                prestamoSocio1 = 0;
                            }
                            else
                            {
                                hayPrestamoSocio1 = true;
                            }
                        }
                    }                  

                    if (cantidadSocios==2)
                    {
                        Console.Write("Por favor ingrese el aporte del mes {0} del socio 2: ", i);
                        abonoSocio2 = decimal.Parse(Console.ReadLine());
                        interesesSocio2 = abonoSocio2 * Convert.ToDecimal(intereMes);
                        abonosTotalesSocio2 += abonoSocio2;
                        interesesTotalesSocio2 += interesesSocio2;
                        if (abonoSocio2 == 0)
                        {
                            multaSocio2++;
                        }
                        if (intereMes < 1.5)
                        {
                            bonoSocio2 = 25000;
                            bonificacionesSocio2 += bonoSocio2;
                        }
                        else
                        {
                            bonoSocio2 = 0;
                        }

                        if (hayPrestamoSocio2)
                        {
                            prestamoSocio2 += prestamoSocio2 * Convert.ToDecimal(0.025);
                        }
                        ahorroTotalSocio2 = abonosTotalesSocio2 + interesesTotalesSocio2 + bonificacionesSocio2 - (multaSocio2 * 20000);
                        if (hayPrestamoSocio2 == false)
                        {
                            Console.WriteLine("\n¿El socio 2 desea tomar un prestamos? s/n");
                            desicionSocio2 = Console.ReadLine().ToLower();
                            if (desicionSocio2 == "s")
                            {
                                desicionSocio2 = "";
                                Console.WriteLine("Ingrese monto del prestamos a solicitar, recuerde que debe ser menor que su ahorro actual");
                                Console.Write("Prestamo para el socio 2: ");
                                prestamoSocio2 = decimal.Parse(Console.ReadLine());
                                if (prestamoSocio2 > ahorroTotalSocio2)
                                {
                                    Console.WriteLine("Su solicitud es rechazada debido a que el monto del prestamos es mayor al monto de su ahorro actual");
                                    prestamoSocio2 = 0;
                                }
                                else
                                {
                                    hayPrestamoSocio2 = true;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("Este es el reporte Anual del socio 1: ");
                Console.WriteLine("Los aportes totales del socio 1 son: {0}",abonosTotalesSocio1);
                Console.WriteLine("Los interes ganandos totales del socio 1: {0}",interesesTotalesSocio1);
                Console.WriteLine("Los bonos totales del socio 1 {0}: ",bonificacionesSocio1);
                Console.WriteLine("Las sumatoria de multas totales del socio 1: {0}",multaSocio1*20000);
                Console.WriteLine("La deuda total por prestamos del socio 1: {0}", prestamoSocio1);
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("La suma de las ganancias del socio 1 son: {0}", ahorroTotalSocio1);
                Console.WriteLine("La suma de las perdidas totales del socio 1 son {0}", prestamoSocio1 + (multaSocio1 * 20000));
                Console.WriteLine("El total del socio 1: {0}", ahorroTotalSocio1 - (prestamoSocio1 + (multaSocio1 * 20000)));
                Console.WriteLine("------------------------------------------------------");


                if (cantidadSocios==2)
                {
                    Console.WriteLine("Este es el reporte Anual del socio 2: ");
                    Console.WriteLine("Los aportes totales del socio 2 son: {0}", abonosTotalesSocio2);
                    Console.WriteLine("Los interes ganandos totales del socio 2: {0}", interesesTotalesSocio2);
                    Console.WriteLine("Los bonos totales del socio 2 {0}: ", bonificacionesSocio2);
                    Console.WriteLine("Las sumatoria de multas totales del socio 2: {0}", multaSocio2 * 20000);
                    Console.WriteLine("La deuda total por prestamos del socio 2: {0}", prestamoSocio2);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("La suma de las ganancias del socio 2 son: {0}", ahorroTotalSocio2);
                    Console.WriteLine("La suma de las perdidas totales del socio 2 son {0}", prestamoSocio2 + (multaSocio2 * 20000));
                    Console.WriteLine("El total del socio 2: {0}", ahorroTotalSocio2 - (prestamoSocio2 + (multaSocio2 * 20000)));
                    Console.WriteLine("------------------------------------------------------");
                }
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("\n");
                do
                {
                    Console.WriteLine("¿Desea calcular un nuevo año de la natillera? s/ n");
                    desicionNatillera = Console.ReadLine().ToLower();

                    if (desicionNatillera=="n")
                    {
                        natillera=false;
                        break;
                    }
                    else if (desicionNatillera=="s")
                    {
                        abonoSocio1 = 0;
                        ahorroTotalSocio1 = 0;
                        bonificacionesSocio1 = 0;
                        interesesSocio1 = 0;
                        interesesTotalesSocio1 = 0;
                        prestamoSocio1 = 0;
                        abonosTotalesSocio1 = 0;
                        bonoSocio1 = 0;
                        abonoSocio2 = 0;
                        ahorroTotalSocio2 = 0;
                        bonificacionesSocio2 = 0;
                        interesesSocio2 = 0;
                        interesesTotalesSocio2 = 0;
                        prestamoSocio2 = 0;
                        abonosTotalesSocio2 = 0;
                        bonoSocio2 = 0;
                        cantidadSocios = 0;
                        multaSocio1 = 0;
                        multaSocio2 = 0;
                        hayPrestamoSocio1 = false;
                        hayPrestamoSocio2 = false;
                        natillera = true;
                        intereMes = 0;
                        desicionSocio1 = "";
                        desicionSocio2 = "";
                        desicionNatillera = "";
                        break;
                    }

                } while (true);


            } while (natillera);


        }
    }
}

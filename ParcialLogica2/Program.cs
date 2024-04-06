using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLogica2
{
    internal class Program
    {
        static void Main(string[] args)
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
                Natillera, PARTE 2!
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
                Condiciones para la resolución del parcial:
                1. El parcial tendrá una duración de 3 horas: Desde las 20:00 hasta las 23:00
                2. Recuerda crear tu repositorio para resolver el parcial y por cada punto, crear su respectiva rama.
                3. A medida que vas desarrollando los dos algoritmos, debes de hacer “Commit All And Sync” de tus
                cambios de forma progresiva, de tal manera que se vea el historial de commits realizados durante las 3
                horas de parcial. Está prohibido hacer un solo commit al final del parcial. Los comentarios de los
                commits que sean legibles y claros.
                4. Asegúrate de que hayas subido todos los cambios al repositorio.
                5. Todo commit que se haga después de las 23:00 pm no será tenido en cuenta para ser calificado.
                6. Grabar un video expositivo (comparten pantalla y hablan) de tu parcial, donde deberás mostrar lo
                siguiente:
                - Una explicación bien clara y técnica de los dos códigos, hágase de cuenta que estás presentando
                tu tesis a un jurado. Si presentó alguna dificultad, explicarla y mostrarla también, los errores y los
                problemas también hacen parte de la vida de un desarrollador y es válido que se les presente en
                el camino, siempre y cuando tengan la capacidad de justificarlos.
                - Mostrar el historial de commits (este historial se puede ver en Visual Studio desde la opción
                View/Git Repository)
                - Mostrarás ambos algoritmos ejecutándose para ver sus resultados.
                La duración del video será de máximo 5 minutos y lo podrán subir a cualquier canal, tales como YouTube,
                Vimeo o en el mismo Teams. Si la sube por teams, no olvides darme permisos para acceder al video.
                7. Subir el usuario de GitHub y el link del video en el Excel llamado “UsersGitHub_VideoParcial2”, en el
                mismo Teams se encuentra dicho archivo. Este video debe quedar subido dentro de las 3 horas de parcial,
                no se aceptan videos después de las 23:00.
                7. Hacer uso de todos los recursos usados y explicados en clase, no aceptaré ver arrays, lists, collections,
                foreachs, y estructuras complejas que no se han visto a lo largo del curso. Calificaré solamente con base
                a los temas vistos en clase. ¡Recuerden que la libertad la tienen es en la imaginación que ustedes utilizan
                para aplicar la resolución de los algoritmos, la lógica!
             * 
             */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase 1
            Console.WriteLine("Bienvenidos a C#");
            //Clase 2
            int edad = 28;

            Console.WriteLine(edad);

            //Clase 3 Operaciones Aritmeticas + - / * % ++ -- += -=
            Console.WriteLine(5.0/2.0);
            Console.WriteLine(5.0%2.0);
            Console.WriteLine(5 + 7);
            int edad2 = 27;
            Console.WriteLine("Tienes una edad de " + edad2 + " años");
            //Ahora con interpolacion de Strings
            Console.WriteLine($"Tienes una edad de {edad} años");

            //Clase 04 Operador de Asignacion

            var variableDeEjecucion = 25; // A esta vble se le da el tipo en tiempo de ejecucion, no se la puede declarar
                                          //Sin asignarle el valor y tampoco puede cambiar el valor por otro tipo
                                          //En VisualBasic si se le puede declarar con un float por ej y despues asignarle
                                          //un String. Aca no, muere con ese valor y tipo
            Console.WriteLine(variableDeEjecucion);

            //Conversion de datos Explicitos(Casteo)

            double temperatura = 25.0;
            long temperaturaReal = (long)temperatura;

            //Conversion Implicita: Solo se puede hacer entre algunos tipos de datos, habria que ver un cuadrito de eso

            int numero1 = 5;
            long numero2 = numero1;

            float decimal1 = 59.45F;
            double decimal2 = decimal1;



        }
    }
}

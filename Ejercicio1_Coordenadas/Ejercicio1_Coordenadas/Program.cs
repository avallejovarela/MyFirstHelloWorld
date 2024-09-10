using System.Runtime.Intrinsics.X86;

public class Program
{
    // Lea las coordenadas de dos puntos y que muestre la distancia entre dos puntos.

    /*
     * bloque
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Datos de entrada
        //Declarar las variables

        double x1, x2, y1, y2, d;

        //Vamos a inicializar mis variables pidiendoles sus valores por pantalla:
        Console.Write("Porfavor ingrese el valor de x1: "); //Forma de escribir en pantalla
        x1 = Convert.ToDouble(Console.ReadLine()); //Forma de Leer en pantalla

        Console.Write("Porfavor ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Porfavor ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Porfavor ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Calculo de la variable "d";
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y; 

        // La clase Math tiene muchos metodos, entre ellos el metodo Sqrt, este señor recibe un parametro dentro de sus (), ese parametro esel numero que yo le mando al metodo para que me saque la Raiz Cuadrada!

        d = Math.Sqrt(suma);

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //Forma mas primitiva de contatenar texto a traves del simbolo "+"
        Console.WriteLine("Concatenar con +");
        Console.Write("la distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," +y2 + ") es: " + d);

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        // Forma de concatenar a través del simbolo "$" se llama Interpolación:
        Console.WriteLine("Concatenar con $");
        Console.Write($"La distancia entre los pares ordenados ({x1},{y1}) y ({x2},{y2}) es: {d}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //Forma de concatenar con la clase String.Format:
        Console.WriteLine("Concatenar con String.Format");
        Console.Write(String.Format("La distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es: {4}", x1, y1, x2, y2, d));

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");


    }
}
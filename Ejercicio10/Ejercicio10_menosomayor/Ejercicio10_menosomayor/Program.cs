using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" ejercicio 10 ");

        
        //Construir un programa que pida por pantalla 3 números y luego diga Cuál es el mayor, el del medio y el menor de los números ingresados;

        double num1, num2, num3, menor, medio, mayor;

        Console.WriteLine(" ");
        Console.WriteLine(" ");


        Console.Write("Ingrese primer numero ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ");

        Console.Write("Ingrese segundo numero ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ");

        Console.Write("Ingrese tercer numero ");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            if (num2 > num3)
            {
                medio = num2;
                menor = num3;

            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            if (num1 > num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else {
            mayor = num3;
            if (num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {  medio = num2;
                menor = num1;         
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.Write($"El mayor numero de los tres seleccionados es: {mayor}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.Write($"El numero del medio de los tres seleccionados es: {medio}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.Write($"El menor numero de los tres seleccionados es: {menor}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

    }
}
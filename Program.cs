﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2_consola

    { class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; 

        
        switch (op)
        {
            case "s":
                result = num1 + num2;
                break;
            case "r":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            
            default:
                break;
        }
        return result;
    }
}


    
 class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
           
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            
            Console.Write("Escriba un numero luego presione enter ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("No es valido ingresar un numero entero ");
                numInput1 = Console.ReadLine();
            }

            
            Console.Write("Escriba otro numero y luego presione enter");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Esta entrada no es valida ingrese un numero entero");
                numInput2 = Console.ReadLine();
            }

           
            Console.WriteLine("Elija una opcion de la siguiente lista");
            Console.WriteLine("\ts - suma");
            Console.WriteLine("\tr - resta");
            Console.WriteLine("\tm - multiplicar");
            Console.WriteLine("\td - dividir");
            Console.Write("Escriba tu opcion");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Esta operacion resulto en un error matematico\n");
                }
                else Console.WriteLine("Tu resultado {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no!se produjo un error al intentar realizar los calculos\n - Detalles: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            
            Console.Write("Presione 'n' y enter para cerrar la aplicacion o presione cualquier otra tecla para continuar");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); 
        }
        return;
    }

}
}
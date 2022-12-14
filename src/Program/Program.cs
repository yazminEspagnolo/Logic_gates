//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library;

/// <summary>
/// Clase que representa el programa principal.
/// </summary>
public class Program
{
    /// <summary>
    /// Main del programa.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        try
        {
            Compuerta_and and1 = new Compuerta_and("AND-1");
            IInput primer_valor  = new Logic_input(1);
            IInput segundo_valor  = new Logic_input(1);
            and1.AgregarEntrada("A", primer_valor);
            and1.AgregarEntrada("B", segundo_valor);

            Compuerta_or or2 = new Compuerta_or("OR-2");
            IInput tercer_valor = new Logic_input(0);
            or2.AgregarEntrada("C", tercer_valor);
            or2.AgregarEntrada(and1.Nombre, and1);

            Compuerta_not not3 = new Compuerta_not("NOT-3");
            not3.AgregarEntrada(or2.Nombre, or2);
            
            Console.WriteLine(not3.Resultado());
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("El valor ingresado no es válido.");
        }
        catch (CantidadDeEntradasExcepcion)
        {
            Console.WriteLine("La cantidad de entradas no es válida.");
        }
    }
}
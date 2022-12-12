namespace Library;
using System.Collections.Generic;
/// <summary>
/// Clase abstracta que representa una compuerta.
/// </summary>
public abstract class Compuerta

{
    /// <summary>
    /// Este es el constructor de la clase Compuerta.
    /// </summary>
    public Compuerta(string nombre)
    {
        this.Entradas = new Dictionary<string, IInput>(); // Inicializa el diccionario (Un diccionario es una estructura de datos que permite almacenar pares de valores).   
        this.Nombre = nombre;
    }

    /// <summary>
    /// Creo un diccionario de entradas.
    /// </summary>
    
    public Dictionary<string, IInput> Entradas { get; set; }
    /// <summary>
    /// Creo un atributo nombre.
    /// </summary>
    public string Nombre { get; set; }
   
    /// <summary>
    /// Metodo que agrega una entrada al diccionario.
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="valor"></param>
    public void AgregarEntrada(string nombre, IInput valor)
    {
        if (!Entradas.ContainsKey(nombre)) //Si nombre no esta en el diccionario lo agrega. ContainKey es un metodo de la clase Dictionary que devuelve true si el diccionario contiene la clave especificada.
        {
            Entradas.Add(nombre, valor);
        }
        else 
        {
            Entradas[nombre] = valor;    // Si nombre esta en el diccionario, actualiza el valor de la entrada.         
        }        
    }

    /// <summary>
    /// Metodo que devuelve el resultado de la compuerta.
    /// </summary>
    public abstract int Resultado();

}
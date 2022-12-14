using System;
namespace Library;

/// <summary>
/// Clase que representa una excepción de cantidad de entradas.
/// </summary>
public class CantidadDeEntradasExcepcion : Exception
{
    /// <summary>
    /// Constructor de la excepción.
    /// </summary>
    public CantidadDeEntradasExcepcion(string message) : base(message)
    {

    }
}

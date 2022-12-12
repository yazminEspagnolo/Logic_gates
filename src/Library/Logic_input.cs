namespace Library;

/// <summary>
/// Clase que representa el input de la compuerta.
/// </summary>
public class Logic_input : IInput
{
    /// <summary>
    /// Valor de la compuerta.
    /// </summary>
    public int Valor { get; set; }

    /// <summary>
    /// Este es el constructor de la clase Logic_input.
    /// </summary>
    /// <param name="valor"></param>
    public Logic_input(int valor)
    {
        this.Valor = valor;
    }

    /// <summary>
    /// Retorna el valor de la compuerta.
    /// </summary>
    public int Resultado()
    {
        return Valor;
    }
}
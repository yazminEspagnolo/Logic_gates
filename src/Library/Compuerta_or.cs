namespace Library;
/// <summary>
/// Clase que representa una compuerta or.
/// </summary>
public class Compuerta_or : Compuerta, IInput
{
    /// <summary>
    /// Este es el constructor de la clase Compuerta_or.
    /// </summary>
    public Compuerta_or(string nombre) : base(nombre)
    { 
    }
    /// <summary>
    /// Metodo que devuelve el resultado de la compuerta or.
    /// </summary>
    public override int Resultado()
    {
        int resultado = 0;
        foreach (var entrada in Entradas)
        {
            if (entrada.Value.Resultado() == 1)
            {
                resultado = 1;
            }
            else if (entrada.Value.Resultado() == 0 && resultado == 0)
            {
                resultado = 0;
            }
        }
        return resultado;
    }
}
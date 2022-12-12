namespace Library;
/// <summary>
/// Clase que representa una compuerta not.
/// </summary>
public class Compuerta_not : Compuerta
{
    /// <summary>
    /// Este es el constructor de la clase Compuerta_not.
    /// </summary>
    /// <param name="nombre"></param>
    /// <returns></returns>
    public Compuerta_not(string nombre) : base(nombre)
    {  
    }
    /// <summary>
    /// Metodo que devuelve el resultado de la compuerta not.
    /// </summary>
    public override int Resultado()
    {
        int valor = 0;
        foreach (var entrada in Entradas)
        {
            if (entrada.Value.Resultado() == 0)
            {
                valor = 1;
            }
            else if (entrada.Value.Resultado() == 1)
            {
                valor = 0;
            }
        }
        return valor;
    }
}
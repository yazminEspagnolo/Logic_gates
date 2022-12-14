
namespace Library;
/// <summary>
/// Clase que representa una compuerta and.
/// </summary>
public class Compuerta_and : Compuerta, IInput
{
    /// <summary>
    /// Este es el constructor de la clase Compuerta_and.
    /// </summary>
    /// <param name="nombre"></param>
    public Compuerta_and (string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Este metodo devuelve el resultado de la compuerta and.
    /// </summary>
    public override int Resultado()
    {
        if (Entradas.Count != 2)
        {
            throw new CantidadDeEntradasExcepcion("La compuerta and debe tener 2 entradas");
        }
            foreach (IInput entrada in Entradas.Values)
            {
                if (entrada.Resultado() == 0)
                {
                    return 0;
                }
            }
            return 1;

        /* int valor = 1;
        foreach (IInput entrada in Entradas.Values)
        {
            valor = valor * entrada.Resultado();
        }
        return valor; */
    }
}
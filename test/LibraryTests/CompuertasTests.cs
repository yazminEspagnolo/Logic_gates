using NUnit.Framework;
using Library;

namespace LibraryTests;

/// <summary>
/// Clase de tests
/// </summary>
public class Tests
{
    Logic_input on = new Logic_input(1);
    Logic_input off = new Logic_input(0);

    /// <summary>
    /// Testea la clase CompuertaAND
    /// </summary>
    [Test]
    public void Compuerta_and_Test()
    {        
        Compuerta_and and1 = new Compuerta_and("AND-1");
        and1.AgregarEntrada("A", on);
        and1.AgregarEntrada("B", off);
        Assert.AreEqual(1, and1.Resultado());
        and1.AgregarEntrada("A", off);
        Assert.AreEqual(0, and1.Resultado());
        try
        {
            and1.AgregarEntrada("C", on);
            and1.Resultado();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
    }
    /// <summary>
    /// Testea la clase CompuertaO
    /// </summary>
    [Test]
    public void Compuerta_Or_Test()
    {
        Compuerta_or or1 = new Compuerta_or("OR-1");
        or1.AgregarEntrada("A", off);
        try
        {
            or1.Resultado();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
        or1.AgregarEntrada("B", on);
        Assert.AreEqual(1, or1.Resultado());

        or1.AgregarEntrada("B", off);
        Assert.AreEqual(0, or1.Resultado());        
    }
    /// <summary>
    /// Testea la clase CompuertaNOT
    /// </summary>
    [Test]
    public void Compuerta_Not_Test()
    {
        Compuerta_not not1 = new Compuerta_not("NOT-1");
        not1.AgregarEntrada("A", off);
        Assert.AreEqual(1, not1.Resultado());
        try
        {
            not1.AgregarEntrada("C", off);
            not1.Resultado();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
    }
    /// <summary>
    /// Testea un circuito de AND, OR, NOT
    /// </summary>
    [Test]
    public void CircuitoTest()
    {
        Compuerta_and and1 = new Compuerta_and("AND-1");
        and1.AgregarEntrada("A", on);
        and1.AgregarEntrada("B", on);
        Assert.AreEqual(1, and1.Resultado());

        Compuerta_or or2 = new Compuerta_or("OR-2");
        or2.AgregarEntrada("C", off);
        or2.AgregarEntrada(and1.Nombre, and1);
        Assert.AreEqual(1, or2.Resultado());

        Compuerta_not not3 = new Compuerta_not("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2);
        Assert.AreEqual(0, not3.Resultado());
    }    
}
namespace Tests;


using NUnit.Framework;

public class Tests
{
    // Función que se está evaluando (puedes modificarla según tu lógica real)
    public bool MiFuncion(bool a, bool b, bool c)
    {
        return c && (a && b || !a && !b);  // Ejemplo cualquiera, ajusta la lógica según lo esperado
    }

    [Test]
    public void Test1()
    {
        var testCases = new (bool a, bool b, bool c, bool expected)[]
        {
            (false, false, false, false),
            (true, false, false, false),
            (false, true, false, false),
            (true, true, false, false),
            (false, false, true, true),
            (true, false, true, false),
            (false, true, true, false),
            (true, true, true, true)
        };

        foreach (var (a, b, c, expected) in testCases)
        {
            var result = MiFuncion(a, b, c);
            Assert.AreEqual(expected, result, $"Fallo con entrada: a={a}, b={b}, c={c}");
        }
    }
}
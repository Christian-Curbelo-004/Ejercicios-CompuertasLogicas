namespace Tests
{
    using NUnit.Framework;

    public class Tests
    {
        
        public bool Evaluate(bool a, bool b, bool c)
        {
            return c && ((a && b) || (!a && !b));
        }

        [Test]
        public void Test1()
        {
            var testCases = new (bool a, bool b, bool c, bool expected)[]
            {
                (false, false, false, false),
                (true,  false, false, false),
                (false, true,  false, false),
                (true,  true,  false, false),
                (false, false, true,  true),
                (true,  false, true,  false),
                (false, true,  true,  false),
                (true,  true,  true,  true)
            };

            foreach (var (a, b, c, expected) in testCases)
            {
                var result = Evaluate(a, b, c);
                Assert.That(result, Is.EqualTo(expected),
                    $"Fallo con entrada: a={a}, b={b}, c={c} — esperado: {expected}, obtenido: {result}");
            }
        }
    }
}

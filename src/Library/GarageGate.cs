namespace CompuertasLogicas.Library;

public class GarageGate
{
    public static bool Evaluate(bool a, bool b, bool c)
    {
        // Crear instancias de las compuertas lógicas
        var notA = new NOTgate();
        var notB = new NOTgate();
        var and1 = new ANDgate();
        var and2 = new ANDgate();
        var and3 = new ANDgate();
        var and4 = new ANDgate();
        var or = new ORgate();

        // Calcular NOT a y NOT b
        bool na = notA.Evaluate(a);
        bool nb = notB.Evaluate(b);

        // Calcular c AND NOT b
        bool cAndNb = and1.Evaluate(c, nb);

        // Calcular (c AND NOT b) AND NOT a
        bool term1 = and2.Evaluate(cAndNb, na);

        // Calcular c AND b
        bool cAndB = and3.Evaluate(c, b);

        // Calcular (c AND b) AND a
        bool term2 = and4.Evaluate(cAndB, a);

        // Calcular el resultado final: term1 OR term2
        bool result = or.Evaluate(term1, term2);

        return result;
    }
}
namespace CompuertasLogicas.Library;

public class GarageGate
{
    public static bool Evaluate(bool a, bool b, bool c)
    {
        // Crear instancias de las compuertas lógicas
        var notA = new NotGate(a);
        var notB = new NotGate(b);
        //var and1 = new AndGate(c,nb);
        //var and2 = new AndGate();
        var and3 = new AndGate(c, b);
        //var and4 = new AndGate();
        //var or = new OrGate(term1,term2);

        // Calcular NOT a y NOT b
        bool na = notA.Evaluate();
        bool nb = notB.Evaluate();

        // Calcular c AND NOT b
        var and1 = new AndGate(c, nb);
        bool cAndNb = and1.Evaluate();

        // Calcular (c AND NOT b) AND NOT a
        var and2 = new AndGate(cAndNb, na);
        bool term1 = and2.Evaluate();

        // Calcular c AND b
        bool cAndB = and3.Evaluate();

        // Calcular (c AND b) AND a
        var and4 = new AndGate(cAndB, a);
        bool term2 = and4.Evaluate();

        // Calcular el resultado final: term1 OR term2
        var or = new OrGate(term1, term2);
        bool result = or.Evaluate();

        return result;
    }
}

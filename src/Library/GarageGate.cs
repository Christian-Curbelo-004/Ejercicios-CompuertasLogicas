namespace CompuertasLogicas.Library
{
    public class GarageGate
    {
        public static bool Evaluate(bool a, bool b, bool c)
        {
            // instancias de las compuertas lógicas
            var notA = new NotGate(a);
            var notB = new NotGate(b);

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
            var and3_cb = new AndGate(c, b); // renombrado para evitar conflicto
            bool cAndB = and3_cb.Evaluate();

            // Calcular (c AND b) AND a
            var and4 = new AndGate(cAndB, a);
            bool term2 = and4.Evaluate();

            // Calcular el resultado final: term1 OR term2
            var orFinal = new OrGate(term1, term2); // renombrado para evitar conflicto
            bool result = orFinal.Evaluate();

            return result;
        }
    }
}

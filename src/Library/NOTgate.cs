namespace CompuertasLogicas.Library;

using System;
using System.Collections.Generic;

public class NotGate : IGate
{
    private List<bool> inputs = new List<bool>();
    public NotGate(bool input1)
    {
        this.inputs.Add(input1);
    }

    public void AddInput(bool input)
    {
        inputs.Add(input);
    }
    public bool Evaluate()
    {
        if (inputs.Count != 1)
        {
            Console.WriteLine("La compuerta Not debe tener solamente una entrada");
            return false;
        }
        return !inputs[0];
    }
    public bool Output()
    {
        return Evaluate();
    }
}




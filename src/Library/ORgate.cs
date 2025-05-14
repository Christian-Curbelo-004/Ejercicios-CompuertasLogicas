namespace CompuertasLogicas.Garage
{
    public class OrGate : IGate
    {
        private List<bool> inputs = new List<bool>();

        public ORgate(bool input1, bool input2)
        {
            this.inputs.Add(input1);
            this.inputs.Add(input2);
        }

        public void AddInput(bool input)
        {
            inputs.Add(input);
        }

        private bool Evaluate()
        {
            bool result = false;
            foreach (bool input in inputs)
            {
                result = result || input;
            }
            return result;
        }

        public bool Output()
        {
            if (inputs.Count < 2)
            {
                Console.WriteLine("Solo una entrada guardada");
                return false;
            }
            else
            {
                return Evaluate();
            }
        }
    }
}

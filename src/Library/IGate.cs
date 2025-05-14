namespace CompuertasLogicas.Garage; // Aplica las compeurtas logicas

public interface IGate
{
   public bool Output();
   private bool Evaluate();
}
namespace CompuertasLogicas.Garage; // Aplica las compeurtas logicas

public interface IGate
{
    bool Valid(bool a, bool b, bool c);
}
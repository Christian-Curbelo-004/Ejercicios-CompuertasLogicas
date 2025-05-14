namespace CompuertasLogicas.Garage
{
    public class NOTgate: IGate
    {
        public override bool Valid (bool a, bool b, bool c)
        {
            return !a; // devuelve valor negado
        }
    }
}


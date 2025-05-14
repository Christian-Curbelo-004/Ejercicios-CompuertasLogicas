    namespace CompuertasLogicas.Garage
    {
        public class ORgate : IGate
        {
            public override bool Valid(bool a, bool b, bool c)
            {
                return a || b || c; 
            }
        }
    }
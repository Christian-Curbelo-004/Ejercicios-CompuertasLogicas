namespace CompuertasLogicas.Library;

using System;
using System.Collections.Generic;

public interface IGate
{
   public bool Output();
   public bool Evaluate();
}
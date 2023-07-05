using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
  public class BottledDrink : IDrink
  {
    public int Id {get; private set;}

    public void Drink()
    {
      throw new NotImplementedException();
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
  public interface IRestaurantWorker
  {
    decimal Salary {get;}
    void Work();
  }
}
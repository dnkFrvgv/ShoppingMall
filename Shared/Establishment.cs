using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
  public interface Establishment
  {
    void Open(int ownerId);
    void Close(int ownerId);
  }
}
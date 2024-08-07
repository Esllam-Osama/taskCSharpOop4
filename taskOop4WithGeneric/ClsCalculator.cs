using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOop4WithGeneric
{
  internal class ClsCalculator
  {
    public static bool AreEqual<T>(T a, T b)
    {
            /*
             Equals بتقارن قيمتين بس لازم يكونو من نفس النوع 
            يعنى مينفعش مثلا نقارن قمية فى استرينج و رقم 
             */
            if (a!=null && b!=null && a.GetType() == b.GetType())
            return a.Equals(b);
            else
            return false;
    }
  }
}

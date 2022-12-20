using OOpEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEncapsulationContinue;
internal class Weed : Plant
{
    static void Main(string[] args)
    {
        Weed weed = new();
        weed.Protected();
        weed.ProtectedInternal();
        weed.Public();
     //   weed.PrivateProtected(); trong cung do an moi dung duoc nghe chua
    }
}

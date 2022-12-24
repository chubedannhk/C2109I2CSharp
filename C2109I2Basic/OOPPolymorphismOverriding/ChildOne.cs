using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphismOverriding;
internal class ChildOne:Parent
{
    public override void Display() => Console.WriteLine("Chiledone display");

    public new void Show() => Console.WriteLine("chileDone show");
}

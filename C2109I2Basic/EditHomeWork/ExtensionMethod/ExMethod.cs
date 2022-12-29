using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EditHomeWork.ExtensionMethod;
static class ExMethod
{
    public static void ChangeColor<T>(this T item, params ConsoleColor[] colors)
    {
        Console.BackgroundColor = colors[0];
        Console.ForegroundColor = colors[1];
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod;
internal static class ExtensionMethod
{
    // 1 class ma la static thi toan bo class la static
    public static void CheckIsGreaterThan(this int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i} dung la lon hon cai {value}");
        }
    }
    public static void Hello(this Program pro)
    {
        Console.WriteLine("Ahihi do ngoc");
    }
}

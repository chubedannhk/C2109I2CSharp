using EditHomeWork.Dal;
using EditHomeWork.ExtensionMethod;
using EditHomeWork.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditHomeWork.Menu;
internal class MainMenu
{
    public static void Shows()
    {
        DalProduct dal = new();
        bool i = true;

        while (i = true)
        {
            dal.ChangeColor(ConsoleColor.White, ConsoleColor.Red);
            Console.WriteLine("Please Choose: ");
            Console.WriteLine("1. Input product");
            Console.WriteLine("2. Show List product");
            Console.WriteLine("0. Exit program");
            var n = Validate<int>.Input("Please enter number");
            switch (n)
            {
                case 1: dal.ChangeColor(ConsoleColor.White, ConsoleColor.Blue); dal.Add();break;
                case 2: dal.Show(); break;
                case 0: i = false ;return;
            }
        }
    }
}

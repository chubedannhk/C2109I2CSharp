using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProlymorphismOverloading;
internal class BasicMath
{
    public int NumberOne { get; set; }
    public int NumberTwo { get; set; }
    // ctor + enter => sinh contructor khong co tham so

    // overloading cung ten chi khac tham so hay kieu cua tham so ( 1 la constructor, 2 la method)
    // c# bo luon viet kieu nay
    //public BasicMath()
    //{

    //}

    //public BasicMath(int numberOne, int numberTwo)
    //{
    //    NumberOne = numberOne;
    //    NumberTwo = numberTwo;
    //}

    //overloading method
    // optional argument => doi so lua chon truyen cho tham so (parameter)
    public void Sum(int num1 = 0, int num2 = default)
    {
        NumberOne= num1;
        NumberTwo= num2;
        Console.WriteLine(NumberOne + NumberTwo);
    }

    //public void Sum()
    //{
    //    NumberOne = 0;
    //    NumberTwo = 4;
    //    Console.WriteLine(NumberOne + NumberTwo);
    //}
}

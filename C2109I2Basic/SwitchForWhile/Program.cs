// format code : Ctrl + K + D
using System.Collections;

int number1 = Random.Shared.Next(0, 10);
int number2 = Random.Shared.Next(0, 10);
Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");
Console.WriteLine("Vui long nhap dau cua phep toan (+,-,*,/): ");
// de dau ? cung dc ,khong de cung dc
string? dau = Console.ReadLine();

//switch (dau)


//{
//    case "+" when number1>0 && number2>0: Console.WriteLine(number1 + number2); break;
//    case "-" when number1 >= number2 : Console.WriteLine(number1- number2); break;
//    case "*": Console.WriteLine(number1* number2); break;
//    case "/" when number2!=0: Console.WriteLine(number1/ number2); break;
//    default: Console.WriteLine("ngu nhu cho");break;

//}

// switch expression ( bieu thuc switch case)
Console.WriteLine(
    dau switch
    {
        "+" when number1 > 0 && number2 > 0 => number1 + number2,
        "-" when number1 >= number2         => number1 - number2,
        "*"                                 => number1 * number2,
        "/" when number2 != 0               => number1 / number2,
        _ => "ahihi, i can't"
    }
);

string[] arrs = { "khai", "tin", "anh", "huy" };

foreach (var arr in arrs)
{
    Console.WriteLine(arr);
}


// nho phai viet nhu vay moi dung
//int i = 0;
//int chieudaimang = arrs.Length;
//while (i< chieudaimang)
//{
//    Console.WriteLine(arrs[i]);
//    i++;
//}

// vong lap nay nhanh hon vong lap foreach
IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = e.Current.ToString();
    Console.WriteLine(s);
}

// ket thuc nha
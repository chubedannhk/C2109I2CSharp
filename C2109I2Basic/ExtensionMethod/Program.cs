using System.Text;
using ExtensionMethod;

Console.WriteLine("Vui long nhap vao gia tri cho bien i : ");
int i = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
CheckNumber.CheckIsGreaterThan(i, 100);
// viet phuong thuc nay nhanh va nhe hon rat nhieu
i.CheckIsGreaterThan(100);

Program pro = new();
pro.Hello();

namespace PratialClass;
internal partial class Human
{
    // 1 phuong thuc ma chi co 1 cau lenh thi CSharp se khong su dung phuong thuc ma dung "expression boby =>" bieu thuc duoi dang phuong thuc
    public void Show() => Console.WriteLine($"{nameof(fullName)}={fullName}");

    public void Check() => Console.WriteLine(10 > 5 ? true : false);
 
}



namespace HomeWorkClassSinhVien;
internal class SinhVien
{
    

    public string Code { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string DoB { get; set; }
    public SinhVien()
    {
    }

    public void Input()
    {
        Console.WriteLine("Enter Code Student: ");
        Code =Console.ReadLine();
        Console.WriteLine("Enter Name Student: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Gender Student: ");
        Gender = Console.ReadLine();
        Console.WriteLine("Enter Date Of Birth Student: ");
        DoB = Console.ReadLine();
    }

    public void Output() => Console.WriteLine($"Code: {Code}, Name: {Name},Gender: {Gender}, DoB: {DoB}");
}

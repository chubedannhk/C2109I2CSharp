namespace OOPAbstraction;
internal class Dog : Animal
{
    // thuc thi lai cai phuong thuc abstract cua animal buoc phai dung tu khoa override vao
    public override void ShowInfo()
    {
        Console.WriteLine("This is a dog");
    }
}


namespace OOPAbstraction;

// ke thua dung dau :
internal abstract class Cat:Animal
{
    // con ke thua cha, ma cha abstract => thang con phai thuc thi lai cac phuong thuc abstract, neu khong con cung la abstract
    private bool gender;
    public void ShowCat() => Console.WriteLine("This is a cat" );
}

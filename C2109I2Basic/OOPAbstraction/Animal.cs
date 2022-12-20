
namespace OOPAbstraction;
internal abstract class Animal
{
    // khoi tao field 
    private string fullName;
    private int age;

    // 1 method khong co body {} => la abstract
    // 1 method la abstract => class phai la abstract
    public abstract void ShowInfo();

}

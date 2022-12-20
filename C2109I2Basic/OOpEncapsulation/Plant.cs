
namespace OOpEncapsulation;
public class Plant
{
    // access modifier => bo tu truy cap
    private void Private() => Console.WriteLine("private");
    protected void Protected() => Console.WriteLine("protected");
    internal void Internal() => Console.WriteLine("internal");
    private protected void PrivateProtected() => Console.WriteLine("private protected");
    protected internal void ProtectedInternal() => Console.WriteLine("protected internal");
    public void Public() => Console.WriteLine("public");

    //static void Main(string[] args)
    //{
    //    Plant planle = new();
    //    planle.Public();
    //    planle.Protected();
    //    planle.ProtectedInternal(); 
    //    planle.Internal();
    //    planle.PrivateProtected();
    //    planle.Private();
    //}
}

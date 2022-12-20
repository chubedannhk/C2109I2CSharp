
namespace OOpEncapsulation;
internal class Sunflower : Plant
{
    static void Main(string[] args)
    {
        Sunflower flower = new();
        flower.Protected(); // la con nen duoc quyen su dung
        flower.Internal(); // trong cung project/assembly
        flower.PrivateProtected();// hoac la private hoac la protected thi dung su dung
        flower.ProtectedInternal();
        flower.Public();
    //     flower.Private(); // khong duoc phep dung
    }
}

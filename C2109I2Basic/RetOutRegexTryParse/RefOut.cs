
namespace RetOutRegexTryParse;
internal class RefOut
{
    //    public static void ChangeVar(ref int a, ref int b)
    //    {
    //        var item = a;
    //        a= b; 
    //        b= item;
    //    }
    public static void ChangeVar(out int a, out int b)
    {
        a = 10;
        b = 12;
        var item = a;
        a = b;
        b = item;
    }
}


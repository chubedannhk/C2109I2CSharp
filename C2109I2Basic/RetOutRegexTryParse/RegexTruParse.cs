


namespace RetOutRegexTryParse;
internal class RegexTruParse
{
    public void CheckNumberByRegex()
    {
        string? str = null;
        Console.WriteLine("Vui long nhap con so: ");
        str = Console.ReadLine();
        if (new Regex(@"^\d+$").IsMatch(str))
        {
            int resutl = int.Parse(str);
            Console.WriteLine($"{nameof(resutl)}={resutl}");
        }
    }
    public void CheckStringByTryParse()
    {
        string? str = null;
        Console.WriteLine("Vui long nhap so: ");
        str = Console.ReadLine();

        if(double.TryParse(str,out double i))
        {
            Console.WriteLine($"{nameof(i)}={i}");
        }
    }

    public void TryCatchBug()
    {
        Console.WriteLine("Vui long nhap so luong: ");
        string? amount = Console.ReadLine();
        try
        {
            int total = int .Parse(amount);
            if(total<=0)
            {
               // throw new Exception("Phai lon hon khong");
                Console.WriteLine("phai lon hon khong");
            }
        }
        catch (FormatException) when (amount.Contains("$"))
        {
            Console.WriteLine("Amount khong duoc co dau $");
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"{ex.GetType()}:{ex.Message}");
            Console.WriteLine("Error");
        }
    }
}

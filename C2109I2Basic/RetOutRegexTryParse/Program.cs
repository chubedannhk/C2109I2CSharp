
//int a = 10;
//int b = 12;
//// ref viet tat cua reference : dang tham chieu
//RefOut.ChangeVar(ref a,ref b);
//Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");


// out


//RefOut.ChangeVar(out int a, out int b);
//Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");


//regex
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
// pure oop => oop nguyen thuy, hay thuan oop => C# cux
//RegexTruParse parse = new RegexTruParse();
// dung tu var
//var par = new RegexTruParse();

// target-type C# new
RegexTruParse p = new();
//p.CheckNumberByRegex();

//p.CheckStringByTryParse();
p.TryCatchBug();
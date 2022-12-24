
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> students = new()
{
    new Student(){ Id = 1,Name="Nguyen Hoang Khai",Gender = true,Dob=new DateTime(2003,03,25)},
    new Student(){ Id = 2,Name="Nguyen Hoang Khai",Gender = true,Dob=new DateTime(2003,03,25)},
    new Student(){ Id = 3,Name="Nguyen Hoang Khai",Gender = true,Dob=new DateTime(2003,03,25)},
    new Student(){ Id = 4,Name="Nguyen Hoang Khai",Gender = true,Dob=new DateTime(2003,03,25)},
    new Student(){ Id = 5,Name="Nguyen Hoang kHoi",Gender = false,Dob=new DateTime(2003,03,25)},
};

// chay vua vua trong ba thang
//foreach(var stu in students)
//{
//    Console.WriteLine(stu);
//}

// vong lap forEach se chuyen thanh => chay nhanh nhat trong 3 thang
//IEnumerator<Student> enumerator = students.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current.ToString());
//}

// duyet qua list la ra ket qua luon => nhung lai chay cham nhat trong thang
//students.ForEach(Console.WriteLine);

// linq = language integrated query
// ling to sql => thay the cu phap sql trong C#
// linq to object => console
// sql => select from where group by having order by
// C# => from where groud by having order by ... select
// linq co 2 dang:
  // style 1 : query systax => dua theo cu phap cua sql , de hoc , de dung
  // style 2 : method syntax => dua theo lambda => kho hoc, kho dung, nhung cuc nhanh

// hien thi toan thong tin sinhvien trong list , voi dieu kien id  sv phai lon hon hai

//foreach(var stu in students)
//{
//    if(stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

// === style 1 cua linq:
// bien t : tu dat
// bien stu: tu dat
//var t = from stu in students where stu.Id>2 select stu;
//foreach(var i in t)
//{
//    Console.WriteLine(i);
//}
//// viet gon hon
//foreach (var i in from stu in students where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}

// style 2: cua linq: methods syntax => chay nhanh hon thang style 1
var t = students.Where(stu => stu.Id > 2);
foreach (var i in t)
{
    Console.WriteLine(i);
}

// rut gon
foreach ( var i in students.Where(stu => stu.Id > 2))
{
    Console.WriteLine(i);
}

// ke hop voi foreach cua list
students.Where(stu => stu.Id > 2).ToList().ForEach(stu => Console.WriteLine());
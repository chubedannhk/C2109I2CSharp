
using System.Collections;

namespace HomeWorkClassSinhVien;
internal class ListStudent
{

    public List<SinhVien> studentList { get; set; }

    public ListStudent() => studentList = new List<SinhVien>();

    public void Input()
    {
        Console.WriteLine("How many students do you want to enter?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0;i < n;i++)
        {
            SinhVien stu = new();
            stu.Input();
            studentList.Add(stu);
        }
    }
    public void Output()
    {
        foreach(var stu in studentList)
        {
            stu.Output();
        }
    }

    public void Removes()
    {
        // nhap code muon xoa
        Console.WriteLine("Enter Code you want REMOVE: ");
        string code = Console.ReadLine();
        //  studentList.RemoveAll(stu => stu.Code == code);

        var found = studentList.Where(stu => stu.Code == code).FirstOrDefault();

        if (found != null)
        {
            studentList.Remove(found);
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Error :))");
        }


    }

    public void Find()
    {
        Console.WriteLine("Enter Code you want FIND: ");
        string code = Console.ReadLine();
        var found = studentList.Where(stu => stu.Code == code).FirstOrDefault();

        if (found != null)
        {
            //studentList.Remove(found);
            Console.WriteLine($"Code: {found.Code},Name: {found.Name},Gender: {found.Gender},Date of Birth: {found.DoB}");
            Console.WriteLine($"Find Code {found.Code} Success!!! ");
        }
        else
        {
            Console.WriteLine("Error :))");
        }
    }

    public void SortDecs()
    {
        foreach (var i in from stu in studentList orderby stu.Code descending select stu)
        {
            i.Output();
        }
    }

    public void Update()
    {
        Console.WriteLine("If don't want to update a any information of student, input enter for skip. Please!!");
        Console.WriteLine("Enter Code you want UPDATE: ");
        string code = Console.ReadLine();
        var found = studentList.Where(stu => stu.Code == code).FirstOrDefault();
        if(found == null)
        {
            Console.WriteLine("Error :))) ");
        }
        else
        {
            foreach (var stu in studentList.Where(r => r.Code == code))
            {

                Console.WriteLine("Input Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Input Gender: ");
                string gender = Console.ReadLine();
                Console.WriteLine("Input DoB: ");
                string dob = Console.ReadLine();
                stu.Name = name;   
                stu.Gender = gender;
                stu.DoB = dob;
            }
            Console.WriteLine($"Code: {found.Code},Name: {found.Name},Gender: {found.Gender},Date of Birth: {found.DoB}");
            Console.WriteLine("Update Success");
        }
      
    }
}


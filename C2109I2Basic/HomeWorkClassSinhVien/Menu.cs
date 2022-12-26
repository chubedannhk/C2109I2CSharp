

namespace HomeWorkClassSinhVien;
internal class Menu
{
    public void ShowMenu()
    {
        bool choo = true;
        ListStudent list = new();
        while (choo)
        {
            Console.WriteLine("Input number your want, please!!! ");
            Console.WriteLine("1: Add student");
            Console.WriteLine("2: Show list student");
            Console.WriteLine("3: Remove any student from the list");
            Console.WriteLine("4: Update a any student from the list");
            Console.WriteLine("5: Find  a any student from the list");
            Console.WriteLine("6: DECS the list student");
            Console.WriteLine("0: Out program");
            int chooser = int.Parse(Console.ReadLine());
            switch (chooser)
            {
                case 1: list.Input(); break;
                case 2: list.Output(); break;
                case 3: list.Removes();list.Output(); break;
                case 5: list.Find();break;
                case 6: list.SortDecs();break;
                case 4: list.Update(); break;
                case 0: choo=false; break;
            }
        }
        Console.WriteLine("End");
    }
}

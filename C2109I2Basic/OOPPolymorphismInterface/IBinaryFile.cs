using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphismInterface;
internal interface IBinaryFile
{
    // khong dung bo tu truy ap (access modify)
    void WriteBinaryFile();
    void ReadFile();
    // co phuong thuc mac dinh ton tai trong interface
    void ShowInfo() => Console.WriteLine("This is binary");
}

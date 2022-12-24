using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphismInterface;
internal class ManyFile : IBinaryFile,ITextFile
{
    // bo di bo tu truy cap, sau do them ten interface phia trc
    void IBinaryFile.ReadFile() => Console.WriteLine("read file");
    void ITextFile.ReadFile() => Console.WriteLine("read file");
    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTextFile() => Console.WriteLine("write text file");
}

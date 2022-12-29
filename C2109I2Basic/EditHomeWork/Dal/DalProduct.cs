using EditHomeWork.entity;
using EditHomeWork.Helper;
using EditHomeWork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditHomeWork.Dal;
internal class DalProduct:IProduct
{
    // khoi tao list product
    public List<Product> list { get; set; } = new();
    public void Add()
    {
        var n = Validate<int>.Input("Input number of list");
        for(int i = 0; i < n; i++)
        {
            Product pro = new();
            pro.Id= Validate<string>.Input("Input Id");
            pro.Name = Validate<string>.Input("Input Name");
            pro.Price = Validate<double>.Input("Input Price");
            pro.Quantity = Validate<int>.Input("Input Quantity");
            pro.Mfg = Validate<DateTime>.Input("Input MFG");
            list.Add(pro);
        }
    }

    public void Show()
    {
        list.ForEach(Console.WriteLine);
    }
}

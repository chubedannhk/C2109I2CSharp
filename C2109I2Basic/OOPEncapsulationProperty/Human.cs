using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEncapsulationProperty;
internal class Human
{
    // 1 class gom 4 phan chinh: field, contrucster, property, method
    // field ( phai la private)
    private string fullName;
    

    // property => mobile
    public string FullName { get => fullName; set => fullName = value; }
    // public string Address { get => address; set => address = value; }
    // auto property => dap cai field thanh thuoc tinh luon
    public string Address {private get; set; }

    public void Hell()
    {
        Address = " 1223";
        Console.WriteLine(Address);
    }

    // cac phuong thuc getter va setter nhu java thi khong duoc su dung nua
    //public void SetFullName(string fullName)
    //{
    //    this.fullName = fullName;
    //}
    //public string GetFullName()
    //{
    //    return fullName; 
    //}


    // viet theo c#
    // cac thuoc tinh phai co bo tu truy cap la public
    //public string FullName
    //{
    //    set => fullName = value;
    //    get => fullName;
    //}
}

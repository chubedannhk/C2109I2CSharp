int number = 10;
double money = 10.3;
bool check = true;
string str = " nguyen hoang khai ";

// trong c sharp thuong co hai dang kieu chinh: 
// 1 value type : dang so (int, dounle, bit ,byte...) -> khong chua duoc null
// 2 reference type : dang chuoi , doi tuong ->cho phep null

string name = null;

// code old
Nullable<int> a = null;

// code new => ? nghia la nullable value type
int? b = null;
bool? c = null;

// ?: => ternary operator
Console.WriteLine(name!=null?true:false);
// is not null tuong duong (!=) trong C#
// is tuong duong (==)
Console.WriteLine(name is not null ? true : false);

// ? => null conditional operator
// ? dung phia sau ten bien, hay doi tuong
// ? tuong tu (!=), neu cai gi do khac null thi lay cai ve sau
int? lenght = name?.Length;

// viet ro ra thi nhu sau :
//if(name != null)
//{
//    lenght= name.Length;
//}
//else
//{
//    lenght = null;
//}

// ?? => null coalescing operator
// ?? tuong tu dau ==, neu cai gi do bang null thi lay cai ve sau
int? height = name?.Length ?? 10;
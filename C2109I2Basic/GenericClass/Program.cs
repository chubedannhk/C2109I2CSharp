using GenericClass;


// generic thuong viet tac bang cac ky hieu T,U,V
ClassK<int> cl = new();
cl.Field = 10;
cl.Show();
ClassK<string> cl1= new();
cl1.Field = "nguyenhoangakha";
cl1.Show();


ClassUV<bool,string> cl3= new();
cl3.Field1= true;
cl3.Field2 = "abc";
cl3.Show();

ClassUV<int, double> cl4 = new();
cl4.Field1 = 100;
cl4.Field2 = 105.12;
cl4.Show();
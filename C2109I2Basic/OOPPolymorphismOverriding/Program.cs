using OOPPolymorphismOverriding;

Parent pa = new();
pa.Show();
pa.Display();

ChildOne co = new();
co.Show();
co.Display();

// khoi tao doi tuong cha nhung tham chieu den thang con
Parent p = new ChildOne();
p.Display();
p.Show();// show cua cha chu khong phai la cua thang con
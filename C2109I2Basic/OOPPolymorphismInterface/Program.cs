using OOPPolymorphismInterface;

SomeFile some = new();
some.ReadFile();
some.WriteTextFile();
some.WriteBinaryFile();

((IBinaryFile)some).ShowInfo();

(some as IBinaryFile).ShowInfo();


ManyFile many= new();
many.WriteBinaryFile();
(many as IBinaryFile).ReadFile();
(many as IBinaryFile).ShowInfo();

many.WriteTextFile();
((ITextFile)many).ReadFile();

//=============
IBinaryFile bf= new SomeFile();
bf.ReadFile();
bf.ShowInfo();
bf.WriteBinaryFile();
bf = new ManyFile();
bf.ReadFile();
bf.ShowInfo();
bf.WriteBinaryFile();
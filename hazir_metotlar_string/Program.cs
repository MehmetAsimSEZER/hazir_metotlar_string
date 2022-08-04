// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string degisken = "Dersimiz CSharp, Hoşgeldiniz";
string degisken2 = "dersimiz CSharp, Hoşgeldiniz";

//length;
Console.WriteLine(degisken.Length);

//ToLower; ToUpper;
Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken2.ToUpper());

//Concat;
Console.WriteLine(string.Concat(degisken, "Merhaba"));

//Compare; CompareTo;
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(string.Compare(degisken, degisken2,true));
Console.WriteLine(string.Compare(degisken, degisken2,false));

//Contains;
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf; LastIndexOf;
Console.WriteLine(degisken.IndexOf("C"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert;
Console.WriteLine(degisken.Insert(0,"Merhaba!"));

//PadLeft; PadRight;
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

//Remove;
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5, 3));
Console.WriteLine(degisken.Remove(0, 1));

//Replace;
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "*"));

//Split;
Console.WriteLine(degisken.Split(' ')[1]);

//Substring;
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));
// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

Class1 class1= new Class1();  
int a=Convert.ToInt32(Console.ReadLine());
string x = Console.ReadLine();
int b=Convert.ToInt32(Console.ReadLine());

class1.Calc(a, b, x);
if (x == "/" && b == 0)
{
    Console.WriteLine(Class1.Errorenum.Cannot_Divide_into_0);
}
else if (x != "/"&&x!="+" && x != "-" && x != "*")
{
    Console.WriteLine(Class1.Errorenum.Wrong_Symbol + x);
}
Console.WriteLine(class1.Calc(a,b,x));


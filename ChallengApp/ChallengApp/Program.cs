// See https://aka.ms/new-console-template for more information

using System.Reflection;

var myLab = int.MaxValue - 5;
int myAge = 33;
Console.WriteLine(myLab);

int myVar1 = int.MinValue;
uint myVar2 = int.MaxValue;
long myVar3 = long.MaxValue;
var name = "Ewa";
var gender = "female";
var age = 25;

if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("NIC");
}




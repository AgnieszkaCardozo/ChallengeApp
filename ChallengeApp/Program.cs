using System.ComponentModel.Design;

var name = "Ewa";
var sex = "Kobieta";
var age = 33;


if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)

        Console.WriteLine("Ewa, lat 33");

else if (sex != "kobieta" && age < 18)

    Console.WriteLine("Niepełnoletni mężczyzna");


if (name != "Ewa" || age > 50 && sex == "Kobieta")
{ Console.WriteLine("Staruszka"); }



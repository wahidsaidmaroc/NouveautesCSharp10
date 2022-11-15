



using PatternMatching;

#region "Nouveaute 10"


Client client = new Client()
{
    dateCreation = new DateTime(1989, 12, 12),
};
//Avant : 

if (client is { dateCreation: { Year:1982} })
{
    ////
}

//Apres la vesrion 10 : 

if (client is { dateCreation.Year: 1982 })
{
    ////
}
#endregion




#region "Cette fonctionnalité est disponible à partir de C# 7.0."


//Null pattern: test par rapport à une valeur nulle, par exemple



Vehicle vehicle = new Car();
if (vehicle is null)
    Console.WriteLine($"{nameof(vehicle)} is null.");
else
    Console.WriteLine($"{nameof(vehicle)} is not null.");

//Constant pattern: test en comparant par rapport à une constante, par exemple:
object carAsObj = new Car();
if (carAsObj is "45")
    Console.WriteLine($"{nameof(carAsObj)} is 45.");
else
    Console.WriteLine($"{nameof(carAsObj)} is not 45.");


//Type pattern: l’expression est testée suivant un type particulier (possible avant C# 7.0):
Vehicle vehicleC = new Car();
if (vehicleC is Car)
    Console.WriteLine($"{nameof(vehicleC)} is a car.");
else if (vehicle is MotoBike)
    Console.WriteLine($"{nameof(vehicleC)} is a motobike.");
else
    Console.WriteLine($"{nameof(vehicleC)} has not been identified.");



#endregion


abstract class Vehicle
{
    public string nom;
    public abstract int GetPortCount();
}


class MotoBike : Vehicle
{
    public int Power => 100;

    public override int GetPortCount()
    {
        return 0;
    }
}

class Car : Vehicle
{
    public int PassengerCount => 5;

    public override int GetPortCount()
    {
        return 5;
    }
}
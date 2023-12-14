using oop;

string Name = Console.ReadLine();
DateOnly date = DateOnly.Parse(Console.ReadLine());
string Wings = Console.ReadLine();
string Wheel = Console.ReadLine();

Console.WriteLine("Journey by airplane");
var myPlane = new Airplane(Name,date,Wings);
myPlane.StartEngine("Contact");
myPlane.TakeOff(".....");
myPlane.Drive("Flying");
myPlane.Land("......");
myPlane.StopEngine("Whirr");

Console.WriteLine("Journey by car");
var myCar = new Car(Name,date,Wheel);
myCar.StartEngine("Brm brm");
myCar.Accelerate(".....");
myCar.Drive("Motoring");
myCar.Brake("....");
myCar.StopEngine("Phut Phut");
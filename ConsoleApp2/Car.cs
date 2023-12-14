
using Oop;

namespace oop
{
    internal class Car:Vehicle
    {
        public Car(string Name, DateOnly DateOnly, string Wheel) : base(Name, DateOnly)
        {
            this.Name = Name;
            this.DateOnly = DateOnly;
            this.Wheel = Wheel;
        }
        public string Wheel { get; set; }
        public void Accelerate(string str)
        {
            Console.WriteLine(str);
        }
        public void Brake(string str)
        {
            Console.WriteLine(str);
        }

    }
}

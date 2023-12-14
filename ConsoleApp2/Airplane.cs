using Oop;

namespace oop
{
    internal class Airplane: Vehicle
    {
        public Airplane(string Name,DateOnly DateOnly,string Wings) : base(Name, DateOnly)
        {
            this.Name = Name;
            this.DateOnly = DateOnly;
            this.Wings = Wings;
        }
        public string Wings { get; set; }
        public void Land(string str) 
        {
            Console.WriteLine(str);
        }
        public void TakeOff (string str) 
        {
            Console.WriteLine(str);
        }

    }
}

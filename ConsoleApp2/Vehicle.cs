namespace Oop
{
    internal class Vehicle
    {
        public Vehicle(string Name,DateOnly DateOnly)
        {
            this.Name = Name;   
            this.DateOnly = DateOnly;
        }
        public string Name { get; set; }
        public DateOnly DateOnly { get; set;}
        public void StartEngine(string str) 
        {
            Console.WriteLine(str);
        }
        public void StopEngine(string str) 
        {
            Console.WriteLine(str);
        }
        public void Drive(string str) 
        {
            
        }
    }
}

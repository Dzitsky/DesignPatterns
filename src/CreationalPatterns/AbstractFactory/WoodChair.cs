namespace AbstractFactory
{
    class WoodChair : Chair
    {
        public override void Seat() => Console.WriteLine("WoodChair:Seat");
    }
}
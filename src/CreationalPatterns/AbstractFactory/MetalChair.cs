namespace AbstractFactory
{
    class MetalChair : Chair 
    {
        public override void Seat() => Console.WriteLine("MetalChair:Seat");
    }
}
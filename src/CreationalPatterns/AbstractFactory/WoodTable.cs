namespace AbstractFactory
{
    class WoodTable : Table
    {
        public override void Eat() => Console.WriteLine("WoodTable:Eat");
    }
}

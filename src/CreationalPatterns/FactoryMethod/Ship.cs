namespace FactoryMethod
{
    class Ship : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Move by Ship");
        }
    }
}

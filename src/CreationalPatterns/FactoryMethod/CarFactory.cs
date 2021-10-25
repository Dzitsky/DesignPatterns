namespace FactoryMethod
{
    internal class CarFactory : TransportFactory
    {
        public override Transport Create()
        {
            return new Car();
        }
    }
}

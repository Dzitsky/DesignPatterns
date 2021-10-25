namespace FactoryMethod
{
    internal class ShipFactory : TransportFactory
    {
        public override Transport Create()
        {
            return new Ship();
        }

    }
}

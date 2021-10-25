namespace FactoryMethod
{
    class DeliveryService
    {
        public void Delivery(TransportFactory transportFactory)
        {
            Transport transport = transportFactory.Create();
            transport.Move();       
        }
    }
}
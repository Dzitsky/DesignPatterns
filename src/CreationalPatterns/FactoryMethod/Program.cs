using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportFactory ship = new ShipFactory();
            TransportFactory car = new CarFactory();

            DeliveryService deliveryService = new DeliveryService();
            deliveryService.Delivery(car);
            deliveryService.Delivery(ship);
        

            Console.ReadKey();
        }
    }
}
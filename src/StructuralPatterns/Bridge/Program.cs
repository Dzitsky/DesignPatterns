using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            Console.ReadKey();
        }
    }
}
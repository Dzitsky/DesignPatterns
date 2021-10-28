using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent tree = new ChrismasComponent();
            tree = new MusicDecorator(tree);
            tree = new LightDecorator(tree);
            
            Сelebrate(tree);

            Console.ReadKey();
        }

        static void Сelebrate(/*ChrismasComponent*/IComponent component)
        {
            //Console.WriteLine("Light off!");
            component.Execute(); 
            //Console.WriteLine("Light on!");
        }
    }
} 
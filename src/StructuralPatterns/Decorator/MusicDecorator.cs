namespace Decorator
{
    internal class MusicDecorator : BaseDecorator
    {
        public MusicDecorator(IComponent component) : base(component)
        {
        }
                public override void Execute()
        {
            Console.WriteLine("Music start!");

            //component.Execute();
            base.Execute();

            Console.WriteLine("Music stop!");
        }
    }
}
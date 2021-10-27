namespace Decorator
{
    class LightDecorator : BaseDecorator //IComponent
    {
        // private IComponent component;

        public LightDecorator(IComponent component) : base(component)
        {
            //this.component = component;
        }

        public override void Execute()
        {
            Console.WriteLine("Light off!");

            //component.Execute();
            base.Execute();

            Console.WriteLine("Light on!");
        }
    }
}
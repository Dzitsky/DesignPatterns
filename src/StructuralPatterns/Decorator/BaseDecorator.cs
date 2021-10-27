namespace Decorator
{
    abstract class BaseDecorator : IComponent
    {
        private IComponent component;

        public BaseDecorator(IComponent component) {
            this.component = component;
        }

        public virtual void Execute()
        { 
            component.Execute();
        }
    }
}
namespace Bridge.PatternStruct
{
    abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
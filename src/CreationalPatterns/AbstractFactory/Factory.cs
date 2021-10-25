namespace AbstractFactory
{
    abstract class Factory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
    }
}

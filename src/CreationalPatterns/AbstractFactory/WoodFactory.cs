namespace AbstractFactory
{
    class WoodFactory : Factory
    {
        public override Chair CreateChair() => new WoodChair();

        public override Table CreateTable() => new WoodTable();
    }
}

namespace AbstractFactory
{
    class MetalFactory : Factory
    {
        public override Chair CreateChair() => new MetalChair();

        public override Table CreateTable() => new MetalTable();
    }
}

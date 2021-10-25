namespace AbstractFactory
{
     class DinnerService
    {
        Table table;
        Chair chair;

        public DinnerService(Factory factory)
        {
            table = factory.CreateTable();
            chair = factory.CreateChair();
        }

        public void Dinner()
        {
            chair.Seat();
            table.Eat();
        }
    }
}
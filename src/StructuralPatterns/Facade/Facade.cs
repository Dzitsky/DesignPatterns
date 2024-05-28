namespace Facade
{
    public class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;

        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            //subsystemA.A2();
            subsystemB.B1();
            subsystemC.C1();
            //subsystemA.A2();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }
}
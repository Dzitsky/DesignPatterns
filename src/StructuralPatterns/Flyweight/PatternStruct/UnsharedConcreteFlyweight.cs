namespace Flyweight.PatternStruct
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        int allState;
        public override void Operation(int extrinsicState)
        {
            allState = extrinsicState;
        }
    }
}
namespace Prototype
{
    class Car : ICloneable
    {
        private int weight;
        private bool isTrailer;

        public Car() {
            weight = 1000;
            isTrailer = false;
        }

        public void AddTrailer()
        {
            if (isTrailer) return;
            isTrailer = true;
            weight += 500;
        }

        public object Clone()
        {
            Car newCar = new Car();
            newCar.weight = weight;
            newCar.isTrailer = isTrailer;
            return newCar;
        }

        public Car Copy()
        {
            Car newCar = new Car();
            newCar.weight = weight;
            newCar.isTrailer = isTrailer;
            return newCar;
        }

        public override string ToString()
        {
            return $"Car (weight:{weight} isTrailer:{isTrailer})";
        }
    }
}

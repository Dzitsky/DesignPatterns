using System;

namespace Prototype
{
    class Car : ICloneable
    {
        private int weight;
        private bool isTrailer;

        private Engine engine;

        public Car() {
            weight = 1000;
            isTrailer = false;

            engine = new Engine("v8");
        }

        public void AddTrailer()
        {
            if (isTrailer) return;
            isTrailer = true;
            weight += 500;
        }

        public object Clone()
        {
            //Car newCar = new Car();
            //newCar.weight = weight;
            //newCar.isTrailer = isTrailer;

            //newCar.engine = new Engine(engine.model);

            return this.MemberwiseClone();

            //return newCar;
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

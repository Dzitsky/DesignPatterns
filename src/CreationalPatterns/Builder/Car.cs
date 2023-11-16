using System;

namespace Builder
{
    class Car : ICloneable
    {
        private int weight;
        private bool isTrailer;

        public Car() {
            weight = 1000;
            isTrailer = false;
        }

        public Car(int weight)
        {
            this.weight = weight;
            isTrailer = false;
        }

        public Car(int weight, bool isTrailer)
        {
            this.weight = weight;
            this.isTrailer = isTrailer;
        }

        public Car SetWeight(int weight)
        {
            this.weight = weight;
            return this;
        }

        public Car AddTrailer()
        {
            if (isTrailer) return this;
            isTrailer = true;
            weight += 500;
            return this;
        }

        public Car Build()
        {
            return this;
        }

        //public void AddTrailer()
        //{
        //    if (isTrailer) return;
        //    isTrailer = true;
        //    weight += 500;
        //}



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

namespace Singleton
{
    public class Car
    {
        public void Move()
        {
            Logger.GetInstance().Debug("Logger : Car Move");
        }
    }
}
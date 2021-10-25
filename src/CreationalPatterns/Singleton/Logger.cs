namespace Singleton
{
    class Logger
    {
        static Logger instance  = null;

        private Logger()
        {
            Console.WriteLine("Logger : Created");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Debug(string message)
        {
            Console.WriteLine(message);
        }
    }
}
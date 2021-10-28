namespace Bridge
{
    class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("С помощью компилятора собираем исходный код в файл exe");
        }

        public void Execute()
        {
            Console.WriteLine("JIT компилирует программу бинарный код");
            Console.WriteLine("CLR выполняет скомпилированный бинарный код");
        }
    }
}

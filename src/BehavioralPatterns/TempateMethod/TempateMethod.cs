using System.IO;

namespace TempateMethod
{
    public class ZipExporter : MyExporter
    {
        public ZipExporter(string d) : base(d)
        {

        }

        protected override string PackFile(string filePath)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TelegramExporter : MyExporter
    {
        public TelegramExporter(string d) : base(d)
        {

        }

        protected override string PackFile(string filePath)
        {
            throw new System.NotImplementedException();
        }

        protected override void Send(string packedFile)
        {
            base.Send(packedFile);
        }
    }

    public abstract class MyExporter
    {
        private readonly string _data;

        public MyExporter(string data)
        {
            _data = data;
        }

        public void ExportData()
        {
            // создать файл
            var filePath = CreateFile();
            // записать в него данные
            WriteData(filePath);
            // упаковать файл
            var packedFile = PackFile(filePath);
            // отправить по почте
            Send(packedFile);
            // удалить файлы
            DeleteFiles(packedFile, filePath);
        }

        private void DeleteFiles(string packedFile, string filePath)
        {
            File.Delete(packedFile);
            File.Delete(filePath);
        }

        protected virtual void Send(string packedFile)
        { }

        protected abstract string PackFile(string filePath);

        private void WriteData(string filePath)
        {
            // TODO: _data -> filePath
        }

        private string CreateFile()
        {
            return "1.txt";
        }
    }
}
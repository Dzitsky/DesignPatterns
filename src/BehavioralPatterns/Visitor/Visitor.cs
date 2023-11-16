using System;
using System.Collections;
using System.Collections.Generic;

namespace Visitor
{
    internal class Visitor
    {
        public void Visit()
        {
            var storage = new Storage();
            var consoleWriteLineVisitor = new DoubleWritelineVisitor();
            foreach (Item item in storage)
            {
                item.Process(consoleWriteLineVisitor);
            }
        }
    }

    internal class StorageEnumerator : IEnumerator<Item>
    {
        private readonly Storage _storage;

        public StorageEnumerator(Storage storage)
        {
            _storage = storage;
        }

        private char _current = (char)('a' - 1);

        public Item Current
        {
            get
            {
                switch (_current)
                {
                    case 'a': return _storage.A;
                    case 'b': return _storage.B;
                    case 'c': return _storage.C;
                    case 'd': return _storage.D;
                    case 'e': return _storage.E;
                    default: return null;
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            var current = _current + 1;
            if (current > 'e')
            {
                return false;
            }
            _current = (char)current;
            return true;
        }

        public void Reset()
        {
            _current = (char)('a' - 1);
        }
    }

    internal class Storage : IEnumerable<Item>
    {
        public Item A { get; }
        public Item B { get; }
        public Item C { get; }
        public Item D { get; }
        public Item E { get; }

        public Storage()
        {
            A = new SimpleItem(1);
            B = new ComplexItem(2, 100);
            C = new SimpleItem(17);
            D = new SimpleItem(45);
            E = new ComplexItem(54, 200);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return new StorageEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal abstract class Item
    {
        public int Data { get; }

        public Item(int data)
        {
            Data = data;
        }

        public abstract void Process(IWritelineVisitor visitor);
    }

    class SimpleItem : Item
    {
       public SimpleItem(int data) : base(data)
       {
       }

       public override void Process(IWritelineVisitor visitor)
       {
           visitor.ProcessSimpleItem(this);
       }
    }

    class ComplexItem : Item
    {
       public int Data2 { get; }

       public ComplexItem(int data, int data2) : base(data)
       {
           Data2 = data2;
       }

       public override void Process(IWritelineVisitor visitor)
       {
           visitor.ProcessComplexItem(this);
       }
    }

    internal class ConsoleWritelineVisitor : IWritelineVisitor
    {
       public void ProcessSimpleItem(SimpleItem item)
       {
           Console.WriteLine(item.Data.ToString());
       }

       public void ProcessComplexItem(ComplexItem item)
       {
           Console.WriteLine(item.Data.ToString() + " " + item.Data.ToString());
       }
    }

    internal class DoubleWritelineVisitor : IWritelineVisitor
    {
       public void ProcessSimpleItem(SimpleItem item)
       {
           Console.WriteLine(item.Data.ToString());
           Console.WriteLine(item.Data.ToString());
       }

       public void ProcessComplexItem(ComplexItem item)
       {
           Console.WriteLine(item.Data.ToString() + " " + item.Data.ToString());
           Console.WriteLine(item.Data.ToString() + " " + item.Data.ToString());
       }
    }

    internal interface IWritelineVisitor
    {
       void ProcessComplexItem(ComplexItem item);

       void ProcessSimpleItem(SimpleItem item);
    }

    //class FileWritelineVisitor : IWritelineVisitor
    //{
    //    public void Process(SimpleItem item)
    //    {
    //        File.WriteLine(item.Data.ToString());
    //    }

    //    public void Process(ComplexItem item)
    //    {
    //        File.WriteLine(item.Data.ToString() + " " + item.Data.ToString());
    //    }
    //}

    //class SmsWritelineVisitor : IWritelineVisitor
    //{
    //    public void Process(SimpleItem item)
    //    {
    //        Sms.WriteLine(item.Data.ToString());
    //    }

    //    public void Process(ComplexItem item)
    //    {
    //        Sms.WriteLine(item.Data.ToString() + " " + item.Data.ToString());
    //    }
    //}
}
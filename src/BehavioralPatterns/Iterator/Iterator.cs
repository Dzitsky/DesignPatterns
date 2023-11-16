using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Iterator
    {
        public void Iterate()
        {
            // var list = new List<int>
            // {
            //     1, 2, 17, 45, 54
            // };

            // foreach (var i in list)
            // {
            //     Console.WriteLine(i);
            // }

            var storage = new Storage();
            foreach (Item item in storage.Iterate())
            {
                Console.WriteLine(item);
            }
        }
    }

    class Storage : IEnumerable<Item>
    {
        public Item A { get; }
        public Item B { get; }
        public Item C { get; }
        public Item D { get; }
        public Item E { get; }

        public Storage()
        {
            A = new Item(1);
            B = new Item(2);
            C = new Item(17);
            D = new Item(45);
            E = new Item(54);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return new StorageEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerable<Item> Iterate(){
            yield return A;
            yield return B;
            yield return C;
            yield return D;
            Console.WriteLine("почти закончилась коллекция");
            yield return E;
        }
    }

    class StorageEnumerator : IEnumerator<Item>
    {
        private Storage _storage;
        private char _current = (char)('a' - 1);

        public StorageEnumerator(Storage storage)
        {
            _storage = storage;
        }

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
            var current = (char)(_current + 1);
            if (current > 'e')
            {
                return false;
            }
            _current = current;
            return true;
        }

        public void Reset()
        {
            _current = (char)('a' - 1);
        }
    }

    class Item
    {
        public int Data { get; }

        public Item(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

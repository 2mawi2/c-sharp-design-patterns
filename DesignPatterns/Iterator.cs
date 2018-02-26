using System.Collections.Generic;

namespace DesignPatterns
{
    public class Iterator<T>
    {
        private readonly List<T> _list;

        public Iterator(List<T> list) => _list = list;

        private int _index = 0;

        public bool HasNext() => _index + 1 <= _list.Count;

        public T Next() => _list[_index++];
    }
}
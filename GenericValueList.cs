using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class GenericValueList<T> where T:struct
    {
        private List<T> _List;

        public GenericValueList()
        {
            _List = new List<T>();
        }

        public void Add(T value)
        {
            if (!typeof(T).IsValueType)
            {
                throw new ArgumentException("only value type is allowed");
            }
           _List.Add(value);
        }
        public T GetValue(int index)
        {
            if(index < 0 || index >= _List.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _List[index];
        }

        public List<T> GetDescendingOrderItem() {
            return new List<T>(_List).OrderByDescending(x => x).ToList(); 
        }
    }
}

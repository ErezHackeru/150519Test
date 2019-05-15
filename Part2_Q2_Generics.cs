using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test150519_Part2_Q2
{
    class MyGenericClass<T>
    {
        List<T> list = new List<T>();

        public MyGenericClass()
        {

        }

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            return false;
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            return false;
        }

        public T Peek(int index)
        {
            return list[index];
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (Equals(list[index], value))
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }        
    }
}

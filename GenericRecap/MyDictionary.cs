using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRecap
{
    public class MyDictionary<A, B>
    {
        A[] keys;
        B[] values;
        public MyDictionary()
        {
            keys = new A[0];
            values = new B[0];
        }
        public void Add(A key, B value)
        {
            A[] newKeys = new A[keys.Length + 1];
            B[] newValues = new B[values.Length + 1];
            Array.Copy(keys, 0, newKeys, 0, keys.Length);
            Array.Copy(values, 0, newValues,0, values.Length);
            newKeys[keys.Length] = key;
            newValues[values.Length] = value;
            keys = newKeys;
            values = newValues;
        }
        public void Delete(A key)
        {
            int i = 0;
            A[] newKeys = new A[keys.Length - 1];
            B[] newValues = new B[values.Length - 1];
            int j = 0;
            while (i < keys.Length)
            {
                if (keys[i].Equals(key))
                {
                    i++;
                    continue;
                }
                newKeys[j] = keys[i];
                newValues[j] = values[i];
                i++;
                j++;
            }
            keys = newKeys;
            values = newValues;
        }
        public void Update(A key, B newValue)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    values[i] = newValue;
                    break;
                }
            }
        }
        public B Find(A key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            return default(B);
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: " + keys[i] + ", Value: " + values[i]);
            }
        }
        public int Count
        {
            get
            {
                return keys.Length;
            }
        }
    }
}

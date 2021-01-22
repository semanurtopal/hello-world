using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;

            public MyDictionary()
            {
                _keys = new T1[0];
                _values = new T2[0];
            }
            public void Add(T1 key, T2 value)
            {
            T1[] _tempArrayKeys = _keys;
            T2[] _tempArrayValues = _values;

            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];

                for (int i = 0; i < _tempArrayKeys.Length; i++)
                {
                _keys[i] = _tempArrayKeys[i];
                _values[i] = _tempArrayValues[i];
                }


                _keys[_keys.Length - 1] = key;
                _values[_values.Length - 1] = value;

            }

        public T1[] Keys
        {
            get { return _keys; }
        }

        public T2[] Values
        {
            get { return _values; }
        }

    }
}

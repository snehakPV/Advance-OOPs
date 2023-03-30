using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDS
{
    public class KeyValue<TKey,TValue>
    {
       public TKey Key{get;set;}
       public TValue Value{get;set;} 
    }
    class CustomDictionary<TKey,TValue>:IEnumerable,IEnumerator
    {
        private int _count;
        private int _size;
        public int Count{get{return _count;}}
        public int Capacity{get{return _size;}}
        private KeyValue<TKey,TValue>[] _array;
        public TValue this[TKey key]
        {
            get
            {
             int position=LinearSearch(key,out TValue value1);
             return value1;
            }
            set
            {
             int position=LinearSearch(key,out TValue value1);
             if(position>-1)
             {
                _array[position].Value=value;
             }
            }
        }
        public CustomDictionary()
        {
            _size=4;
            _count=0;
            _array=new KeyValue<TKey,TValue>[_size];
        }
        public CustomDictionary(int size)
        {
            _size=size;
            _count=0;
            _array=new KeyValue<TKey, TValue>[_size];
        }
        public void Add(TKey key,TValue value)
        {
            if(_count==_size)
            {
                GrowSize();
            }
            int position=LinearSearch(key,out TValue value1);
            if(position==-1)
            {
                KeyValue<TKey,TValue> data=new KeyValue<TKey, TValue>();
                data.Key=key;
                data.Value=value;
                _array[_count]=data;
                _count++;
            }
        }
        public void GrowSize()
        {
            _size*=2;
            KeyValue<TKey,TValue>[] temp=new KeyValue<TKey, TValue>[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public int LinearSearch(TKey key,out TValue value)
        {
            int position=-1;
            value=default(TValue);
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {
                    position=i;
                    value=_array[i].Value;
                    break;
                }
            }
             return position;
        }
        int location;
        public IEnumerator GetEnumerator()
        {
            location=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(location<_count-1)
            {
                location++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            location=-1;
        }
        public object Current{get{return _array[location];}}
    }
}
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public class CustomQueue<Type>:IEnumerable,IEnumerator
    {
        private int _count;
        public int Count{get{return _count;}}
        private int _head;
        private int _tail;
        private Type []_array;
        private int _size;
        public CustomQueue()
        {
            _size=4;
            _count=0;
            _head=-1;
            _tail=-1;
            _array=new Type[_size];
        }
        public CustomQueue(int size)
        {
           _size=size;
           _count=0;
           _head=-1;
           _tail=-1;
           _array=new Type[_size];
        }
        public void Enqueue(Type data)
        {
            if(_count==0&&_head==-1)
            {
                _head++;//Increment head for 1st addition
            }
             _tail++;
             if(_tail==_size)
             {
                GrowSize();
             }

            _array[_tail]=data;
            _count++;
        }
        private void GrowSize()
        {
            _size*=2;
            Type [] temp=new Type[_size];
            int k=0;
            for(int i=_head;i<_tail;i++)
            {
                temp[k]=_array[i];
                k++;
            }
            _array=temp;
            _head=0;
            _tail=k;
            _count=k;
        }
        public Type Peek()
        {
            if(_head>-1)
            {
                return _array[_head];
            }
            else
            {
                return default(Type);
            }
        }
        public Type Dequeue()
        {
            if(_head>-1 &&_head<=_tail)
            {
               int position=_head;
               _head++;
               return _array[position];
            }
            else
            {
                return default(Type);
            }
        }
        int location;
        public IEnumerator GetEnumerator()
        {
            location=_head-1;
            return (IEnumerator) this;
        }
        public bool MoveNext()
        {
            if(location<_tail-1)
            {
                location++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            location=_head-1;
        }
        public object Current{get{return _array[location];}}
         
    }
}
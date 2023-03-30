using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackDS
{
    public class CustomStack<Type>
    {
        private int _count;
        public int Count { get {return _count;}}
        private int _top;
        private Type []_array;
        private int _size;
        public CustomStack()
        {
            _size=4;
            _count=0;
            _top=-1;
            _array=new Type[_size];
        }
        public CustomStack(int size)
        {
            _size=size;
            _count=0;
            _top=-1;
            _array=new Type[_size];
        }
        public void Push(Type data)
        {
            if(_count==_size)
            {
              GrowSize();
            }
            _array[_count]=data;
            _count++;
            _top++;
        }
        private void GrowSize()
        {
            _size*=2;
            Type [] temp=new Type[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];//Fill the existing data into temp
            }
            _array=temp;//assign temp address to _array
        }
        public Type Peek()
        {
            if(_top>-1)
            {
                return _array[_top];
            }
            else
            {
            return default(Type);
            }
        }
        public Type Pop()
        {
            if(_top>-1)
            {
                int position=_top;
                 _top--;
                _count--;
                return _array[position];
            }
            else
            {
             return default(Type);
            }
        }
    }
}
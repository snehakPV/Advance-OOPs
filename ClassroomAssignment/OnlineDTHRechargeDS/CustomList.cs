using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    public class CustomList<Type> : IEnumerable,IEnumerator
    {
       private int _count;
       private int _size;
       public int Count { get{return _count;}  }
       public int Size { get{return _size;} }
       private Type [] _array;

       public CustomList()
       {
        _count=0;
        _size=4;
        _array=new Type[_size];
       }
       public CustomList(int size)
       {
        _count=0;
        _size=size;
        _array=new Type[_size];
       }
        public void Add(Type data)
        {
            if(_count==_size)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _size*=2;
            Type [] temp=new Type[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type this[int index]
        {
            get {return _array[index];}
            set {_array[index]=value;}
        }
        public void AddRange(CustomList<Type> dataList)
        {
            _size=_count+dataList.Count+4;
            Type [] temp=new Type[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=_count;i<_count+dataList.Count;i++)
            {
                temp[i]=dataList[j];
                j++;
            }
            _array=temp;
            _count+=dataList.Count;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator) this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }
        public object Current{ get{return _array[position];}}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDS
{
    public class CustomArrayList : IEnumerable,IEnumerator
    {
        private int _count;
        private int _size;
        public int Count{get{return _count;}}
        public int Capacity{get{return _size};}
        private dynamic[] _array;
        public dynamic this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        public CustomArrayList()
        {
            _count=0;
            _size=4;
            _array=new dynamic[_size];
        }
        public CustomArrayList(int size)
        {
            _count=0;
            _size=size;
            _array=new dynamic[_size];
        }
        public void Add(dynamic data)
        {
            if(_count==_size)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        private void GrowSize()
        {
            _size*=2;
            dynamic[] temp=new dynamic[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public void AddRange(CustomArrayList dataList)
        {
            _size=_count+dataList.Count+4;
            dynamic[] temp=new dynamic[_size];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];

            }
            int k=0;
            for(int i=0;i<_count+dataList.Count;i++)
            {
                temp[i]=dataList[k];
                k++;
            }
            _array=temp;
            _count+=dataList.Count;
        }
        public void Insert(int position,dynamic data)
        {
            _size+=4;
            dynamic [] temp=new dynamic[_size];
            for(int i=0;i<_count;i++)
            {
                if(i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=data;
                }
                else
                {
                    temp[i]=_array[i-1];
                }
            }
            _array=temp;
            _count++;
        }
    }
}
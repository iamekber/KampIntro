using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;                                          //array oluştur items adında
        //constructor
        public MyList()                                     //her new de sıfırla
        {
            items = new T[0];
        }
        public void Add(T item)         
        {
            T[] tempArray = items;                          //her newde öncekileri kaybetmemek için geçici diziye ata
            items = new T[items.Length+1];                 //her newde eleman sayısını 1 arttır
            for (int i = 0; i < tempArray.Length; i++)    //borç bıraktığım eski elemanları geri ver
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] Items
        {
            get { return items; }
        }
        public int Length
        {
            get { return items.Length; }
        }
    }
}

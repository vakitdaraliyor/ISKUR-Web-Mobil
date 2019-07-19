using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOnHazırlık
{
    class MyListInt
    {
        // public tanımlasaydık herseyi obje olarak alacaktı.Şimdi int alır.
        private ArrayList liste = new ArrayList();

        public void Add(int sayi)
        {
            liste.Add(sayi);
        }

        public void RemoveAt(int index)
        {
            liste.RemoveAt(index);
        }

        public int GetItem(int index)
        {
            return Convert.ToInt32(liste[index]);
        }

        public void SetItem(int index, int value)
        {
            liste[index] = value;
        }

        public int Count()
        {
            return liste.Count;
        }
    }

    // Generic(Genelleme)
    class MyList<T>
    {
        // public tanımlasaydık herseyi obje olarak alacaktı.Şimdi int alır.
        private ArrayList liste = new ArrayList();

        public void Add(T sayi)
        {
            liste.Add(sayi);
        }

        public void RemoveAt(int index)
        {
            liste.RemoveAt(index);
        }

        public T GetItem(int index)
        {
            return (T)(liste[index]);
        }

        public void SetItem(int index, T value)
        {
            liste[index] = value;
        }

        public int Count()
        {
            return liste.Count;
        }
    }
}

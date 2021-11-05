using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    class Set
    {
        
        private int count;
        private int[] elements;
        // constructs
        public Set()
        {
            Console.WriteLine("Enter the size of the array");
            count = Convert.ToInt32(Console.ReadLine());
            elements = new int[count];
            //вызов метода для заполнения массива
            Fill();
        }

        public Set(int[] elements)
        {
            this.elements = new int[elements.Length];
            count = elements.Length;
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements[i] = elements[i];
            }
        }
        // methods
        private void Fill()
        {
            Console.WriteLine($"Enter values for the array size {count}: ");
            for (int i = 0; i < count; i++)
            {
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array is full!");
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (value == elements[i]) return i;
            }
            return -1;
        }

        public void ShowSet()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]}\t");
            }
            Console.WriteLine();
        }

        public void Add(int NewValue)
        {
            Array.Resize(ref elements, elements.Length + 1);
            elements[elements.Length - 1] = NewValue;
        }

        // indexer
        public int this[int index]
        {
            get { return elements[index]; }
        }

        // operator overloading
        //increment
        public static Set operator ++(Set set1) 
        {
            int[] elements = new int[set1.elements.Length];
            for (int i = 0; i < set1.elements.Length; i++)
            {
                elements[i] =  set1.elements[i]++;
            }

            return new Set(elements);
        }
        //unification
        public static Set operator +(Set set1, Set set2)
        {

            //for (int i = 0; i < set1.elements.Length; i++)
            //{
            //    for (int j = 0; j < set2.elements.Length; j++)
            //    {
            //        if (set1.elements[i] != set2.elements[j]) set1.Add(set2.elements[j]);
            //    }
            //}
            
            return (Set)set1.elements.Union(set2.elements);
        }
        // intersection
        public static Set operator *(Set set1, Set set2)
        {
            return (Set)set1.elements.Intersect(set2.elements);
        }
        // difference
        public static Set operator /(Set set1, Set set2)
        {
            return (Set)set1.elements.Except(set2.elements);
        }

        // comparison
        public static bool operator <(Set set1, Set set2)
        {
            return set1.count < set2.count;
        }

        public static bool operator >(Set set1, Set set2)
        {
            return set1.count > set2.count;
        }

    }
}

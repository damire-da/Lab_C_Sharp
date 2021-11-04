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
            count = Convert.ToInt32(Console.ReadLine());
            //вызов метода для заполнения массива
            Fill();
        }

        public Set(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements[i] = elements[i];
            }
        }
        // methods
        public void Fill()
        {
            Console.WriteLine($"enter the value for array with size {elements.Length}: ");
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
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]}\t");
                
            }
            
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
            for (int i = 0; i < set1.elements.Length; i++)
            {
                set1.elements[i]++;
            }
            return new Set { elements = set1.elements };
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
        //
        public static Set operator *(Set set1, Set set2)
        {
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    class Set
    {
        #region field
        private int count;
        private int[] elements;
        #endregion

        #region constructs
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
        #endregion

        #region methods
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
            // return Array.IndexOf(elements, value);
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
            count++;
            elements[elements.Length - 1] = NewValue;
        }
        #endregion

        #region indexer
        public int this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        #endregion

        #region operator overloading
        //increment
        public static Set operator ++(Set set1) 
        {
            int[] elements = new int[set1.count];
            for (int i = 0; i < set1.count; i++)
            {
                set1[i]++;
            }
            return set1;
        }
        //unification
        public static Set operator +(Set set1, Set set2)
        {
            /*Set set3 = new Set(set1.elements);
            
            int n = 0;
            int size = set1.count;
            
            for (int i = 0; i < set2.elements.Length; i++)
            {
                for (int j = 0; j < set1.elements.Length; j++)
                {
                    if (set1[j] != set2[i])
                    {
                        n = j;
                        continue;
                    }
                    else break;
                }
                if(n == set1.elements.Length - 1)
                {
                    Array.Resize(ref set3.elements, set3.elements.Length + 1);
                    set3.elements[set3.elements.Length - 1] = set2.elements[i]; 
                }
            }*/
            Set set3 = new Set(set1.elements);
            for (int i = 0; i < set2.count; i++)
            {
                bool b = true;
                for (int j = 0; j < set1.count; j++)
                    if (set1[j] == set2[i])
                    {
                        b = false;
                        break;
                    }
                if (b)
                    set3.Add(set2[i]);
            }

                return set3;
            }
        // intersection
        public static Set operator *(Set set1, Set set2)
        {
            
            int[] elem = new int[] { };
            Set set3 = new Set(elem);
            int l = 0;
            for (int i = 0; i < set2.elements.Length; i++)
            {
                int n = -1;
                for (int j = 0; j < set1.elements.Length; j++)
                {
                    if (set1.elements[j] == set2.elements[i])
                    {
                        n = j;
                        break;
                    }
                    
                }
                if (n != set1.elements.Length && n != -1)
                {
                    Array.Resize(ref set3.elements, set3.elements.Length + 1);
                    set3.elements[l] = set2.elements[i];
                    l++;
                }

            }
            return set3;
        }
        // difference
        public static Set operator /(Set set1, Set set2)
        {
            int[] elem = new int[] { };
            Set set3 = new Set(elem);
            
            for (int i = 0; i < set1.elements.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < set2.elements.Length; j++)
                {
                    if (set1.elements[i] == set2.elements[j]) break;
                    else
                    {
                        n = j;
                    }
                }
                if(n == set2.elements.Length - 1)
                {
                    Array.Resize(ref set3.elements, set3.elements.Length + 1);
                    set3.elements[set3.elements.Length - 1] = set1.elements[i];
                }
            }
            return set3;
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
        #endregion
    }
}

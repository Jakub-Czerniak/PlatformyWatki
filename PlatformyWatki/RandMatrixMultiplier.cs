using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformyWatki
{
    public class RandMatrixMultiplier
    {
        List<List<int>> m;
        List<List<int>> m2;
        List<List<int>> result;
        int size;

        public RandMatrixMultiplier(int _size)
        {
            size = _size;
            m = new List<List<int>>();
            m.Capacity = size;
            for (int i = 0; i < size; i++)
            {
                m.Add(new List<int>()); 
                for (int j = 0; j < size; j++)
                {
                    m[i].Add(j);
                }
            }

            m2 = new List<List<int>>();
            m2.Capacity = size;
            for (int i = 0; i < size; i++)
            {
                m2.Add(new List<int>());
                for (int j = 0; j < size; j++)
                {
                    m2[i].Add(j);
                }
            }
        }

        public void Odd()
        {
            
        }

        public void Even()
        {
            Console.WriteLine("Even");
        }

        public void Whole()
        { 
            result = new List<List<int>>();
             
            for (int i = 0; i<size; i++)
                for(int j =0; j<size; j++)
                {
                    //result.Add();
                }
        }

        public void Display()
        {
            Console.WriteLine("Matrix n.1:");
            foreach (List<int> sublist in m)
            {
                foreach (int i in sublist)
                    Console.Write(i + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Matrix n.2:");
            foreach (List<int> sublist in m2)
            {
                foreach (int i in sublist)
                    Console.Write(i + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Result Matrix:");
            foreach (List<int> sublist in result)
            {
                foreach (int i in sublist)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
        }
    }
}

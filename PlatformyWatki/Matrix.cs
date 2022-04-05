using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformyWatki
{
    public class Matrix
    {
        List<List<int>> m;

        public Matrix(int size)
        {
            m = new List<List<int>>();
            List<int> list = new List<int>(size);
            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                    list.Add(i);
                m.Add(list);

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
            Console.WriteLine("Whole");
        }
    }
}

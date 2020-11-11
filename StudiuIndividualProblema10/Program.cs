using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiuIndividualProblema10
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            float nrEl = 0;
            float suma = 0;

            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());

            float[] array = new float[n];


            Console.WriteLine("Elementele vectorului: ");
            for(int i= 0; i<array.Length; i++)
            {
                array[i] = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    suma = suma + array[i];
                    nrEl++;
                }
            }

            Console.WriteLine("Media numerelor pozitive: " + (suma / nrEl));

            Console.ReadLine();

        }
    }
}

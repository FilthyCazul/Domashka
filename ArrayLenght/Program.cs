using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину для 1-го и 2-го измерений массива: \nТак же это будет длинна одномерного массива");
            MassiveCycles massive_cycles = new MassiveCycles();
            massive_cycles.GetLine();
            Console.ReadKey();
        }
    }
    public class Numbers
    {
        public int lenght1 = Convert.ToInt32(Console.ReadLine());
        public int lenght2 = Convert.ToInt32(Console.ReadLine());
        public static void Checker(int lenght1, int lenght2)
        {
            
            if (lenght1 >= 15)
                throw new Exception(" Лееее куда  прешь еее");
            
            if (lenght2 >= 15)
                throw new Exception(" Лееее куда  прешь еее");
        }
    }
    public class MassiveCycles : Numbers
    {
        public void GetLine()
        {
            Numbers.Checker(lenght1, lenght2);
            Random rnd = new Random();

            int[] nums = new int[lenght1];
            int[,] nums2 = new int[lenght1, lenght2];

            for (int w = 0; w < lenght1; w++)
            {
                nums[w] = rnd.Next(20);
            }


            for (int g = 0; g < lenght1; g++ )
            {
                for (int x = 0; x < lenght2; x++)
                {
                    nums2[g, x] = rnd.Next(200);
                }
                
            }

            Console.WriteLine("Одномерный массив: ");
            foreach (int i in nums)
                Console.WriteLine("Cодержит: " + i);
            Console.WriteLine("Сорт одномерного массива (Возрастание): " + string.Join(" ", nums.OrderBy(i => i).Take(lenght1)));
            Console.WriteLine("Сорт одномерного массива (Убывание): " + string.Join(" ", nums.OrderByDescending(i => i).Take(lenght1)));

            foreach (int z in nums2)
                Console.WriteLine("Значения двухмерного массива:" + z, $"{z}");
        }
    }
}

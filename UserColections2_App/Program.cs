using System;
using System.Collections;

namespace UserColections2_App
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable arr2 = GetSquareOfOdds(arr1);
            

            foreach (var item in arr2)
            {
                Console.WriteLine(item); ;
            }
        }

        public static IEnumerable GetSquareOfOdds(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    yield return numbers[i] * numbers[i];
            }
        }
    }
}

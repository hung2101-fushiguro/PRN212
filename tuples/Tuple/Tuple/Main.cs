using System.Reflection.Metadata.Ecma335;

namespace Tuple
{
    internal class Program
    {
        static(int sum, int count) MyMethod(int[] values)
        {
            var r = (sum: 0, count: 0);
            for(int i = 0; i< values.Length; i++)
            {
                if(IsEvenNumber(values[i]))
                {
                    r.sum += values[i];
                    r.count++;
                }
            }
            return r;
            bool IsEvenNumber(int value)
            {
                return value % 2 == 0;
            }
        }
        
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (sum, count) = MyMethod(numbers);
            Console.WriteLine($"Sum: {sum}, Count:{count}");
            Console.ReadLine();
        }
    }
}

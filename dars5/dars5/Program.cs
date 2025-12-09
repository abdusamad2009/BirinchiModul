
namespace dars5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("list uzunligini kiriting : ");
            var n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("listni elementini kiriting : ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }
        }
    }
}

namespace Zadachadve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nai golemiq element v masiva
            Console.Write("dai broi na elementite:");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length-1; i++)
            {
                Console.Write($"num[{i}]");
                num[i] =int.Parse(Console.ReadLine());

            }
            for (int i = 0 ; i < num.Length-1;i++)
            {
                Console.WriteLine($"num[{i}]={num}");

            }
        }
    }
}

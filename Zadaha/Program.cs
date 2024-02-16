namespace Zadaha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[13];
            string[] names = new string[9] { "lubo", "Milen", "mihail", "radoslav", "svetlomir", "siana", "silviq", "stanislav", "tedo" };
               
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Otcenkata na {names[i]}");
                grades[i] = double.Parse(Console.ReadLine());
            }
            grades[0] = 6;
            names[0] = "lubo";
            Console.WriteLine($"{grades[0]}{names[0]}");

        }
    }
}

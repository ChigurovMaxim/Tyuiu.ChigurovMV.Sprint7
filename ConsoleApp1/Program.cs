namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, M];
            Random rnd = new Random();
            int RandomNegativeNum = 0 - rnd.Next(n1, n2+1);
            Console.WriteLine("Случайное отриц число - " + RandomNegativeNum);
            for (int i = 0; i < N; i++)
            {
                int rndPositionNegativeNum = rnd.Next(0, M);
                for (int j = 0; j < M; j++)
                {
                    if (j == rndPositionNegativeNum)
                    {
                        array[i, j] = RandomNegativeNum;
                    }
                    else
                    {
                        array[i, j] = rnd.Next(n1, n2 + 1);
                    }
                }
            }

            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < M; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

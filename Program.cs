namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Random rd = new Random();

            for(int i= 0; i<n; i++)
            {
                arr[i] = rd.Next(1, 8);
                Console.Write(arr[i] +  " ");
            }
            Console.WriteLine();

            for(int i = 1; i < n; i ++)
            {
                if (arr[i-1] == arr[i])
                {
                    Console.Write(arr[i] + " ");
                }
                
             
            }
        }
    }
}
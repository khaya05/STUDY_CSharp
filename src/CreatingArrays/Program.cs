namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] { 10, 20, 30 };
            arr[1] = new int[] { 30 };
            arr[2] = new int[] { 30, 5, 7, 2, 1, 3, 4, 5, 6, 7, 77, 8, 90 };
            arr[3] = new int[] { 11, 22, 33 };
            arr[4] = new int[] { 43, 54, 65, 76, 87 };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j< arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
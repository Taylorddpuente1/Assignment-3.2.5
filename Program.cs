namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = { 3, 4, 5, 2, 7, 8, 9,0 };
            int target = 7;
           int targetIndex = FindIndex(myNums, target);
            Console.WriteLine($"For target {myNums[targetIndex]} the index is:{targetIndex}. ");



           static int FindIndex(int[] Nums, int target)
            {
                for (int i = 0; i < Nums.Length; i++)
                {
                    if (Nums[i] == target)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}

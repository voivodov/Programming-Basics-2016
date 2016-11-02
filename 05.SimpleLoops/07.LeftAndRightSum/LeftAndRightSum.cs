using System; 

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long leftSum = 0, rightSum = 0;

            for(int i = 1; i<=count; i++)
            {
                long leftNumber = long.Parse(Console.ReadLine());
                leftSum+= leftNumber;
            }

            for (int k = 1; k <= count; k++)
            {
                long rightNumber = long.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }
            if (Math.Abs(leftSum - rightSum) == 0)
                Console.WriteLine("Yes, sum = "+ rightSum);
            else
                Console.WriteLine("No diff = " + Math.Abs(leftSum - rightSum));
        }
    }
}

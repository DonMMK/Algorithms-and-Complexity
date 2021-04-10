using System;

namespace Workshop2Q5
{
    class MainClass
    {

        
        public static void Main(string[] args)
        {
            int results = 0;
            Random randumNum = new Random();
            for( int i =1000; i < 20000; i = i+ 1000)
            {
                int[] testValues = new int[i];
                for(int j =i; j < i; j++)
                {
                    testValues[j] = randumNum.Next(0, 1000);
                }
                results = SortAnalysis(testValues);
                Console.WriteLine("Array size {0:d} - {1:d}", i, results);
            }

            Console.ReadKey();
        }


        public static int SortAnalysis(int[] val)
        {
            // intitialse variables
            int count = 0, v = 0, j = 0; //so that doesnt get executed inside the for loop to increase efficiency
            for (int i =0; i < val.Length; i++)
            {
                v = val[i];
                j = i - 1;
                while (j >= 0 && ++count>0 && val[j] > v) //Putting the counter inside the while loop
                {
                    val[j + 1] = val[j];
                    j--;
                }
                val[j + 1] = v;
            }
            return count;
        }


    }
}

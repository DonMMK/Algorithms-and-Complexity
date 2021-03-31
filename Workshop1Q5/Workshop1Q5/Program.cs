using System;

namespace Workshop1Q5
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 100, 200, 300, 400, 500, 600, 700, 800  };
            int results = Method2(numbers);

            Console.WriteLine("minimum distance is {0:d}", results);
        }

        static int Method2(int[] _Array)
        {
            int dmin = 10000;

            for (int i = 0; i < _Array.Length - 1; i++)
            {

                if (_Array[i] != _Array[i + 1] & Math.Abs(_Array[i] - _Array[i + 1]) < dmin)
                {
                    dmin = Math.Abs(_Array[i] - _Array[i + 1]);
                }


            }
            return dmin;
        }




        


        /*
        static void Main(string[] args)
        {
            int[] numbers = { 1, 10, 4, 6 };
            int results = findDistance(numbers);

            Console.WriteLine("minimum distance is{0:d}" , results);
        }


        static int findDistance(int[] A)
        {
            int dmin = 100000;
            for (int i=0; i<= A.Length - 2; i++)
            {
                for (int j= i + 1; j < A.Length- 1; j++ )
                {
                    int temp = Math.Abs(A[i] - A[j]);
                    if (temp < dmin)
                        dmin = temp;
                }
            }
            return dmin;
        }
        */
    }
}





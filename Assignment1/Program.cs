using System;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                int counter = n; 

                while (counter> 0) //counter keeps track of starting value per line
                {
                    while (n > 0)  //outputs decrementing values of n on the same line
                    {
                        Console.Write("{0}", n);
                        n--; 
                    }

                    Console.WriteLine();
                    counter--;
                    n = counter; 
                }

            }

            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
 
            
            try
            {
                int i = 0;
                int i2 = 1;

                for (int counter2 = 0; counter2 < n2; counter2++) //counter keeps track of the number of terms to print
                {

                    int total = i + i2;
                    Console.Write("{0}, ", total);
                    
                    i2++;
                    i = total;
                }



            }
            
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                //Write your code here .!!
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}

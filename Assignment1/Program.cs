using System;
using System.Globalization;

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

                string sep = "";

                for (int counter2 = 0; counter2 < n2; counter2++) //counter keeps track of the number of terms to print
                {

                    int total = i + i2;
                    Console.Write(sep + "{0}", total);
                    sep = ", ";

                    i2++;
                    i = total;
                }

                Console.WriteLine();

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
                DateTime s_time =  DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture); //converts s to datetime format 


                int earthSeconds = s_time.Second;
                int earthMinuteSecs = s_time.Minute * 60; 
                int earthHourSecs = s_time.Hour * 60 * 60; 

                int totalEarthSecs = earthSeconds + earthMinuteSecs + earthHourSecs;

                //int usfDaysSecs = totalEarthSecs / (36 * 60 * 45); //convert Earth seconds to USF days
                
                int usfHourSecs = totalEarthSecs / (60 * 45); //convert Earth seconds to USF hours

                double earthSecsLeft = totalEarthSecs - (usfHourSecs * 60 * 45); //Get remaining seconds after subtracting number of hours

                int usfMinuteSecs = (int) earthSecsLeft / 45; //convert Earth minutes to USF hours

                int usfSeconds = (int) earthSecsLeft - (usfMinuteSecs * 45); //Get remaining seconds after subtracting number of minutes


                Console.WriteLine(usfHourSecs + ":" + usfMinuteSecs + ":" + usfSeconds);
                


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
                for (int i = 1; i <= n3; i++) //loops through numbers 1 to n3
                {
                    if ((i % 3 == 0) & (i % 5 == 0))
                    {
                        Console.Write(" US");
                    }

                    else if ((i % 5 == 0) & (i % 7 == 0))
                    {
                        Console.Write(" SF");

                    }
                    else if ((i % 3 == 0) & (i % 7 == 0))
                    {
                        Console.Write(" UF");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write(" U");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write(" S");

                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write(" F");

                    }

                    else
                    {
                        Console.Write(" " + i);

                    }


                    if (i % k == 0) //creates new line after printing k numbers
                    {

                        Console.WriteLine(" ");
                    }
                }
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

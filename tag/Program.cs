using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your grade : ");

            int Grade = Convert.ToInt32(Console.ReadLine());


            switch (Grade >= 90 && Grade < 100)
            {
                case true:
                    Console.WriteLine("your grade is A");
                    break;


                case false:
                    switch (Grade >= 80 && Grade < 90)
                    {
                        case true:
                            Console.WriteLine("grade is B");
                            break;


                        case false:
                            switch (Grade >= 70 && Grade < 80)
                            {
                                case true:
                                    Console.WriteLine("your grade is C ");
                                    break;


                                case false:
                                    switch (Grade >= 60 && Grade < 70)
                                    {
                                        case true:
                                            Console.WriteLine("grade is D ");
                                            break;


                                        case false:
                                            switch (Grade >= 50 && Grade < 60)
                                            {
                                                case true:
                                                    Console.WriteLine("grade is E ");
                                                    break;


                                                case false:
                                                    Console.WriteLine("grade is F");
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;

            }
        }
    }
}

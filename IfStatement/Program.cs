using System;

namespace IfStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the number :");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else if (userNumber == 4 )
            {
                Console.WriteLine("Your number is four");
            }
                       
            else
            {
                Console.WriteLine("It is an all integer number");
            }
            Console.WriteLine("This is if statement learning program");
            Console.ReadLine();

            //Note : && Will check one by one conditions and go out once it found false condition in if statement
            //Note : & Will check all conditions in if statement compulsary

        }
    }
}

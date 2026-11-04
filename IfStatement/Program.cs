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
            else if (true)
            {
                Console.WriteLine("Your number is two");
            }

            else
            {

                Console.WriteLine("It is an integer number");
            }
            Console.ReadLine();

            //Note : && Will check one by one conditions and go out once it found false condition in if statement
            //Note : & Will check all conditions in if statement compulsary

        }
    }
}

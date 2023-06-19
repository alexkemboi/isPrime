using System;
class Program
{
    static bool isPrime(int number)
    { 
        if(number <=1)
        {
            Console.WriteLine("Number out of range");
            return false;
        }
        else
        {
            for (int i = 2; i <=Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

        }
        return true;            
    }
    static void Main(string[] args)
        {
            int userEntry = 0;
            Console.WriteLine("Enter a number");
            userEntry = Convert.ToInt32(Console.ReadLine());
            bool solution = isPrime(userEntry);
            if (solution)
            {

                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.Write("The number is not prime");
            }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose the number one of three categories: 1 = Sports, 2 = Cars, 3 = Rap.");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number == 1)
            {
                switch (number)
                {
                    case 1:

                        Console.WriteLine("What sport uses a Bat? 1 = Football or 2 = Baseball?");
                        break;
                }
                int question1 = Convert.ToInt32(Console.ReadLine());
                if (question1 == 2)
                {
                    Console.WriteLine("Your right its Baseball!");
                }
                else
                {
                    Console.WriteLine("Sorry you are incorrect, its Baseball.");
                }
            }
            else if (number == 2)
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("What car is faster? 1 = Ford Focus or 2 = Dodge Viper?");
                        break;
                }
                int answer2 = Convert.ToInt32(Console.ReadLine());
                if (answer2 == 2)
                {
                    Console.WriteLine("Your right its Dodge Viper!");
                }
                else
                {
                    Console.WriteLine("Sorry your incorrect, its Dodge Viper.");
                }
            }
            else if (number == 3)
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("What rapper is better? 1 = Biggie or 2 = 2Pac");
                        break;
                }
                int answer3 = Convert.ToInt32(Console.ReadLine());
                if (answer3 == 1)
                {
                    Console.WriteLine("Your right its Biggie, East Coast all the way!");
                }
                else
                {
                    Console.WriteLine("Sorry your incorrect, 2Pac is still good tho.");
                }
            }
            else 
            {
                Console.WriteLine("Sorry that's not one of the categories");
            }
            
            Console.ReadLine();
        }
    }
}

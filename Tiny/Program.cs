using System;
namespace first1

{

    class pro2

    {

        static void Main(string[] args)

        {

            Console.WriteLine("enter ur name :");

            string v = Console.ReadLine() ?? string.Empty;



            Console.WriteLine("enter ur age :");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age == int.MaxValue)
            {
                Console.WriteLine("Please enter a valid age:");
            }



            Console.WriteLine("ur name :" + v);

            Console.WriteLine("ur age :" + age);



            age = age + 1;

            Console.WriteLine("ur age on next year :" + age);



            Console.ReadLine();

        }

    }

}

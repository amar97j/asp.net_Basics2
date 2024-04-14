namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentHour = 13;
            if (currentHour >= 11 && currentHour <= 14)
            {
                Console.WriteLine("Time For Lunch!");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
            //Bouns 1
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine(count);
                count--;
            }

            //Challenge 4 (Arrays)
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thusrday", "Friday", "Saturday" };
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);

            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;    
            foreach (int number in numbers) {
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
    }


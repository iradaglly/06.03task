namespace task2_06._03_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            int increment = 1;
            int[] employees = new int[increment];
            Console.WriteLine("Enter employee:");
            employees[0] = Convert.ToInt32(Console.ReadLine());

            do { 
                Console.WriteLine("Do you want to continue?");

                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter again:");
                    Array.Resize(ref employees, increment + 1);
                    employees[increment] = Convert.ToInt32(Console.ReadLine());
                    increment++;
                }
                else
                {
                    if (answer == "no")
                    {
                        flag = false;
                        Console.WriteLine("....exiting");
                        break;
                    }
                }
            } while (flag);

            for (int i = 0; i < increment; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
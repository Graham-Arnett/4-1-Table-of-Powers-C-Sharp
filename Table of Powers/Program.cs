namespace Table_of_Powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");

            //for the loop
            String choice;
            do
            {
              

                Console.Write("Enter an integer: ");
                int entry = int.Parse(Console.ReadLine());

                Console.WriteLine("Number  Squared Cubed");
                Console.WriteLine("======\t======\t====");

                for (int i = 1; i <= entry; i++)
                {
                    //number just is i, squared is the number times itself, cubed is times itself times itself
                    int square = i * i;
                    int cube = i * i * i;

                    Console.WriteLine($"{i}\t{square}\t{cube}");//should this be inside or outside the loop?
                }

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y"); 
        }
    }
}

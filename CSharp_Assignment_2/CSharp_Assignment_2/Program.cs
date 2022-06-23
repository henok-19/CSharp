class Program
{

    public static void Main(string[] args)
    {
        int a;
        string s;
        do
        {
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("is  Even");
            }
            else
            {
                Console.WriteLine(" is Odd");
            }
            Console.WriteLine("Do you want to continue?(Yes/No)");
            s = Console.ReadLine();
            if (s == "no")
                Console.WriteLine("Bye!!!");

        } while (s == "yes");
    }
}

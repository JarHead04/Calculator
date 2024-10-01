// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Task1();
void Task1()
{
    Console.WriteLine("Please enter yourname :");
    string userName = Console.ReadLine();
    Console.WriteLine("please enter your age");
    int userAge = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello {userName}, you will be {(userAge + 5)} in 5 Years");
}

Task2();

void Task2()
{
    int userAge;
    Console.WriteLine("Please enter your age in years");
    userAge = Convert.ToInt32(Console.ReadLine());
    if (userAge < 13)
    {
        Console.WriteLine("you are a child");

    }
    else if (userAge >= 13 && userAge <= 19)
    {
        Console.WriteLine("you are a teenager ");
    }
    else
    {
        {
            Console.WriteLine("you are an adult");
        }
    }
    Task3();
    void Task3()
    {
        int intValue;
        Console.WriteLine("please enter an interger");
        intValue = Convert.ToInt32(Console.ReadLine());
        if (intValue > 0)
        {
            Console.WriteLine("This is a positive number");
        }
        else if (intValue < 0)
        {
            Console.WriteLine("This is a positive number");
        }
        else if (intValue == 0)
        {
            Console.WriteLine("This value equals 0");
        }
    }
    Task4();
    void Task4()
    {
        Console.WriteLine("plase enter a year");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 0)
        {
            Console.WriteLine($"{year} is not a valid year it must not be a negative number");
        }
        else
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year}is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }

        }

    }
    Task5();
    void Task5()
    {
        Console.WriteLine("Please enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number}is an even number");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number");
        }
    }
}


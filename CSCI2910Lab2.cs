
static void Main(string[] args) 
{

    Console.Write("Welcome!");

    // #1 print the output of adding two numbers from user input
    int num1, num2;

    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

 // #2 print a multiplication table from user input
    int num3, num4, num5;
        num5 = 0;

    Console.Write("Enter your number: ");
    num3 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter where the multiplication table should end: ");
    num4 = Convert.ToInt32(Console.ReadLine());

        while (num5 < num4)
        {
            Console.WriteLine($"{num3} * {num5} = {num3 * num5}");
            num5++;
        }

// #3 Table of bytes
    Console.WriteLine("-----------------------------------------------------------------------------------------------");
    Console.WriteLine("Type             Byte(s) of memory                    Min                                   Max");
    Console.WriteLine("-----------------------------------------------------------------------------------------------");
    Console.WriteLine("sbyte            1                                   -120                                   127");
    Console.WriteLine("byte             1                                      0                                   255");
    Console.WriteLine("short            2                                 -32768                                 32767");
    Console.WriteLine("ushort           2                                      0                                 65535");
    Console.WriteLine("int              4                            -2147483648                            2147483647");
    Console.WriteLine("uint             4                                      0                            4294967295");
    Console.WriteLine("long             8                   -9223372036854775808                   9223372036854775807");
    Console.WriteLine("ulong            8                                      0                  18446744073709551615");
    Console.WriteLine("float            4                         -3.4028235E+38                         3.4028235E+38");
    Console.WriteLine("double           8              -1.79769313486231570E+308              1.79769313486231570E+308");
    Console.WriteLine("decimal          16        -79228162514264337593543950335         79228162514264337593543950335");
    Console.WriteLine("-----------------------------------------------------------------------------------------------");

    Console.WriteLine("");
    Console.WriteLine(":)");
    Console.WriteLine("");

    // #4 Five-function calculator

    bool finished = false;
    int num6, num7, num8;
    String operation, answer;
    bool keptNumber = false;

    while(finished = false)
    {
        if (keptNumber = false)
        {
            Console.Write("Enter a number: ");
            num6 = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter your desired operation: ");
        operation = (Console.ReadLine());
        switch (operation)
        {
            case "+":
                Console.Write("Enter the number to be added: ");
                num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num6} + {num7} = {num6 + num7}");
                num6 = num6 + num7;
                break;
            case "-":
                Console.Write("Enter the number to be subtracted: ");
                num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num6} - {num7} = {num6 - num7}");
                num6 = num6 - num7;
                break;
            case "*":
                Console.Write("Enter the number to multiply by: ");
                num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num6} * {num7} = {num6 * num7}");
                num6 = num6 * num7;
                break;
            case "/":
                Console.Write("Enter the number to divide by: ");
                num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num6} / {num7} = {num6 / num7}");
                num6 = num6 / num7;
                break;
            case "%":
                Console.Write("Enter the number to for the modulus: ");
                num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num6} % {num7} = {num6 % num7}");
                num6 = num6 % num7;
                break;
            default:
                Console.Write("Invalid response.");
                break;
        }
        Console.Write("Would you like to keep going with this number??");
        answer = (Console.ReadLine());
        if(answer == "yes" || answer == "Yes")
        {
            keptNumber = true;
        }
        if(answer == "esc")
        {
            finished = true;
            continue;
        }
    }

    Console.Write("Goodbye!");
}
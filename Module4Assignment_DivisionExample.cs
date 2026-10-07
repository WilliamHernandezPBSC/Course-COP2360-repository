using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the first value?");
        string valueOne = Console.ReadLine();
        Console.WriteLine("What is the second value?");
        string valueTwo = Console.ReadLine();

        try
        {
            int divValueOne = Convert.ToInt32(valueOne);
            int divValueTwo = Convert.ToInt32(valueTwo);
            int resultValue = Divide(divValueOne , divValueTwo);
            Console.WriteLine("Division successful, with a value of " + resultValue + ".");
        }
        catch(FormatException)
        {
            Console.WriteLine("Division failed due to Format Exception.");
            Console.WriteLine("You typed a phrase in any of the values that wasn't an integer.");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Division failed due to division by Zero.");
            Console.WriteLine("The second number was zero, which is an impossible move to divide.");
        }
        
        catch(OverflowException)
        {
            Console.WriteLine("Division failed due to overflow exception.");
            Console.WriteLine("The number that you typed in any of the value had exceeded the value of the program.");
        }
        catch(OutOfMemoryException)
        {
            Console.WriteLine("Division failed due to out of memory exception.");
            Console.WriteLine("The computer simply ran out of memory while in the program.");
        }
        catch(Exception)
        {
            Console.WriteLine("Division failed due to unknown exception.");
            Console.WriteLine("This error can happen for a magnitude of reasons.");
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }

        
    }



}
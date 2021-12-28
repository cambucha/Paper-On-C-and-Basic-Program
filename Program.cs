using System;

namespace ProgramExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //boolean to allow user to quit loop
            bool userQuit = false;

            //loop while userQuit is false (user changes this)
            while(!userQuit)
            {
                    
                    //display options to user
                    Console.WriteLine("Basic Calculator! Select an option by typing the number of your selection: ");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");

                    //get user's selection and assign to string
                    string userInput = Console.ReadLine();

                    //checking if user's input is equal to  the characters 1,2,3,4.
                    //otherwise, the user is informed that they made an invalid selection
                    if(userInput.Equals("1"))                       
                    {
                        //call add method to add user's numbers
                        add();
                    }
                    else if (userInput.Equals("2"))
                    {
                        //call sub method to subtract user's numbers
                        sub();
                    }
                    else if (userInput.Equals("3"))
                    {
                        //call mult method to multiply user's numbers
                        mult();
                    }
                    else if (userInput.Equals("4"))
                    {
                        //call div method to divide user's numbers
                        div();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid selection.");
                    }

                    //checking if user would like to continue using the program
                    Console.WriteLine("Would you like to continue? (Type \'y\' to continue): ");
                    //reading user's desire to quit or keep computing!
                    string userCont = Console.ReadLine();

                    //changing boolean variable to true so loop ends if user does not choose 'y'
                    if(!userCont.Equals("y"))
                    {
                        userQuit = true;
                    }

            }//end while

        }//end main

        //method to add two variables chosen by user
        static void add()
        {
            //declaring variables to be used
            int x;
            int y;
            int result;

            //prompting user for numbers
            Console.WriteLine("Type your first addend: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your second addend: ");
            y = Convert.ToInt32(Console.ReadLine());

            //getting sum
            result = x + y;

            //displaying result
            Console.WriteLine(x + " + " + y + " = " + result);
        }

        //method to subtract two variables chosen by user
        static void sub()
        {
            //declaring variables to be used
            int x;
            int y;
            int result;

            //prompting user for numbers
            Console.WriteLine("Type your minuend: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your subtrahend: ");
            y = Convert.ToInt32(Console.ReadLine());

            //getting difference
            result = x - y;

            //displaying result
            Console.WriteLine(x + " - " + y + " = " + result);
        }

        //method to multiply two variables chosen by user
        static void mult()
        {
            //declaring variables to be used
            int x;
            int y;
            int result;

            //prompting user for numbers
            Console.WriteLine("Type your multiplicand: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your multiplier: ");
            y = Convert.ToInt32(Console.ReadLine());

            //getting product
            result = x * y;

            //displaying result
            Console.WriteLine(x + " * " + y + " = " + result);
        }

        //method to divide two variables chosen by user
        static void div()
        {
            //declaring variables to be used
            int x;
            int y;
            int result;

            //prompting user for numbers
            Console.WriteLine("Type your dividend: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your divisor: ");
            y = Convert.ToInt32(Console.ReadLine());

            //getting quotient
            result = x / y;

            //displaying result
            Console.WriteLine(x + " / " + y + " = " + result);
        }

    }//end class
}

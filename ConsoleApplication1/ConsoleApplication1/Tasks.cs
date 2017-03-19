namespace Tasks
{
    using System;
    using System.Text.RegularExpressions;
    using static System.Console;


    class Program
    {
        public static int sum(int n)
        {
            return (n * (n + 1)) / 2;
        }
        static void Main(string[] args)
        {
            Action act = () => WriteLine("You've entered invalid value. Try again");
            while (true)
            {
                WriteLine("\r\nEnter task number (from 1 to 7)(Task №2 is optional from task 1):");
                var userInput = ReadLine();
                int number;
                if (int.TryParse(userInput, out number))
                    switch (number)
                    {
                        case 1:
                            string[] fruits = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
                            foreach (string element in fruits)
                            {
                                if (!element.Contains("ap"))
                                    WriteLine(element);
                            }
                            break;
                        case 2:
                            string[] fruits2 = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };
                            var regex = new Regex("ap", RegexOptions.IgnoreCase);
                            foreach (string element in fruits2)
                            {
                                if (!regex.IsMatch(element))
                                    WriteLine(element);
                            }
                            break;
                        case 3:
                            WriteLine("Enter natural  number:");
                            var userInput2 = ReadLine();
                            int number2;
                            var n = int.TryParse(userInput2, out number2);
                            var output = sum(number2);
                            WriteLine(output);
                            break;
                        case 4:
                            while (true)
                            {
                                WriteLine("Enter natural  number:");
                                var userInput3 = ReadLine();
                                int number3;
                                if (int.TryParse(userInput3, out number3))
                                {
                                    var n2 = int.TryParse(userInput3, out number3);
                                    var num2 = 0;
                                    var summa = 0;
                                    while (number3 > 0)
                                    {
                                        num2 = number3 % 10;
                                        Write(num2 + " ");
                                        number3 /= 10;
                                        summa += num2;
                                    }
                                    WriteLine("Sum is " + summa);
                                    break;
                                }
                                else
                                    act();
                                WriteLine("Press any key to continue (exit - 'q')");
                                if (ReadKey().KeyChar.Equals('q'))
                                    break;
                            }
                            break;
                        case 5:
                            while (true)
                            {
                                WriteLine("What is the color of Banana?  \r\na.Red  \r\nb.Green \r\nc.Yellow \r\nd.Blue \r\ne.Purple");
                                var s = ReadLine();
                                if (s == "c")
                                    WriteLine("\r\nThis is correct answer.Press any key to continue (exit - 'q')");
                                else
                                    WriteLine("\r\nThis  incorrect answer.Press any key to continue (exit - 'q')");
                                if (ReadKey().KeyChar.Equals('q'))
                                    break;
                            }
                            break;
                        case 6:
                            WriteLine("Enter password: ");
                            while (ReadLine() != "root")
                            {
                                WriteLine("You've entered wrong password. Try again");
                            }
                            WriteLine("Password is correct");

                            break;
                        case 7:

                            for (int g = 35; g <= 87; g++)
                            {
                                WriteLine(g);
                                if (g == 71)
                                    break;
                            }
                            break;
                    }
                else
                    act();
                WriteLine("Press any key to continue (exit - 'q')");
                if (ReadKey().KeyChar.Equals('q'))
                    break;
            }
        }
    }
}




//Create Console project or projects in which please implement the tasks below:
//1)	You have string array {"apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" }. Please bring the value which are not contains “ap” to the console.

//Optional: How to get the same result as for string array {"apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" }  for array { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" } with the same conditions as for previous task?

//2)	Write a program, which can find a sum of 1 + 2 + 3 + ... + n, where n number entered from the keyboard by the user.
//3)  Write a program to display n terms of natural number and their sum.
//4)	Write program to prompt the user to choose the correct answer from a list.The user can choose to continue answering the question or stop answering it.
//What is the color of Banana?
//a.Red
//b.	Green
//c.	Yellow
//d.	Blue
//e.	Purple

//Optional: write 2 versions of realizations (implementations).
//5)	Write a program that will "ask" the correct password, as long as it is entered.The correct password will be the «root».
//6)	You have the natural numbers from 35 to 87. Write a program that will output all the values in order -   stop outputting when it reaches to 71.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BCS-426: Lab 3, by Alexander Harmaty\n");
            
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("" +
                    "____________________________________________\n" +
                    "MENU\n" +
                    "----\n" +
                    "1) Integer to Roman Numeral String Converter\n" +
                        "\t(Implementing an Extension Method)\n" +
                    "2) Sales Calculator\n" +
                        "\t(Abstract Classes and Interfaces\n" +
                    "3) End Program!\n\n");

                Console.WriteLine("Please type a number and hit enter to select your choice...");

                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("User has selected option 1!\n");
                        Console.WriteLine("To use the program, enter any number to convert to Roman Numerals\n");
                        
                        int i = 99;
                        string s = i.toRoman();
                        Console.WriteLine("For example... " + i + " converts to " + s);
                        
                        Console.WriteLine("Please type a number and press enter to convert...");
                        int num = int.Parse(Console.ReadLine());

                        Console.WriteLine("Arabic numeral: " + num);
                        Console.WriteLine("Roman numeral : " + num.toRoman());
                        break;

                    case 2:
                        Console.WriteLine("User has selected option 2!\n");
                        Console.WriteLine("" +
                            "The user will be prompted with a list of items to buy, and how many of each they would like to use.\n" +
                            "To use the program, enter how many of each item you would like to buy to see your total.\n");

                        Book book1 = new Book(50.99m, "ISBN 978-1492051138", 
                            "C# 8.0 in a Nutshell", "Jack Smith");
                        Book book2 = new Book(2.99m, "ISBN 100-1492051000", 
                            "C# Advanced Features and Programming Techniques", "Jill Smith");
                        Software sw1 = new Software(69.99m, "Version 16.0.10827",
                            "Microsoft 365 Personal");

                        Console.WriteLine(book1.ToString());
                        Console.WriteLine("How many copies would you like to purchase?\n" +
                            "Please type a number and press enter...");
                        int choice1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(book2.ToString());
                        Console.WriteLine("How many copies would you like to purchase?\n" +
                            "Please type a number and press enter...");
                        int choice2 = int.Parse(Console.ReadLine());
                        
                        decimal subtotal1 = book1.sell(choice1) + book2.sell(choice2);
                        Console.WriteLine("Your subtotal for your books is $" + subtotal1 + "\n");

                        Console.WriteLine(sw1.ToString());
                        Console.WriteLine("How many copies would you like to purchase?\n" +
                            "Please type a number and press enter...");
                        int choice3 = int.Parse(Console.ReadLine());

                        decimal subtotal2 = sw1.sell(choice3);
                        Console.WriteLine("Your subtotal for your software is $" + subtotal2 + "\n");

                        decimal total = subtotal1 + subtotal2;
                        Console.WriteLine("Your total for the order is $" + total);

                        break;

                    case 3:
                        Console.WriteLine("User has selected option 3!\n");
                        Console.WriteLine("ENDING PROGRAM!!!");
                        menu = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

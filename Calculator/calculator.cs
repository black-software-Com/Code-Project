/// How To Make Calculator With C#
/// Black-Software Code Tricks
//

using System;
namespace MyApp {
    class Calculator {
        public static void Main(string[] args) {
            string choose;
            bool numbers = false;
            int number1,number2,number3,javab = 0;
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t----[ Calculator ]----\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{1}.+");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{2}.-");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{3}.*");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{4}./");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{99}.Exit");
            while (true) {
                Console.Write("\n\t\t\t\t\t\t\t\t\t\tChoose/> ");
                choose = Console.ReadLine();
                Console.Write("\n");
                if (choose == "1") {
                    if (numbers == true) {
                        Console.Write("\nEnter Number Three: ");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        javab = (javab + number3);
                        Console.WriteLine($"Javab: {javab}");

                    } else {
                        Console.Write("\nEnter Number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Second Number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        javab = (number1 + number2);
                        Console.WriteLine($"Javab: {javab}");
                        numbers = true;
                    }
                }
                else if (choose == "2") {
                    if (numbers == true) {
                        Console.Write("\nEnter Number Three: ");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        javab = (javab - number3);
                        Console.WriteLine($"Javab: {javab}");

                    } else {
                        Console.Write("\nEnter Number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Second Number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        javab = (number1 - number2);
                        Console.WriteLine($"Javab: {javab}");
                        numbers = true;
                    }
                }
                else if (choose == "3") {
                    if (numbers == true) {
                        Console.Write("\nEnter Number Three: ");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        javab = (javab * number3);
                        Console.WriteLine($"Javab: {javab}");

                    } else {
                        Console.Write("\nEnter Number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Second Number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        javab = (number1 * number2);
                        Console.WriteLine($"Javab: {javab}");
                        numbers = true;
                    }
                }
                else if (choose == "4") {
                    if (numbers == true) {
                        Console.Write("\nEnter Number Three: ");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        javab = (javab / number3);
                        Console.WriteLine($"Javab: {javab}");

                    } else {
                        Console.Write("\nEnter Number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Second Number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        javab = (number1 / number2);
                        Console.WriteLine($"Javab: {javab}");
                        numbers = true;
                    }
                }
    
                else if (choose == "99") {
                    Console.WriteLine("\nExiting...");
                    Console.Write("\npress Any Key To Continue...");
                    Console.ReadKey();
                    break;

                } else {
                    Console.WriteLine("\nPlease, Choose Operator!");
                    Console.Write("\npress Eny Key To Continue...");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}

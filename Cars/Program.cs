using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] GroupOfCars = new Car[10];

            while (true)
            {
                Console.WriteLine("Enter 'a' to add a new car");
                Console.WriteLine("Enter 'd' to delete a car");
                Console.WriteLine("Enter 'p' to print details");
                Console.WriteLine("Enter 'g' to add gas to the car");
                Console.WriteLine("Enter 'm' to add miles to a car");
                Console.WriteLine("Enter 'q' to quit");
                Console.WriteLine();
                String inputText = Console.ReadLine();
                Console.WriteLine();

                switch (inputText)
                {
                    case "A":
                    case "a":
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Which Car do you want to delete?");
                        int carToDelete = Convert.ToInt32(Console.ReadLine());
                        if (GroupOfCars[carToDelete] == null)
                        {
                            Console.WriteLine("Invalid Command");
                            break;
                        }
                        else
                        {
                            GroupOfCars[carToDelete] = null;
                        }
                        break;
                    case "P":
                    case "p":
                        for (int i = 0; i <= GroupOfCars.Length; i++)
                        {
                            if (GroupOfCars[i] != null)
                            {
                                GroupOfCars[i].Print();
                            }
                        }
                        break;
                    case "G":
                    case "g":
                        Console.WriteLine("Which car do you want to add gas to?");
                        int thisCar = Convert.ToInt32(Console.ReadLine());
                        Car gasUpCar = GroupOfCars[thisCar];
                        if (gasUpCar == null)
                        {
                            Console.WriteLine("That car does not exist.");
                        }
                        Console.WriteLine("How much gas do you want to add?");
                        float howMuchGas = (float)Convert.ToDouble(Console.ReadLine());
                        gasUpCar.AddGas(howMuchGas);
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("Which car do you want to add miles to?");
                        int whichCar = Convert.ToInt32(Console.ReadLine());
                        Car specificCar = GroupOfCars[whichCar];
                        if (specificCar == null)
                        {
                            Console.WriteLine("Car does not exist.");
                            break;
                        }
                        Console.WriteLine("How many miles do you want to add to the car?");
                        float howManyMIles = (float)Convert.ToDouble(Console.ReadLine());
                        if (!specificCar.HasEnoughGas(howManyMIles))
                        {
                            Console.WriteLine("Not enough gas.");
                            break;
                        }
                        specificCar.AddMiles(howManyMIles);
                        break;
                    case "Q": 
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
                // this exits the program
                if (inputText == "q" || inputText == "Q")
                {
                    break;
                } 
            }
        }
    }
}

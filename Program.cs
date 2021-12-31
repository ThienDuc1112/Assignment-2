using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
             
            Console.WriteLine("\t\t\t_______________________Menu________________________________");
            Console.WriteLine("\t\t\t| Choice 1: Setup the rooms in the hotel                   |");
            Console.WriteLine("\t\t\t| Choice 2: Watch the room in the hotel                    |");
            Console.WriteLine("\t\t\t| Choice 3: Book a room in the hotel                       |");
            Console.WriteLine("\t\t\t| Choice 4: Calculate the bill for customers               |");
            Console.WriteLine("\t\t\t| Choice 5: Exit the program                               |");
            Console.WriteLine("\t\t\t|__________________________________________________________|");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SetUp();                       
                        break;
                    case 2:
                        Processor.PrintRooms();
                        break;
                    case 3:
                        Processor.Booking();
                        break;
                    case 4:
                        Processor.CalculatingBill();
                        break;
                    case 5:
                        Console.WriteLine("Exit the program successfully!!!");
                        break;
                    default:
                        Console.WriteLine("Wrong input, please enter from 1 to 5");
                        break;
                }
            } while (choice != 5);
            Console.ReadKey();
        }
             static void SetUp()
            {
                int password, choice;
                do
                {
                    Console.WriteLine("Please enter password");
                    password = int.Parse(Console.ReadLine());
                    if (password == 123456)
                    {
                        Console.WriteLine("Login successfull");
                    }
                    else
                    {
                        Console.WriteLine("Wrong password, please input again");
                    }
                } while (password != 123456);
            do
            {
                Console.WriteLine("\t\t\t_________________________SetUp____________________________");
                Console.WriteLine("\t\t\t| Choice 1: Creating rooms in the hotel                   |");
                Console.WriteLine("\t\t\t| Choice 2: Creating an extra room                        |");
                Console.WriteLine("\t\t\t| Choice 3: Update information for the hotel              |");
                Console.WriteLine("\t\t\t| Choice 4: Delate a room in the hotel                    |");
                Console.WriteLine("\t\t\t| Choice 5: View rooms in the hotel                       |");
                Console.WriteLine("\t\t\t| Choice 6: Exit the setup mode                           |");
                Console.WriteLine("\t\t\t|_________________________________________________________|");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InputRooms();
                        break;
                    case 2:
                        CreateARoom();
                        break;
                    case 3:
                        Processor.Update();
                        break;
                    case 4:
                        Processor.Delete();
                        break;
                    case 5:
                        Processor.PrintRooms();
                        break;
                    case 6:
                        Console.WriteLine("Exit the mode setup successfully!!!");
                        break;
                    default:
                        Console.WriteLine("Wrong input, please enter from 1 to 6");
                        break;
                }
            } while (choice != 6);
        }
        static void InputRooms()
        {
          
            List<CustomerInRoom> customers = new List<CustomerInRoom>();
            Console.WriteLine("Enter number of room in the hotel: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i<number; i++)
            {            
                CustomerInRoom customer = new CustomerInRoom();                                
                Console.WriteLine($"Enter the name of the room {i + 1}:");
                int nameRoom = int.Parse(Console.ReadLine());
                customer.NameRoom = nameRoom;                                 
                Console.WriteLine("Enter type of room: ");
                string typeRoom = Console.ReadLine();
                customer.TypeRoom = typeRoom;
                Console.WriteLine("Enter price of the room: ");
                int price = int.Parse(Console.ReadLine());
                customer.PriceRoom = price;
                customer.NullInformation();
                customers.Add(customer);
               
            }
            Processor.Customers = customers;
            Processor.NumberRoom = number;
         
        }
        static void CreateARoom()
        {
            CustomerInRoom customer2 = new CustomerInRoom();
            Console.WriteLine("Enter the name of the room:");
            int nameRoom = int.Parse(Console.ReadLine());
            customer2.NameRoom = nameRoom;
            Console.WriteLine("Enter type of room: ");
            string typeRoom = Console.ReadLine();
            customer2.TypeRoom = typeRoom;
            Console.WriteLine("Enter price of the room: ");
            int price = int.Parse(Console.ReadLine());
            customer2.PriceRoom = price;
            customer2.NullInformation();
            Processor.Customers.Add(customer2);
            Processor.NumberRoom++;
        }
       
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    public class Room
    {
        public int NameRoom { get; set; }
        public string TypeRoom { get; set; }
        public int PriceRoom { get; set; }
        public string StatusRoom { get; set; }
        public Room()
        {

        }     

        public void InputRoom()
        {
            Console.WriteLine("Enter the name of the room:");
            NameRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter type of room: ");
            TypeRoom = Console.ReadLine();
            Console.WriteLine("Enter price of the room: ");
            PriceRoom = int.Parse(Console.ReadLine());
        }
      
        public void DisplayRoom()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("---------------------Information Room---------------------------------");
            Console.WriteLine($"Name room: {NameRoom}--Type room: {TypeRoom}--Price: {PriceRoom}$--Status: {StatusRoom}");
        }

    }
    public class CustomerInRoom : Room
    {

        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public int IDNumber { get; set; }
       
       
        public CustomerInRoom()
        {

        }
        public void NullInformation()
        {
            FullName = " ";
            PhoneNumber = 0;
            IDNumber = 0;
            StatusRoom = "UnBooked";
        }
        public void InputCustomer()
        {
            Console.WriteLine("Enter full name of a customer: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Enter phone number of a customer: ");
            PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ID number of customer: ");
            IDNumber = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("---------------------Information Customer--------------------------");
            Console.WriteLine($"Full name of customer: {FullName}");
            Console.WriteLine($"Phone number of customer: {PhoneNumber}");
            Console.WriteLine($"ID number of customer: {IDNumber}");
            Console.WriteLine("______________________________________________________________________");
        }


    }
    public class Processor
    {
        public static List<Room> Rooms { get; set; }
        public static List<CustomerInRoom> Customers { get; set; }
        public static int NumberRoom { get; set; }

        public static void PrintRooms()
        {
            foreach (CustomerInRoom customer in Customers)
            {
                customer.DisplayRoom();
                customer.Display();
            }
        }
        public static void Delete()
        {
            Console.WriteLine("Do you really want to delete the room");
            Console.WriteLine("Please enter yes or no ");
            string option = Console.ReadLine();
            if (option == "yes")
            {
                Console.WriteLine("Enter the name room need to delete: ");
                int nameRoom = int.Parse(Console.ReadLine());
                for (int i = 0; i < NumberRoom; i++)
                {
                    if (Customers[i].NameRoom.Equals(nameRoom))
                    {
                        Customers.RemoveAll(x => x.NameRoom == nameRoom);
                    }
                }
                NumberRoom--;
            }
            if (option == "no")
            {
                Console.WriteLine("You entered no, the hotel hasn't any change");
            }
        }

        public static void Update()
        {
            int option;
            Console.WriteLine("Enter name of the room need to update:");
            int nameRoom = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberRoom; i++)
            {
                if (Customers[i].NameRoom.Equals(nameRoom))
                {
                    do
                    {
                        Console.WriteLine("Enter 1 to update information of the room");
                        Console.WriteLine("Enter 2 to update information of the customer");
                        Console.WriteLine("Enter 3 to exit");
                        option = int.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Customers[i].InputRoom();
                        }
                        if (option == 2)
                        {
                            Customers[i].InputCustomer();
                        }
                        if(option != 1 && option != 2 && option != 3)
                        {
                            Console.WriteLine("Please input from 1 to 3");
                        }
                    } while (option != 3);
                }
            }
        }
        public static void Booking()
        {
            int nameRoom = 0;
            Console.WriteLine("Choose a room in the hotel: ");
            nameRoom = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberRoom; i++)
            {
                if (Customers[i].NameRoom.Equals(nameRoom))
                {
                    if (Customers[i].StatusRoom == "UnBooked")
                    {                     
                                Customers[i].InputCustomer();
                                Customers[i].StatusRoom = "Booked";
                                break;
                    }                                         
                    else
                    {
                        Console.WriteLine("Room is booked, please book other room");
                    }
                }
            }
        }
        public static void CalculatingBill()
        {
            int num;
            int bill = 0;
            Console.WriteLine("Enter the number of rooms that are rented: ");
            num = int.Parse(Console.ReadLine());
            Checking(num);
            for (int j = 0; j < num; j++)
            {             
                Console.WriteLine("Choose a room in the hotel: ");
                int nameRoom = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of days rented: ");
                int day = int.Parse(Console.ReadLine());
                for (int i = 0; i < NumberRoom; i++)
                {
                    if (Customers[i].NameRoom.Equals(nameRoom))
                    {
                        bill = Customers[i].PriceRoom * day + bill;
                        Customers[i].NullInformation();
                    }
                }

            }
            Console.WriteLine($"The total money must pay is: { bill}");
        }

        static void Checking(int num)
        {
            while(num > NumberRoom)
            {
                Console.WriteLine("Wrong input, import again!!");
                Console.WriteLine("Enter the number of rooms that are rented: ");
                num = int.Parse(Console.ReadLine());
               
            } 
            
            
        }
       
    }
}

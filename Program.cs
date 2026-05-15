using System.Data.Common;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace TemplateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of an Output
            Console.WriteLine("Hello, World!");
            //Example of an Input - waits for enter to be pressed
            Console.ReadLine();

            //Data Types - Primatie
            string myString = "Blah blah blah";
            int myInt = 12;
            bool myBool = false;
            char myChar = 'B';
            float myFloat = 2345.1234f;
            double myDouble = 390345.33444;

            //Data Types - Date Time
            DateTime myDateTime = new DateTime(2026, 05, 15);
            DateTime myDateTime_2 = new DateTime(2026, 05, 15, 9, 41, 0);
            DateTime now = DateTime.Now;

            DateOnly myDate = new DateOnly(2026, 05, 15);
            TimeOnly myTime = new TimeOnly(9, 43);
            TimeOnly myTime = new TimeOnly(9, 43, 35);

            Console.WriteLine(myDateTime.ToString("dd/MM/yyyy")); //15/05/2026
            Console.WriteLine(myDate.ToString("dd/MM/yyyy"));

            //Data Types - Records
            TCar myCar = new();
            myCar.Reg_plate = "VK134KE";
            myCar.make = "Fiat";

            TCar myCar2 = new TCar()
            {
                Reg_plate = "VK133ME",
                make = "Mercedes",
                model = "M",
                price = 10000.33,
                Engine_size = 3.0,
                petrol = false
            };

            //Data Types - Arrays

        }

        public static record TCar
        {
            public string Reg_plate;
            public string make;
            public string model;
            public float price;
            public float Engine_size;
            public bool petrol;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OODExam_JonathanODonnell_S00180206;

namespace PhoneDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();
            //cant remember the way to get it on the exam sheet kept getting an error on  phone after new 
            using (db)
            {

                Phone p1 = new Phone() { Name="Samsung S20",Price= 500, OperatingSystem="Android",
                    OS_Image="/Images/android.png",Phone_Image= "/Images/s20.png" };
                Phone p2 = new Phone() { Name="iPhone 11",Price= 600, OperatingSystem="IOS",
                    OS_Image= "/Images/apple.png", Phone_Image="/Images/iphone11.png" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added to phone Database");

                db.SaveChanges();
                Console.WriteLine("Saved to Database");
                
                
            }
        }
    }
}

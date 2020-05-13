using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OODExam_JonathanODonnell_S00180206
{
    public class Phone
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

    }

    public class IncreasePrice
    {
        public decimal increasePrice { get; set; }

        public void Increase(decimal addedAmount)
        {
            increasePrice *= addedAmount;
        }
    }
    public class PhoneData:DbContext
    { 
        public PhoneData() : base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set; }
    
    }

}

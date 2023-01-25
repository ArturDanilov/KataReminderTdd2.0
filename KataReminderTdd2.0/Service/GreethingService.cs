using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataReminderTdd2._0.Service
{
    public class GreethingService
    {
        public void SendEmail(PersonBilder person)
        {
            Console.WriteLine($"Subject: Happy birthday\n\nHappy birthday {person.Fullname}!");
        }
    }
}

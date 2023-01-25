using System.Collections.Generic;

namespace KataReminderTdd2._0.Service
{
    public class BirthdayService
    {
        public bool HaveIBirthday(PersonBilder person)
        {
            if (person.Birthday.Month == DateTime.Now.Month && person.Birthday.Day == DateTime.Now.Day)
            {
                return true;
            }
            return false;
        }
        public void Login()
        {
            string? name;
            string? lastname;
            DateTime birthday;
            string email = string.Empty;

            Console.Write("Bitte Login Sie sich\n\nName: ");
            name = Console.ReadLine();

            Console.Write("Lastname: ");
            lastname = Console.ReadLine();

            Console.Write("Birthday (YYYY-MM-DD): ");
            birthday = Convert.ToDateTime(Console.ReadLine()); //empty DateTime error

            var user = new PersonBilder(name, lastname, birthday, email);

            Console.Clear();
            if (HaveIBirthday(user))
            {
                Console.WriteLine($"{name} {lastname}, Sie haben heute Geburtstag\nHerzlichen Glückwunsch!");
            }
            else
            {
                Console.WriteLine("Sie haben heute keineyn Geburtstag!\n");
            }
        }

        public PersonBilder FindBirthdaman(List<PersonBilder> listDb)
        {
            foreach (var item in listDb)
            {
                if (item.Birthday.Month == DateTime.Now.Month && item.Birthday.Day == DateTime.Now.Day)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

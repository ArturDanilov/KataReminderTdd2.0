using KataReminderTdd2._0.Data;
using KataReminderTdd2._0.Service;

namespace KataReminderTdd2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataImporter importer = new DataImporterToList();
            var listDb = importer.ImportPeople();

            BirthdayService birthdayService = new BirthdayService();
            birthdayService.Login();

            GreethingService greethingService = new GreethingService();

            bool flag = false;
            while (flag == false)
            {
                Console.WriteLine("\nWollen wir einen anderen Birthdman finden?\ny - yes\nn - no");
                
                var suchenBirthdman = Convert.ToString(Console.ReadLine());
                if (suchenBirthdman != null && suchenBirthdman != string.Empty)
                {
                    switch (suchenBirthdman.ToLower())
                    {
                        case ("y"):
                            Console.Clear();
                            var birthdaman = birthdayService.FindBirthdaman(listDb);
                            if (birthdaman != null)
                            {
                                Console.WriteLine($"{birthdaman.FirstName} hat heute Geburtstag\n");
                                Console.WriteLine($"Wollen Sie ein Mail an {birthdaman.FirstName} schiken?\ny - yes\nn - no");

                                string sendEmail = Convert.ToString(Console.ReadLine());
                                if (sendEmail != null && sendEmail != string.Empty)
                                {
                                    switch (sendEmail.ToLower())
                                    {
                                        case "y":
                                            Console.Clear();
                                            greethingService.SendEmail(birthdaman);
                                            break;
                                        case "n":
                                            Console.Clear();
                                            Console.WriteLine("Ok! Du bist der Scheff heute!");
                                            break;
                                        default:
                                            break;
                                    }
                                }                                   
                            }
                            else
                            {
                                Console.WriteLine("Niemand hat heute Geburtstag, nur Sie ;)");
                            }
                            flag= true;
                            break;
                        case ("n"):
                            flag= true;
                            break;
                        default:
                            Console.WriteLine("Wählen Sie bitte eine Operation:\ny - JA oder n - NEIN!");
                            break;
                    }
                }
            }
            Console.WriteLine("\nAuf Wiedersehen!");
        }        
    }
}
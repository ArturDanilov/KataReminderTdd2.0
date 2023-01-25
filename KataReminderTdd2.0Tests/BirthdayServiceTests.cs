using KataReminderTdd2._0;
using KataReminderTdd2._0.Data;
using KataReminderTdd2._0.Service;

namespace KataReminderTdd2._0Tests
{
    public class BirthdayServiceTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void PeopleBilder_HaveIBirthday_ExpectedYes()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de");
            BirthdayService birthdayService = new BirthdayService();

            var actual = birthdayService.HaveIBirthday(personBilder);
            
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void PeopleBilder_HaveIBirthday_ExpectedNo()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now.AddDays(+1), "artur@adesso.de");
            BirthdayService birthdayService = new BirthdayService();

            var actual = birthdayService.HaveIBirthday(personBilder);
            
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void PeopleBilder_BirthdayEmail_ExpectedBirthdayEmail()
        {            
            //BirthdayService birthdayService = new BirthdayService();
            //DataImporterToList dataImporterToList = new DataImporterToList();
            //var peopleList = dataImporterToList.ImportPeople();

            //var actual = birthdayService.FindBirthdaman(peopleList);

            //Assert.That(actual, Is.EqualTo();
        }
    }
}

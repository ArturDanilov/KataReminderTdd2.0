using KataReminderTdd2._0;

namespace KataReminderTdd2._0Tests
{
    public class PersonBilderTests

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PersonBilder_GetFirstName_ExpectedFirstname()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de");

            var actual = personBilder.FirstName;

            Assert.That(actual, Is.EqualTo("Artur"));
        }

        [Test]
        public void PersonBilder_GetLastName_ExpectedLastname()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de");

            var actual = personBilder.Lastname;

            Assert.That(actual, Is.EqualTo("Danilov"));
        }

        [Test]
        public void PersonBilder_GetBirthday_ExpectedBirthday()
        {
            DateTime birthday = DateTime.Now;
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", birthday, "artur@adesso.de");

            var actual = personBilder.Birthday;

            Assert.That(actual, Is.EqualTo(birthday));
        }

        [Test]
        public void PersonBilder_GetEmail_ExpectedEmail()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de");

            var actual = personBilder.Email;

            Assert.That(actual, Is.EqualTo("artur@adesso.de"));
        }


        [Test]
        public void PersonBilder_GetFullName_ExpectedFirstnameAndLastname()
        {
            PersonBilder personBilder = new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de");

            var actual = personBilder.Fullname;

            Assert.That(actual, Is.EqualTo("Artur Danilov"));
        }
    }
}
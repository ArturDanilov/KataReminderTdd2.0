namespace KataReminderTdd2._0
{
    public class PersonBilder
    {
        private string _forname = string.Empty;
        private string _lastname = string.Empty;
        private DateTime _birthday;
        private string _email = string.Empty;

        public Guid Id { get; }
        public string FirstName { get => _forname; private set => _forname = value; }
        public string Lastname { get => _lastname; private set => _lastname = value; }
        public string Email { get => _email; private set => _email = value; }
        public DateTime Birthday { get => _birthday; private set => _birthday = value; }
        public string Fullname { get => $"{FirstName} {Lastname}"; }


        public PersonBilder(string firstName, string lastName, DateTime birthday, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            Lastname = lastName;
            Birthday = birthday;
            Email = email;
        }
    }
}

namespace KataReminderTdd2._0.Data
{
    public class DataImporterToList : IDataImporter
    {
        private List<PersonBilder> listDb;
        public DataImporterToList()
        {
            listDb = new List<PersonBilder>();
        }
        public List<PersonBilder> ImportPeople()
        {
            listDb.Add(new PersonBilder("Artur", "Danilov", DateTime.Now, "artur@adesso.de"));
            listDb.Add(new PersonBilder("Darth", "Vader", DateTime.Now.AddDays(+1), "darth@adesso.de"));
            listDb.Add(new PersonBilder("Obi Van", "Kenobi", DateTime.Now.AddDays(+2), "obivan@adesso.de"));

            return listDb;
        }
    }
}

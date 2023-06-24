namespace BirthDayAPICore.Settings
{
    public class MongoDBSettings : IMongoDBSettings
    {
        public string UsersCollectionName { get; set; }
        public string BirthDaysCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}

namespace Flarine.Database.Context
{
    public sealed class SQLiteConfiguration : DatabaseConfiguration
    {
        public string DatabaseFile { get; set; } = "Data/Flarine.db";
    }
}
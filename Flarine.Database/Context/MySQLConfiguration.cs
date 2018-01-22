namespace Flarine.Database.Context
{
    internal sealed class MySQLConfiguration : DatabaseConfiguration
    {
        public string Server { get; set; } = "localhost";
        public string User { get; set; } = "root";
        public string Password { get; set; } = "";
        public string Database { get; set; } = "Flarine";
        public int Port { get; set; } = 3306;
    }
}
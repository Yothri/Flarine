namespace Flarine.Core.Context.Model
{
    public sealed class User
    {
        public int UserType { get; set; }
        public string UserId { get; set; }
        public string UserSecret { get; set; }
        public string AccessToken { get; set; }
        public int LastVirtualGameServer { get; set; }
    }
}
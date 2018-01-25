namespace Flarine.Core.Context.Model
{
    public sealed class User
    {
        public int UserType { get; set; }
        public string UserId { get; set; }
        public string UserSecret { get; set; }
        public string UserAccessToken { get; set; }
        public string GameAccessToken { get; set; }
        public int LastVirtualGameServer { get; set; }
    }
}
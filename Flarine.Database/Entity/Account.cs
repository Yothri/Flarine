using System.Collections.Generic;
using Flarine.Database.Interface;

namespace Flarine.Database.Entity
{
    public sealed class Account : IDatabaseEntity
    {
        public int Id { get; set; }
        public string AccountGuid { get; set; }
        public string UserId { get; set; }
        public string UserSecret { get; set; }

        public List<Hero> AccountHeros { get; set; }
    }
}
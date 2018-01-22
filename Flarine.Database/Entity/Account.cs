using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Flarine.Database.Interface;

namespace Flarine.Database.Entity
{
    [Table("tbl_accounts")]
    public sealed class Account : IDatabaseEntity
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string UserId { get; set; }
        public string UserSecret { get; set; }

        public List<Hero> AccountHeros { get; set; }
    }
}
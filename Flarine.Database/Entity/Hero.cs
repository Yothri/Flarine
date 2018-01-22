using System.ComponentModel.DataAnnotations.Schema;
using Flarine.Database.Interface;

namespace Flarine.Database.Entity
{
    [Table("tbl_heros")]
    public sealed class Hero : IDatabaseEntity
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int FaceId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Tradition { get; set; }
        public int CostumeId { get; set; }
        public bool CostumeVisible { get; set; }
        public int MountTier { get; set; }
    }
}
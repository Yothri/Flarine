using System.Numerics;
using Flarine.Database.Entity;

namespace Flarine.Game.Context.Model
{
    internal sealed class Character
    {
        public Character(Hero hero, string accountId)
        {
            AccountId = accountId;
            AccountHeroId = hero.Id;
            HeroId = hero.HeroId;
            FaceId = hero.FaceId;
            Name = hero.Name;
            Level = hero.Level;
            Tradition = hero.Tradition;
            CostumeId = hero.CostumeId;
            CostumeVisible = hero.CostumeVisible;
            MountTier = hero.MountTier;
            Position = new Vector3(hero.X, hero.Y, hero.Z);
            RotationY = hero.RotationY;
        }
        
        public string AccountId { get; set; }
        public int AccountHeroId { get; set; }
        public int HeroId { get; set; }
        public int FaceId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Tradition { get; set; }
        public int CostumeId { get; set; }
        public bool CostumeVisible { get; set; }
        public int MountTier { get; set; }
        public Vector3 Position { get; set; }
        public float RotationY { get; set; }
    }
}
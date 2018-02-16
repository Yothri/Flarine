using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpSkillResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.skillLevel);
			writer.Write(this.skillDegree);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.requiredGold);
			writer.Write(this.requiredMagicPowder);
			writer.Write(this.requiredSkillDegree);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
			writer.Write(this.magicPowder);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.skillLevel = reader.ReadInt32();
			this.skillDegree = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.requiredMagicPowder = reader.ReadInt32();
			this.requiredSkillDegree = reader.ReadInt32();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.magicPowder = reader.ReadInt64();
		}

		public LevelUpSkillResponseBody()
		{
		}

		public int skillLevel;

		public int skillDegree;

		public int requiredHeroLevel;

		public int requiredGold;

		public int requiredMagicPowder;

		public int requiredSkillDegree;

		public long ownGold;

		public long gold;

		public long magicPowder;
	}
}

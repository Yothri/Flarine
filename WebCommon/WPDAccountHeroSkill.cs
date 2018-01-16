using System;

namespace WebCommon
{
	public class WPDAccountHeroSkill : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.heroSkillId);
			writer.Write(this.level);
			writer.Write(this.skillDegree);
			writer.Write(this.slotId);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.requiredGold);
			writer.Write(this.requiredMagicPowder);
			writer.Write(this.requiredSkillDegree);
			writer.Write(this.maxHeroSkillLevel);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.heroSkillId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.skillDegree = reader.ReadInt32();
			this.slotId = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.requiredMagicPowder = reader.ReadInt32();
			this.requiredSkillDegree = reader.ReadInt32();
			this.maxHeroSkillLevel = reader.ReadInt32();
		}

		public WPDAccountHeroSkill()
		{
		}

		public int accountHeroId;

		public int heroSkillId;

		public int level;

		public int skillDegree;

		public int slotId;

		public int requiredHeroLevel;

		public int requiredGold;

		public int requiredMagicPowder;

		public int requiredSkillDegree;

		public int maxHeroSkillLevel;
	}
}

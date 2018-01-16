using System;

namespace ClientCommon.CommandBody
{
	public class JobBattlefieldAbandonResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.killCount);
			writer.Write(this.point);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardFamePoint);
			writer.Write(this.rewardMagicPowder);
			writer.Write(this.hp);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
			writer.Write(this.famePoint);
			writer.Write(this.magicPowder);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.killCount = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.rewardExp = reader.ReadInt64();
			this.rewardFamePoint = reader.ReadInt32();
			this.rewardMagicPowder = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.famePoint = reader.ReadInt32();
			this.magicPowder = reader.ReadInt64();
			this.continentId = reader.ReadInt32();
		}

		public JobBattlefieldAbandonResponseBody()
		{
		}

		public int killCount;

		public int point;

		public long rewardExp;

		public int rewardFamePoint;

		public int rewardMagicPowder;

		public int hp;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;

		public int famePoint;

		public long magicPowder;

		public int continentId;
	}
}

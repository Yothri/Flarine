using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildDungeonClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardGuildPoint);
			writer.Write(this.hp);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
			writer.Write(this.ownGold);
			writer.Write(this.guildPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.rewardExp = reader.ReadInt32();
			this.rewardGuildPoint = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.ownGold = reader.ReadInt64();
			this.guildPoint = reader.ReadInt32();
		}

		public SEBGuildDungeonClearEventBody()
		{
		}

		public int ranking;

		public int rewardOwnGold;

		public int rewardExp;

		public int rewardGuildPoint;

		public int hp;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;

		public long ownGold;

		public int guildPoint;
	}
}

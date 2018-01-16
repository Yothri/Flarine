using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTeamBattlefieldCompletedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.winnerTeamNo);
			writer.Write(this.killCount);
			writer.Write(this.point);
			writer.Write(this.ranking);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardAchievePoint);
			writer.Write(this.rewardMagicPowder);
			writer.Write(this.hp);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
			writer.Write(this.achievePoint);
			writer.Write(this.magicPowder);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.winnerTeamNo = reader.ReadInt32();
			this.killCount = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.ranking = reader.ReadInt32();
			this.rewardExp = reader.ReadInt64();
			this.rewardAchievePoint = reader.ReadInt32();
			this.rewardMagicPowder = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
			this.magicPowder = reader.ReadInt64();
		}

		public SEBTeamBattlefieldCompletedEventBody()
		{
		}

		public int winnerTeamNo;

		public int killCount;

		public int point;

		public int ranking;

		public long rewardExp;

		public int rewardAchievePoint;

		public int rewardMagicPowder;

		public int hp;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;

		public int achievePoint;

		public long magicPowder;
	}
}

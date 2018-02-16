using System;

namespace ClientCommon.CommandBody
{
	public class GouthanMineMiningCompleteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.minedOwnGold);
			writer.Write(this.minedMagicPowder);
			writer.Write(this.minedOwnDia);
			writer.Write(this.minedExp);
			writer.Write(this.hp);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.minedOwnGold = reader.ReadInt32();
			this.minedMagicPowder = reader.ReadInt32();
			this.minedOwnDia = reader.ReadInt32();
			this.minedExp = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
		}

		public GouthanMineMiningCompleteResponseBody()
		{
		}

		public DateTime date;

		public int minedOwnGold;

		public int minedMagicPowder;

		public int minedOwnDia;

		public int minedExp;

		public int hp;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;
	}
}

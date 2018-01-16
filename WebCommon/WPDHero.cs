using System;

namespace WebCommon
{
	public class WPDHero : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.attackRange);
			writer.Write(this.hitRange);
			writer.Write(this.statStrength);
			writer.Write(this.statStamina);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.attackRange = reader.ReadDouble();
			this.hitRange = reader.ReadDouble();
			this.statStrength = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
		}

		public WPDHero()
		{
		}

		public int heroId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public double attackRange;

		public double hitRange;

		public int statStrength;

		public int statStamina;

		public int statAgility;

		public int statIntelligence;
	}
}

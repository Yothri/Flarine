using System;

namespace WebCommon
{
	public class WPDGear : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.gearType);
			writer.Write(this.heroId);
			writer.Write(this.tier);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.twoHand);
			writer.Write(this.attackMotionCount);
			writer.Write(this.attackRange);
			writer.Write(this.minSocketCount);
			writer.Write(this.maxSocketCount);
			writer.Write(this.nextTierGearId);
			writer.Write(this.requiredStrength);
			writer.Write(this.requiredAgility);
			writer.Write(this.requiredIntelligence);
			writer.Write(this.requiredStamina);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.gearType = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.tier = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.twoHand = reader.ReadBoolean();
			this.attackMotionCount = reader.ReadInt32();
			this.attackRange = reader.ReadDouble();
			this.minSocketCount = reader.ReadInt32();
			this.maxSocketCount = reader.ReadInt32();
			this.nextTierGearId = reader.ReadInt32();
			this.requiredStrength = reader.ReadInt32();
			this.requiredAgility = reader.ReadInt32();
			this.requiredIntelligence = reader.ReadInt32();
			this.requiredStamina = reader.ReadInt32();
		}

		public WPDGear()
		{
		}

		public int gearId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int gearType;

		public int heroId;

		public int tier;

		public int requiredHeroLevel;

		public bool twoHand;

		public int attackMotionCount;

		public double attackRange;

		public int minSocketCount;

		public int maxSocketCount;

		public int nextTierGearId;

		public int requiredStrength;

		public int requiredAgility;

		public int requiredIntelligence;

		public int requiredStamina;
	}
}

using System;

namespace WebCommon
{
	public class WPDHeroSetGear : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.tier);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.enchantLevel);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.tier = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
		}

		public WPDHeroSetGear()
		{
		}

		public int heroId;

		public int tier;

		public int gearId;

		public int grade;

		public int enchantLevel;
	}
}

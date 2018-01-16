using System;

namespace WebCommon
{
	public class WPDGearRuneEnchantSetting : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.runeId);
			writer.Write(this.maxValue);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.runeId = reader.ReadInt32();
			this.maxValue = reader.ReadDouble();
		}

		public WPDGearRuneEnchantSetting()
		{
		}

		public int gearId;

		public int grade;

		public int runeId;

		public double maxValue;
	}
}

using System;

namespace WebCommon
{
	public class WPDGearOptionAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.attrId);
			writer.Write(this.minValue);
			writer.Write(this.maxValue);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.minValue = reader.ReadInt32();
			this.maxValue = reader.ReadInt32();
		}

		public WPDGearOptionAttr()
		{
		}

		public int gearId;

		public int grade;

		public int attrId;

		public int minValue;

		public int maxValue;
	}
}

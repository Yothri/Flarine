using System;

namespace WebCommon
{
	public class WPDGearAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.type);
			writer.Write(this.attrId);
			writer.Write(this.minValue);
			writer.Write(this.maxValue);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.minValue = reader.ReadInt32();
			this.maxValue = reader.ReadInt32();
		}

		public WPDGearAttr()
		{
		}

		public int gearId;

		public int type;

		public int attrId;

		public int minValue;

		public int maxValue;
	}
}

using System;

namespace WebCommon
{
	public class WPDCostumeLevelAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.costumeId);
			writer.Write(this.level);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.costumeId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDCostumeLevelAttr()
		{
		}

		public int costumeId;

		public int level;

		public int attrId;

		public double value;
	}
}

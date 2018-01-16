using System;

namespace WebCommon
{
	public class WPDGearAttrEnchantLevelAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.attrEnchantLevel = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDGearAttrEnchantLevelAttr()
		{
		}

		public int gearId;

		public int attrEnchantLevel;

		public int attrId;

		public double value;
	}
}

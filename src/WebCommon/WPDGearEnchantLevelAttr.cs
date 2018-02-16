using System;

namespace WebCommon
{
	public class WPDGearEnchantLevelAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.enchantLevel);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDGearEnchantLevelAttr()
		{
		}

		public int gearId;

		public int enchantLevel;

		public int attrId;

		public double value;
	}
}

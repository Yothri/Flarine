using System;

namespace WebCommon
{
	public class WPDEquippedGearEnchantSetBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.setId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.setId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDEquippedGearEnchantSetBuff()
		{
		}

		public int setId;

		public int attrId;

		public double value;
	}
}

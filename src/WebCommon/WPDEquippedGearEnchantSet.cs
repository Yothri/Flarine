using System;

namespace WebCommon
{
	public class WPDEquippedGearEnchantSet : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.setId);
			writer.Write(this.enchantLevel);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.setId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDEquippedGearEnchantSet()
		{
		}

		public int setId;

		public int enchantLevel;

		public int count;
	}
}

using System;

namespace WebCommon
{
	public class WPDGearTier : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.maxElementalLevel);
			writer.Write(this.attrEnchantEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.maxElementalLevel = reader.ReadInt32();
			this.attrEnchantEnabled = reader.ReadBoolean();
		}

		public WPDGearTier()
		{
		}

		public int tier;

		public int maxElementalLevel;

		public bool attrEnchantEnabled;
	}
}

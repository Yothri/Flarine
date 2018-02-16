using System;

namespace WebCommon
{
	public class WPDGearElementalEnchantRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elementalLevel);
			writer.Write(this.gold);
			writer.Write(this.cardCount);
			writer.Write(this.successRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elementalLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.cardCount = reader.ReadInt32();
			this.successRate = reader.ReadInt32();
		}

		public WPDGearElementalEnchantRecipe()
		{
		}

		public int elementalLevel;

		public int gold;

		public int cardCount;

		public int successRate;
	}
}

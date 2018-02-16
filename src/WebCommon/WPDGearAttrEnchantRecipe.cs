using System;

namespace WebCommon
{
	public class WPDGearAttrEnchantRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.gold);
			writer.Write(this.materialItemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.attrEnchantLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.materialItemCount = reader.ReadInt32();
		}

		public WPDGearAttrEnchantRecipe()
		{
		}

		public int attrEnchantLevel;

		public int gold;

		public int materialItemCount;
	}
}

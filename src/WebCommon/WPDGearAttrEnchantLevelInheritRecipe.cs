using System;

namespace WebCommon
{
	public class WPDGearAttrEnchantLevelInheritRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.gold);
			writer.Write(this.goldRate);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.attrEnchantLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.goldRate = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDGearAttrEnchantLevelInheritRecipe()
		{
		}

		public int attrEnchantLevel;

		public int gold;

		public int goldRate;

		public int unOwnDia;
	}
}

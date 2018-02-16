using System;

namespace WebCommon
{
	public class WPDGearEnchantLevelInheritRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.enchantLevel);
			writer.Write(this.gold);
			writer.Write(this.goldRate);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.enchantLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.goldRate = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDGearEnchantLevelInheritRecipe()
		{
		}

		public int enchantLevel;

		public int gold;

		public int goldRate;

		public int unOwnDia;
	}
}

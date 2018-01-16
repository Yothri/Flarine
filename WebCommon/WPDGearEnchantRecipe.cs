using System;

namespace WebCommon
{
	public class WPDGearEnchantRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.enchantLevel);
			writer.Write(this.gold);
			writer.Write(this.orichalcumId);
			writer.Write(this.orichalcumCount);
			writer.Write(this.material1ItemId);
			writer.Write(this.material1ItemCount);
			writer.Write(this.material2ItemId);
			writer.Write(this.material2ItemCount);
			writer.Write(this.protectionScrollCount);
			writer.Write(this.successRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.enchantLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.orichalcumId = reader.ReadInt32();
			this.orichalcumCount = reader.ReadInt32();
			this.material1ItemId = reader.ReadInt32();
			this.material1ItemCount = reader.ReadInt32();
			this.material2ItemId = reader.ReadInt32();
			this.material2ItemCount = reader.ReadInt32();
			this.protectionScrollCount = reader.ReadInt32();
			this.successRate = reader.ReadInt32();
		}

		public WPDGearEnchantRecipe()
		{
		}

		public int enchantLevel;

		public int gold;

		public int orichalcumId;

		public int orichalcumCount;

		public int material1ItemId;

		public int material1ItemCount;

		public int material2ItemId;

		public int material2ItemCount;

		public int protectionScrollCount;

		public int successRate;
	}
}

using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearAttrEnchantLevelResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.success);
			writer.Write(this.extractionGearAttrEnchantLevel);
			writer.Write(this.inheritGearAttrEnchantLevel);
			writer.Write(this.inheritGearOwned);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.success = reader.ReadBoolean();
			this.extractionGearAttrEnchantLevel = reader.ReadInt32();
			this.inheritGearAttrEnchantLevel = reader.ReadInt32();
			this.inheritGearOwned = reader.ReadBoolean();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
		}

		public InheritGearAttrEnchantLevelResponseBody()
		{
		}

		public bool success;

		public int extractionGearAttrEnchantLevel;

		public int inheritGearAttrEnchantLevel;

		public bool inheritGearOwned;

		public long ownGold;

		public long gold;
	}
}

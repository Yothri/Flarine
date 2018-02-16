using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GearAttributeEnchantResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.gearOwned);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attrEnchantLevel = reader.ReadInt32();
			this.gearOwned = reader.ReadBoolean();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public GearAttributeEnchantResponseBody()
		{
		}

		public int attrEnchantLevel;

		public bool gearOwned;

		public long ownGold;

		public long gold;

		public PDInventorySlot[] changedInventorySlots;
	}
}

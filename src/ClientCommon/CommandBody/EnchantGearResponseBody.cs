using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EnchantGearResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.success);
			writer.Write(this.gearOwned);
			writer.Write(this.gearEnchantLevel);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.success = reader.ReadBoolean();
			this.gearOwned = reader.ReadBoolean();
			this.gearEnchantLevel = reader.ReadInt32();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public EnchantGearResponseBody()
		{
		}

		public bool success;

		public bool gearOwned;

		public int gearEnchantLevel;

		public long ownGold;

		public long gold;

		public PDInventorySlot[] changedInventorySlots;
	}
}

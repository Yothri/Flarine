using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GearRuneEnchantResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.value);
			writer.Write(this.gearOwned);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.value = reader.ReadSingle();
			this.gearOwned = reader.ReadBoolean();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public GearRuneEnchantResponseBody()
		{
		}

		public float value;

		public bool gearOwned;

		public long ownGold;

		public long gold;

		public PDInventorySlot[] changedInventorySlots;
	}
}

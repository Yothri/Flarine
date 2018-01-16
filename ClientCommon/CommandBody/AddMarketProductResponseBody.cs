using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AddMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public AddMarketProductResponseBody()
		{
		}

		public long gold;

		public PDInventorySlot[] changedInventorySlots;
	}
}

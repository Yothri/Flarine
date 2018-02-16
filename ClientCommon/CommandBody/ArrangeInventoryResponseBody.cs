using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ArrangeInventoryResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.inventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.inventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public ArrangeInventoryResponseBody()
		{
		}

		public PDInventorySlot[] inventorySlots;
	}
}

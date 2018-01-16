using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ArrangeWarehouseResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.warehouseSlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.warehouseSlots = reader.ReadPDPacketDatas<PDWarehouseSlot>();
		}

		public ArrangeWarehouseResponseBody()
		{
		}

		public PDWarehouseSlot[] warehouseSlots;
	}
}

using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ArrangePickWarehouseResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pickWarehouseSlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pickWarehouseSlots = reader.ReadPDPacketDatas<PDPickWarehouseSlot>();
		}

		public ArrangePickWarehouseResponseBody()
		{
		}

		public PDPickWarehouseSlot[] pickWarehouseSlots;
	}
}

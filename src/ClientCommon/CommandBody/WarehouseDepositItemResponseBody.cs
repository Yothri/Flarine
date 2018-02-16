using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class WarehouseDepositItemResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedWarehouseSlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedWarehouseSlots = reader.ReadPDPacketDatas<PDWarehouseSlot>();
		}

		public WarehouseDepositItemResponseBody()
		{
		}

		public PDWarehouseSlot[] changedWarehouseSlots;
	}
}

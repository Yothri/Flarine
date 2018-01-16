using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBWarehouseSlotExtendEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.warehouseSlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.warehouseSlotNo = reader.ReadInt32();
		}

		public SEBWarehouseSlotExtendEventBody()
		{
		}

		public int warehouseSlotNo;
	}
}

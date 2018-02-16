using System;

namespace ClientCommon.CommandBody
{
	public class FreeExtendWarehouseSlotCommandBody : CommandBody
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

		public FreeExtendWarehouseSlotCommandBody()
		{
		}

		public int warehouseSlotNo;
	}
}

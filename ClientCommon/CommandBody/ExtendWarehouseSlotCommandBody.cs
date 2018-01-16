using System;

namespace ClientCommon.CommandBody
{
	public class ExtendWarehouseSlotCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extendWarehouseSlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extendWarehouseSlotNo = reader.ReadInt32();
		}

		public ExtendWarehouseSlotCommandBody()
		{
		}

		public int extendWarehouseSlotNo;
	}
}

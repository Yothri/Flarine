using System;

namespace ClientCommon.CommandBody
{
	public class DivideInventoryItemCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.inventorySlotNo);
			writer.Write(this.divideCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.inventorySlotNo = reader.ReadInt32();
			this.divideCount = reader.ReadInt32();
		}

		public DivideInventoryItemCommandBody()
		{
		}

		public int inventorySlotNo;

		public int divideCount;
	}
}

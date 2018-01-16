using System;

namespace ClientCommon.CommandBody
{
	public class FreeExtendInventorySlotCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.inventorySlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.inventorySlotNo = reader.ReadInt32();
		}

		public FreeExtendInventorySlotCommandBody()
		{
		}

		public int inventorySlotNo;
	}
}

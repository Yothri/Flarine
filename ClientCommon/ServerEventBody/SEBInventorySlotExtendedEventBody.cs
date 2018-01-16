using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBInventorySlotExtendedEventBody : SEBServerEventBody
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

		public SEBInventorySlotExtendedEventBody()
		{
		}

		public int inventorySlotNo;
	}
}

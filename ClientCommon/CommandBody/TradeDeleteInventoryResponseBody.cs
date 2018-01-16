using System;

namespace ClientCommon.CommandBody
{
	public class TradeDeleteInventoryResponseBody : ResponseBody
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

		public TradeDeleteInventoryResponseBody()
		{
		}

		public int inventorySlotNo;
	}
}

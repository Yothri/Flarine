using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeDeleteInventoryEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradeSlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.tradeSlotNo = reader.ReadInt32();
		}

		public SEBTradeDeleteInventoryEventBody()
		{
		}

		public int tradeSlotNo;
	}
}

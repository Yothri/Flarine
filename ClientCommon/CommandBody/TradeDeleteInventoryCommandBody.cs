using System;

namespace ClientCommon.CommandBody
{
	public class TradeDeleteInventoryCommandBody : CommandBody
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

		public TradeDeleteInventoryCommandBody()
		{
		}

		public int tradeSlotNo;
	}
}

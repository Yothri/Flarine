using System;

namespace ClientCommon.CommandBody
{
	public class TradeRegisterInventoryResponseBody : ResponseBody
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

		public TradeRegisterInventoryResponseBody()
		{
		}

		public int tradeSlotNo;
	}
}

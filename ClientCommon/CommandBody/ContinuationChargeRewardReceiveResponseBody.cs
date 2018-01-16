using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ContinuationChargeRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public ContinuationChargeRewardReceiveResponseBody()
		{
		}

		public DateTime date;

		public PDInventorySlot[] changedInventorySlots;
	}
}

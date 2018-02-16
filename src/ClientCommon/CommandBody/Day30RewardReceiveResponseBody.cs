using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class Day30RewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public Day30RewardReceiveResponseBody()
		{
		}

		public PDInventorySlot[] changedInventorySlots;
	}
}

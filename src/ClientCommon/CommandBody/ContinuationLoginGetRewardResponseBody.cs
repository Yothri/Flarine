using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ContinuationLoginGetRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.rewardNos);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.rewardNos = reader.ReadInts();
		}

		public ContinuationLoginGetRewardResponseBody()
		{
		}

		public PDInventorySlot[] changedInventorySlots;

		public int[] rewardNos;
	}
}

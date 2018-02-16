using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyActiveGetRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.totalMagicPowder);
			writer.Write(this.totalOwnGold);
			writer.Write(this.vipLevel);
			writer.Write(this.vipPoint);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.totalMagicPowder = reader.ReadInt64();
			this.totalOwnGold = reader.ReadInt64();
			this.vipLevel = reader.ReadInt32();
			this.vipPoint = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public DailyActiveGetRewardResponseBody()
		{
		}

		public long totalMagicPowder;

		public long totalOwnGold;

		public int vipLevel;

		public int vipPoint;

		public PDInventorySlot[] changedInventorySlots;
	}
}

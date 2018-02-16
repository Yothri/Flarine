using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class HeroLevelGetRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.totalMagicPowder);
			writer.Write(this.totalOwnGold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.totalMagicPowder = reader.ReadInt64();
			this.totalOwnGold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public HeroLevelGetRewardResponseBody()
		{
		}

		public long totalMagicPowder;

		public long totalOwnGold;

		public PDInventorySlot[] changedInventorySlots;
	}
}

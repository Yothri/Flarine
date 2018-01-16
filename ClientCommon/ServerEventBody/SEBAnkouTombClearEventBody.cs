using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBAnkouTombClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.point);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.randomRewardItemId);
			writer.Write(this.randomRewardItemCount);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.point = reader.ReadInt32();
			this.rewardExp = reader.ReadInt64();
			this.rewardOwnGold = reader.ReadInt64();
			this.randomRewardItemId = reader.ReadInt32();
			this.randomRewardItemCount = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public SEBAnkouTombClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int point;

		public long rewardExp;

		public long rewardOwnGold;

		public int randomRewardItemId;

		public int randomRewardItemCount;

		public PDInventorySlot[] changedInventorySlots;
	}
}

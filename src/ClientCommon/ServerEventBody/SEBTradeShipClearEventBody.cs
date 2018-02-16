using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeShipClearEventBody : SEBServerEventBody
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
			writer.Write(this.destroyerRewardItemId);
			writer.Write(this.destroyerRewardItemCount);
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
			this.destroyerRewardItemId = reader.ReadInt32();
			this.destroyerRewardItemCount = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public SEBTradeShipClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int point;

		public long rewardExp;

		public long rewardOwnGold;

		public int randomRewardItemId;

		public int randomRewardItemCount;

		public int destroyerRewardItemId;

		public int destroyerRewardItemCount;

		public PDInventorySlot[] changedInventorySlots;
	}
}

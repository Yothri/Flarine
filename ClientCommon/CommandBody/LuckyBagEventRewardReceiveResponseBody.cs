using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LuckyBagEventRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.fullMoonBuffId);
			writer.Write(this.fullMonnBuffRemainingTime);
			writer.Write(this.remainExchangeableCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.fullMoonBuffId = reader.ReadInt32();
			this.fullMonnBuffRemainingTime = reader.ReadSingle();
			this.remainExchangeableCount = reader.ReadInt32();
		}

		public LuckyBagEventRewardReceiveResponseBody()
		{
		}

		public PDInventorySlot[] changedInventorySlots;

		public int fullMoonBuffId;

		public float fullMonnBuffRemainingTime;

		public int remainExchangeableCount;
	}
}

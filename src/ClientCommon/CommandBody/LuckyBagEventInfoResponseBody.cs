using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LuckyBagEventInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.eventId);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.rewardEndTime);
			writer.Write(this.buffDuration);
			writer.Write(this.luckyBagItemId);
			writer.Write(this.imageFileName);
			writer.Write(this.lukcyBagEventRewardEntries);
			writer.Write(this.receiveRewardEntries);
			writer.Write(this.receiveRewardCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.eventId = reader.ReadInt32();
			this.startTime = reader.ReadDateTimeOffset();
			this.endTime = reader.ReadDateTimeOffset();
			this.rewardEndTime = reader.ReadDateTimeOffset();
			this.buffDuration = reader.ReadInt32();
			this.luckyBagItemId = reader.ReadInt32();
			this.imageFileName = reader.ReadString();
			this.lukcyBagEventRewardEntries = reader.ReadPDPacketDatas<PDLuckyBagEventRewardEntry>();
			this.receiveRewardEntries = reader.ReadInts();
			this.receiveRewardCounts = reader.ReadInts();
		}

		public LuckyBagEventInfoResponseBody()
		{
		}

		public int eventId;

		public DateTimeOffset startTime;

		public DateTimeOffset endTime;

		public DateTimeOffset rewardEndTime;

		public int buffDuration;

		public int luckyBagItemId;

		public string imageFileName;

		public PDLuckyBagEventRewardEntry[] lukcyBagEventRewardEntries;

		public int[] receiveRewardEntries;

		public int[] receiveRewardCounts;
	}
}

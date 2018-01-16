using System;

namespace WebCommon
{
	public class WPDDailyAccessReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.accessTime);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.receivedRewardNo);
			writer.Write(this.date);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.accessTime = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.receivedRewardNo = reader.ReadInt32();
			this.date = reader.ReadString();
		}

		public WPDDailyAccessReward()
		{
		}

		public int rewardNo;

		public int accessTime;

		public int itemId;

		public int count;

		public int receivedRewardNo;

		public string date;
	}
}

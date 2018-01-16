using System;

namespace WebCommon
{
	public class WPDContinuationLoginRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.loginCount);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.receivedRewardNo);
			writer.Write(this.date);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.loginCount = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.receivedRewardNo = reader.ReadInt32();
			this.date = reader.ReadString();
		}

		public WPDContinuationLoginRewardItem()
		{
		}

		public int loginCount;

		public int rewardNo;

		public int itemId;

		public int count;

		public int receivedRewardNo;

		public string date;
	}
}

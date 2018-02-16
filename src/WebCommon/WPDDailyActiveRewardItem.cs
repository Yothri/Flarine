using System;

namespace WebCommon
{
	public class WPDDailyActiveRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDDailyActiveRewardItem()
		{
		}

		public int rewardNo;

		public int itemId;

		public int count;
	}
}

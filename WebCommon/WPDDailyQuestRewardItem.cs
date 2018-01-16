using System;

namespace WebCommon
{
	public class WPDDailyQuestRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardItemGroupId);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardItemGroupId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDDailyQuestRewardItem()
		{
		}

		public int rewardItemGroupId;

		public int itemId;

		public int count;
	}
}

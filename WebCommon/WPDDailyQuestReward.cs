using System;

namespace WebCommon
{
	public class WPDDailyQuestReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardId);
			writer.Write(this.exp);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardId = reader.ReadInt32();
			this.exp = reader.ReadInt32();
		}

		public WPDDailyQuestReward()
		{
		}

		public int rewardId;

		public int exp;
	}
}

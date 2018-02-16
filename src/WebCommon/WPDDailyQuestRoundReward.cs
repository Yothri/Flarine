using System;

namespace WebCommon
{
	public class WPDDailyQuestRoundReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardId);
			writer.Write(this.exp);
			writer.Write(this.starEssense);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardId = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.starEssense = reader.ReadInt32();
		}

		public WPDDailyQuestRoundReward()
		{
		}

		public int rewardId;

		public int exp;

		public int starEssense;
	}
}

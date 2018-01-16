using System;

namespace WebCommon
{
	public class WPDHeroLevelReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.heroLevel);
			writer.Write(this.ownGold);
			writer.Write(this.magicPowder);
			writer.Write(this.receivedRewardNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.heroLevel = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.receivedRewardNo = reader.ReadInt32();
		}

		public WPDHeroLevelReward()
		{
		}

		public int rewardNo;

		public int heroLevel;

		public int ownGold;

		public int magicPowder;

		public int receivedRewardNo;
	}
}

using System;

namespace WebCommon
{
	public class WPDSecretChamber : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.enterCount);
			writer.Write(this.maxMemberCount);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.beadPowder);
			writer.Write(this.exp);
			writer.Write(this.ownGold);
			writer.Write(this.clearCrackRewardFactor);
			writer.Write(this.failRewardFactor);
			writer.Write(this.locationId);
			writer.Write(this.requiredMountTier);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.enterCount = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.beadPowder = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.clearCrackRewardFactor = reader.ReadDouble();
			this.failRewardFactor = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
		}

		public WPDSecretChamber()
		{
		}

		public int requiredMainQuestId;

		public int enterCount;

		public int maxMemberCount;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int beadPowder;

		public int exp;

		public int ownGold;

		public double clearCrackRewardFactor;

		public double failRewardFactor;

		public int locationId;

		public int requiredMountTier;
	}
}

using System;

namespace WebCommon
{
	public class WPDFieldOfHonor : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.freeChallengeCount);
			writer.Write(this.additionalChallengeUnOwnDia);
			writer.Write(this.waitingTimeResetUnOwnDia);
			writer.Write(this.waitingTime);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.rankingRewardInterval);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.targetXPosition);
			writer.Write(this.targetYPosition);
			writer.Write(this.targetZPosition);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.freeChallengeCount = reader.ReadInt32();
			this.additionalChallengeUnOwnDia = reader.ReadInt32();
			this.waitingTimeResetUnOwnDia = reader.ReadInt32();
			this.waitingTime = reader.ReadInt32();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.rankingRewardInterval = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.targetXPosition = reader.ReadDouble();
			this.targetYPosition = reader.ReadDouble();
			this.targetZPosition = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
		}

		public WPDFieldOfHonor()
		{
		}

		public int requiredMainQuestId;

		public int freeChallengeCount;

		public int additionalChallengeUnOwnDia;

		public int waitingTimeResetUnOwnDia;

		public int waitingTime;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int rankingRewardInterval;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double targetXPosition;

		public double targetYPosition;

		public double targetZPosition;

		public int locationId;
	}
}

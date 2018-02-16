using System;

namespace WebCommon
{
	public class WPDGuildBattlefield : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.requiredMountTier);
			writer.Write(this.recommendPower);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.resurrectionInvincibleTime);
			writer.Write(this.openTime);
			writer.Write(this.maxMemberCount);
			writer.Write(this.maxMemberCountPerGuild);
			writer.Write(this.pointPerKill);
			writer.Write(this.rewardDuration);
			writer.Write(this.maxPlayCount);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
			this.recommendPower = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.resurrectionInvincibleTime = reader.ReadInt32();
			this.openTime = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.maxMemberCountPerGuild = reader.ReadInt32();
			this.pointPerKill = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.maxPlayCount = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
		}

		public WPDGuildBattlefield()
		{
		}

		public int requiredMainQuestId;

		public int requiredMountTier;

		public int recommendPower;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public int startDelayTime;

		public int limitTime;

		public int resurrectionInvincibleTime;

		public int openTime;

		public int maxMemberCount;

		public int maxMemberCountPerGuild;

		public int pointPerKill;

		public int rewardDuration;

		public int maxPlayCount;

		public int locationId;
	}
}

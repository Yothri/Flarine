using System;

namespace WebCommon
{
	public class WPDBossAnnihilation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.sceneName);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.maxMemberCount);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.spawnXPosition);
			writer.Write(this.spawnYPosition);
			writer.Write(this.spawnZPosition);
			writer.Write(this.spawnRadius);
			writer.Write(this.bossTargetingInterval);
			writer.Write(this.locationId);
			writer.Write(this.teleportConsumeFp);
			writer.Write(this.maxPlayCount);
			writer.Write(this.requiredMountTier);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.spawnXPosition = reader.ReadDouble();
			this.spawnYPosition = reader.ReadDouble();
			this.spawnZPosition = reader.ReadDouble();
			this.spawnRadius = reader.ReadDouble();
			this.bossTargetingInterval = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.teleportConsumeFp = reader.ReadInt32();
			this.maxPlayCount = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
		}

		public WPDBossAnnihilation()
		{
		}

		public int requiredMainQuestId;

		public string sceneName;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int maxMemberCount;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public double spawnXPosition;

		public double spawnYPosition;

		public double spawnZPosition;

		public double spawnRadius;

		public int bossTargetingInterval;

		public int locationId;

		public int teleportConsumeFp;

		public int maxPlayCount;

		public int requiredMountTier;
	}
}

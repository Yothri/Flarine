using System;

namespace WebCommon
{
	public class WPDArena : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.recommendPower);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.resurrectionInvincibleTime);
			writer.Write(this.maxMemberCount);
			writer.Write(this.pointPerKill);
			writer.Write(this.winnerPoint);
			writer.Write(this.winnerBuffDuration);
			writer.Write(this.locationId);
			writer.Write(this.teleportConsumeFp);
			writer.Write(this.maxPlayCount);
			writer.Write(this.requiredMountTier);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.recommendPower = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.resurrectionInvincibleTime = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.pointPerKill = reader.ReadInt32();
			this.winnerPoint = reader.ReadInt32();
			this.winnerBuffDuration = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.teleportConsumeFp = reader.ReadInt32();
			this.maxPlayCount = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
		}

		public WPDArena()
		{
		}

		public int requiredMainQuestId;

		public int recommendPower;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public int startDelayTime;

		public int limitTime;

		public int resurrectionInvincibleTime;

		public int maxMemberCount;

		public int pointPerKill;

		public int winnerPoint;

		public int winnerBuffDuration;

		public int locationId;

		public int teleportConsumeFp;

		public int maxPlayCount;

		public int requiredMountTier;
	}
}

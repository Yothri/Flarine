using System;

namespace WebCommon
{
	public class WPDTradeShip : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.enterCount);
			writer.Write(this.sceneName);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.maxMemberCount);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.objectPoint);
			writer.Write(this.exp2xUnOwnDia);
			writer.Write(this.exp3xUnOwnDia);
			writer.Write(this.locationId);
			writer.Write(this.teleportConsumeFp);
			writer.Write(this.requiredMountTier);
			writer.Write(this.pkEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.enterCount = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.objectPoint = reader.ReadInt32();
			this.exp2xUnOwnDia = reader.ReadInt32();
			this.exp3xUnOwnDia = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.teleportConsumeFp = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
			this.pkEnabled = reader.ReadBoolean();
		}

		public WPDTradeShip()
		{
		}

		public int requiredMainQuestId;

		public int enterCount;

		public string sceneName;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int maxMemberCount;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public int objectPoint;

		public int exp2xUnOwnDia;

		public int exp3xUnOwnDia;

		public int locationId;

		public int teleportConsumeFp;

		public int requiredMountTier;

		public bool pkEnabled;
	}
}

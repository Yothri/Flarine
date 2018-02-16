﻿using System;

namespace WebCommon
{
	public class WPDFallenCity : WPDPacketData
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
			writer.Write(this.exp);
			writer.Write(this.ownGold);
			writer.Write(this.failRewardFactor);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.sceneName);
			writer.Write(this.bossMonsterId);
			writer.Write(this.locationId);
			writer.Write(this.requiredMountTier);
			writer.Write(this.rewardPick2UnOwnDia);
			writer.Write(this.rewardPick3UnOwnDia);
			writer.Write(this.rewardPick4UnOwnDia);
			writer.Write(this.rewardPickAllUnOwnDia);
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
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.failRewardFactor = reader.ReadDouble();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.sceneName = reader.ReadString();
			this.bossMonsterId = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
			this.rewardPick2UnOwnDia = reader.ReadInt32();
			this.rewardPick3UnOwnDia = reader.ReadInt32();
			this.rewardPick4UnOwnDia = reader.ReadInt32();
			this.rewardPickAllUnOwnDia = reader.ReadInt32();
		}

		public WPDFallenCity()
		{
		}

		public int requiredMainQuestId;

		public int enterCount;

		public int maxMemberCount;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int exp;

		public int ownGold;

		public double failRewardFactor;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public string sceneName;

		public int bossMonsterId;

		public int locationId;

		public int requiredMountTier;

		public int rewardPick2UnOwnDia;

		public int rewardPick3UnOwnDia;

		public int rewardPick4UnOwnDia;

		public int rewardPickAllUnOwnDia;
	}
}

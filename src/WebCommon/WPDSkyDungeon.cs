using System;

namespace WebCommon
{
	public class WPDSkyDungeon : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
			writer.Write(this.continentId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.maxMemberCount);
			writer.Write(this.sceneName);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.locationId);
			writer.Write(this.requiredConsumeFp);
			writer.Write(this.requiredMountTier);
			writer.Write(this.rewardPick2UnOwnDia);
			writer.Write(this.rewardPick3UnOwnDia);
			writer.Write(this.rewardPick4UnOwnDia);
			writer.Write(this.rewardPickAllUnOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.requiredMainQuestId = reader.ReadInt32();
			this.maxMemberCount = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
			this.requiredConsumeFp = reader.ReadInt32();
			this.requiredMountTier = reader.ReadInt32();
			this.rewardPick2UnOwnDia = reader.ReadInt32();
			this.rewardPick3UnOwnDia = reader.ReadInt32();
			this.rewardPick4UnOwnDia = reader.ReadInt32();
			this.rewardPickAllUnOwnDia = reader.ReadInt32();
		}

		public WPDSkyDungeon()
		{
		}

		public int dungeonId;

		public int continentId;

		public string name;

		public string nameKey;

		public int requiredMainQuestId;

		public int maxMemberCount;

		public string sceneName;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public int locationId;

		public int requiredConsumeFp;

		public int requiredMountTier;

		public int rewardPick2UnOwnDia;

		public int rewardPick3UnOwnDia;

		public int rewardPick4UnOwnDia;

		public int rewardPickAllUnOwnDia;
	}
}

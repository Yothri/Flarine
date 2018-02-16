using System;

namespace WebCommon
{
	public class WPDExpDungeon : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.expDungeonId);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.enterCount);
			writer.Write(this.waveCount);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.locationId);
			writer.Write(this.rewardPick2UnOwnDia);
			writer.Write(this.rewardPick3UnOwnDia);
			writer.Write(this.rewardPick4UnOwnDia);
			writer.Write(this.rewardPickAllUnOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.expDungeonId = reader.ReadInt32();
			this.requiredMainQuestId = reader.ReadInt32();
			this.enterCount = reader.ReadInt32();
			this.waveCount = reader.ReadInt32();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
			this.rewardPick2UnOwnDia = reader.ReadInt32();
			this.rewardPick3UnOwnDia = reader.ReadInt32();
			this.rewardPick4UnOwnDia = reader.ReadInt32();
			this.rewardPickAllUnOwnDia = reader.ReadInt32();
		}

		public WPDExpDungeon()
		{
		}

		public int expDungeonId;

		public int requiredMainQuestId;

		public int enterCount;

		public int waveCount;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public int locationId;

		public int rewardPick2UnOwnDia;

		public int rewardPick3UnOwnDia;

		public int rewardPick4UnOwnDia;

		public int rewardPickAllUnOwnDia;
	}
}

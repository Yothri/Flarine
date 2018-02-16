using System;

namespace WebCommon
{
	public class WPDGoldDungeon : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.goldDungeonId);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.enterCount);
			writer.Write(this.waveCount);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.rewardDuration);
			writer.Write(this.waveInterval);
			writer.Write(this.spawnInterval);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.spawnXPosition);
			writer.Write(this.spawnYPosition);
			writer.Write(this.spawnZPosition);
			writer.Write(this.spawnRadius);
			writer.Write(this.targetXPosition);
			writer.Write(this.targetYPosition);
			writer.Write(this.targetZPosition);
			writer.Write(this.targetRadius);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.goldDungeonId = reader.ReadInt32();
			this.requiredMainQuestId = reader.ReadInt32();
			this.enterCount = reader.ReadInt32();
			this.waveCount = reader.ReadInt32();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.rewardDuration = reader.ReadInt32();
			this.waveInterval = reader.ReadInt32();
			this.spawnInterval = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.spawnXPosition = reader.ReadDouble();
			this.spawnYPosition = reader.ReadDouble();
			this.spawnZPosition = reader.ReadDouble();
			this.spawnRadius = reader.ReadDouble();
			this.targetXPosition = reader.ReadDouble();
			this.targetYPosition = reader.ReadDouble();
			this.targetZPosition = reader.ReadDouble();
			this.targetRadius = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
		}

		public WPDGoldDungeon()
		{
		}

		public int goldDungeonId;

		public int requiredMainQuestId;

		public int enterCount;

		public int waveCount;

		public int startDelayTime;

		public int limitTime;

		public int rewardDuration;

		public int waveInterval;

		public int spawnInterval;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public double spawnXPosition;

		public double spawnYPosition;

		public double spawnZPosition;

		public double spawnRadius;

		public double targetXPosition;

		public double targetYPosition;

		public double targetZPosition;

		public double targetRadius;

		public int locationId;
	}
}

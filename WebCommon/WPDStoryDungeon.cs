using System;

namespace WebCommon
{
	public class WPDStoryDungeon : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.continentId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.sceneName);
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
			this.storyDungeonId = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.requiredMainQuestId = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
			this.rewardPick2UnOwnDia = reader.ReadInt32();
			this.rewardPick3UnOwnDia = reader.ReadInt32();
			this.rewardPick4UnOwnDia = reader.ReadInt32();
			this.rewardPickAllUnOwnDia = reader.ReadInt32();
		}

		public WPDStoryDungeon()
		{
		}

		public int storyDungeonId;

		public int continentId;

		public string name;

		public string nameKey;

		public int requiredMainQuestId;

		public string sceneName;

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

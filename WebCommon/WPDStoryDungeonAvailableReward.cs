using System;

namespace WebCommon
{
	public class WPDStoryDungeonAvailableReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.difficulty);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.difficulty = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDStoryDungeonAvailableReward()
		{
		}

		public int storyDungeonId;

		public int difficulty;

		public int rewardNo;

		public int itemId;
	}
}

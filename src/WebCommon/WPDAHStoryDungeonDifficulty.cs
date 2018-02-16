using System;

namespace WebCommon
{
	public class WPDAHStoryDungeonDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.difficulty);
			writer.Write(this.bestPlayTime);
			writer.Write(this.storyDungeonClearGradeId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.difficulty = reader.ReadInt32();
			this.bestPlayTime = reader.ReadInt32();
			this.storyDungeonClearGradeId = reader.ReadInt32();
		}

		public WPDAHStoryDungeonDifficulty()
		{
		}

		public int storyDungeonId;

		public int difficulty;

		public int bestPlayTime;

		public int storyDungeonClearGradeId;
	}
}

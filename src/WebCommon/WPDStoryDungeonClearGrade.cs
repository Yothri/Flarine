using System;

namespace WebCommon
{
	public class WPDStoryDungeonClearGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonClearGradeId);
			writer.Write(this.playTimeLimit);
			writer.Write(this.goldRewardRate);
			writer.Write(this.expRewardRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonClearGradeId = reader.ReadInt32();
			this.playTimeLimit = reader.ReadInt32();
			this.goldRewardRate = reader.ReadInt32();
			this.expRewardRate = reader.ReadInt32();
		}

		public WPDStoryDungeonClearGrade()
		{
		}

		public int storyDungeonClearGradeId;

		public int playTimeLimit;

		public int goldRewardRate;

		public int expRewardRate;
	}
}

using System;

namespace WebCommon
{
	public class WPDExpDungeonClearGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.expDungeonClearGradeId);
			writer.Write(this.playTimeLimit);
			writer.Write(this.expRewardRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.expDungeonClearGradeId = reader.ReadInt32();
			this.playTimeLimit = reader.ReadInt32();
			this.expRewardRate = reader.ReadInt32();
		}

		public WPDExpDungeonClearGrade()
		{
		}

		public int expDungeonClearGradeId;

		public int playTimeLimit;

		public int expRewardRate;
	}
}

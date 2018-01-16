using System;

namespace WebCommon
{
	public class WPDSkyDungeonClearGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.clearGradeId);
			writer.Write(this.playTimeLimit);
			writer.Write(this.goldRewardFactor);
			writer.Write(this.expRewardFactor);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.clearGradeId = reader.ReadInt32();
			this.playTimeLimit = reader.ReadInt32();
			this.goldRewardFactor = reader.ReadDouble();
			this.expRewardFactor = reader.ReadDouble();
		}

		public WPDSkyDungeonClearGrade()
		{
		}

		public int clearGradeId;

		public int playTimeLimit;

		public double goldRewardFactor;

		public double expRewardFactor;
	}
}

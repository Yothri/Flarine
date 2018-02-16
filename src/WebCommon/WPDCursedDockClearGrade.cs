using System;

namespace WebCommon
{
	public class WPDCursedDockClearGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.clearGradeId);
			writer.Write(this.npcRemainHpRate);
			writer.Write(this.rewardRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.clearGradeId = reader.ReadInt32();
			this.npcRemainHpRate = reader.ReadInt32();
			this.rewardRate = reader.ReadInt32();
		}

		public WPDCursedDockClearGrade()
		{
		}

		public int clearGradeId;

		public int npcRemainHpRate;

		public int rewardRate;
	}
}

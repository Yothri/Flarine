using System;

namespace WebCommon
{
	public class WPDMainQuestComplete : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chapterId);
			writer.Write(this.mainQuestCompletedCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.chapterId = reader.ReadInt32();
			this.mainQuestCompletedCount = reader.ReadInt32();
		}

		public WPDMainQuestComplete()
		{
		}

		public int chapterId;

		public int mainQuestCompletedCount;
	}
}

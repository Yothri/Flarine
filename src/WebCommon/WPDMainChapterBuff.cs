using System;

namespace WebCommon
{
	public class WPDMainChapterBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chapterId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.chapterId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDMainChapterBuff()
		{
		}

		public int chapterId;

		public int attrId;

		public double value;
	}
}

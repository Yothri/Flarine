using System;

namespace WebCommon
{
	public class WPDMainChapter : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chapterId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.buffName);
			writer.Write(this.buffNameKey);
			writer.Write(this.mainQuestCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.chapterId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.buffName = reader.ReadString();
			this.buffNameKey = reader.ReadString();
			this.mainQuestCount = reader.ReadInt32();
		}

		public WPDMainChapter()
		{
		}

		public int chapterId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public string buffName;

		public string buffNameKey;

		public int mainQuestCount;
	}
}

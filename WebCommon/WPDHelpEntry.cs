using System;

namespace WebCommon
{
	public class WPDHelpEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.type);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.displayLimitHeroLevel);
			writer.Write(this.displayLimitMainQuestId);
			writer.Write(this.imageName);
			writer.Write(this.title);
			writer.Write(this.titleKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.requiredMainQuestId = reader.ReadInt32();
			this.displayLimitHeroLevel = reader.ReadInt32();
			this.displayLimitMainQuestId = reader.ReadInt32();
			this.imageName = reader.ReadString();
			this.title = reader.ReadString();
			this.titleKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
		}

		public WPDHelpEntry()
		{
		}

		public int entryId;

		public int type;

		public int requiredHeroLevel;

		public int requiredMainQuestId;

		public int displayLimitHeroLevel;

		public int displayLimitMainQuestId;

		public string imageName;

		public string title;

		public string titleKey;

		public string description;

		public string descriptionKey;
	}
}

using System;

namespace WebCommon
{
	public class WPDMenuActivation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.activationNo);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.title);
			writer.Write(this.titleKey);
			writer.Write(this.iconId);
			writer.Write(this.menuType);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.displayType);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.activationNo = reader.ReadInt32();
			this.requiredMainQuestId = reader.ReadInt32();
			this.title = reader.ReadString();
			this.titleKey = reader.ReadString();
			this.iconId = reader.ReadInt32();
			this.menuType = reader.ReadInt32();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.displayType = reader.ReadInt32();
		}

		public WPDMenuActivation()
		{
		}

		public int activationNo;

		public int requiredMainQuestId;

		public string title;

		public string titleKey;

		public int iconId;

		public int menuType;

		public string description;

		public string descriptionKey;

		public int displayType;
	}
}

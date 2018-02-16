using System;

namespace WebCommon
{
	public class WPDAccountHeroAchieveEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.achieveEntryId);
			writer.Write(this.achieveMasterId);
			writer.Write(this.title);
			writer.Write(this.titleKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.value);
			writer.Write(this.count);
			writer.Write(this.ownDia);
			writer.Write(this.achievePoint);
			writer.Write(this.completed);
			writer.Write(this.type);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.achieveEntryId = reader.ReadInt32();
			this.achieveMasterId = reader.ReadInt32();
			this.title = reader.ReadString();
			this.titleKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.value = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
			this.completed = reader.ReadBoolean();
			this.type = reader.ReadInt32();
		}

		public WPDAccountHeroAchieveEntry()
		{
		}

		public int achieveEntryId;

		public int achieveMasterId;

		public string title;

		public string titleKey;

		public string description;

		public string descriptionKey;

		public int value;

		public int count;

		public int ownDia;

		public int achievePoint;

		public bool completed;

		public int type;
	}
}

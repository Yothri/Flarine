using System;

namespace WebCommon
{
	public class WPDMarketCategory : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.categoryId);
			writer.Write(this.depth);
			writer.Write(this.group);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.subCategoryGroup);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.categoryId = reader.ReadInt32();
			this.depth = reader.ReadInt32();
			this.group = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.subCategoryGroup = reader.ReadInt32();
		}

		public WPDMarketCategory()
		{
		}

		public int categoryId;

		public int depth;

		public int group;

		public string name;

		public string nameKey;

		public int subCategoryGroup;
	}
}

using System;

namespace WebCommon
{
	public class WPDStore : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.defaultCategoryId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storeId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.defaultCategoryId = reader.ReadInt32();
		}

		public WPDStore()
		{
		}

		public int storeId;

		public string name;

		public string nameKey;

		public int defaultCategoryId;
	}
}

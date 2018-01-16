using System;

namespace WebCommon
{
	public class WPDPickCostumeAvailableProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.itemId);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public WPDPickCostumeAvailableProduct()
		{
		}

		public int storeId;

		public int categoryId;

		public int itemId;

		public int sortNo;
	}
}

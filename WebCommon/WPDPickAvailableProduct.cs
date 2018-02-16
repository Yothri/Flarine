using System;

namespace WebCommon
{
	public class WPDPickAvailableProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.productNo);
			writer.Write(this.type);
			writer.Write(this.gearId);
			writer.Write(this.gearGrade);
			writer.Write(this.itemId);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.productNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.gearGrade = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public WPDPickAvailableProduct()
		{
		}

		public int storeId;

		public int categoryId;

		public int productNo;

		public int type;

		public int gearId;

		public int gearGrade;

		public int itemId;

		public int sortNo;
	}
}

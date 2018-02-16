using System;

namespace WebCommon
{
	public class WPDProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.itemId);
			writer.Write(this.isItemOwned);
			writer.Write(this.originalPrice);
			writer.Write(this.price);
			writer.Write(this.discountRate);
			writer.Write(this.sortNo);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.tagType);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.isItemOwned = reader.ReadBoolean();
			this.originalPrice = reader.ReadInt32();
			this.price = reader.ReadInt32();
			this.discountRate = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
			this.tagType = reader.ReadInt32();
		}

		public WPDProduct()
		{
		}

		public int productId;

		public int storeId;

		public int categoryId;

		public int itemId;

		public bool isItemOwned;

		public int originalPrice;

		public int price;

		public int discountRate;

		public int sortNo;

		public string startTime;

		public string endTime;

		public int tagType;
	}
}

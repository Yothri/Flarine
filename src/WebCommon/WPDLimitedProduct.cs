using System;

namespace WebCommon
{
	public class WPDLimitedProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.masterId);
			writer.Write(this.storeId);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.isItemOwned);
			writer.Write(this.totalCount);
			writer.Write(this.limitCount);
			writer.Write(this.originalPrice);
			writer.Write(this.price);
			writer.Write(this.discountRate);
			writer.Write(this.sortNo);
			writer.Write(this.remainCount);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.masterId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.isItemOwned = reader.ReadBoolean();
			this.totalCount = reader.ReadInt32();
			this.limitCount = reader.ReadInt32();
			this.originalPrice = reader.ReadInt32();
			this.price = reader.ReadInt32();
			this.discountRate = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.remainCount = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDLimitedProduct()
		{
		}

		public int productId;

		public int masterId;

		public int storeId;

		public int itemId;

		public int itemCount;

		public bool isItemOwned;

		public int totalCount;

		public int limitCount;

		public int originalPrice;

		public int price;

		public int discountRate;

		public int sortNo;

		public int remainCount;

		public int count;
	}
}

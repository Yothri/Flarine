using System;

namespace ClientCommon.PacketData
{
	public class PDLimitedProduct : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.masterId);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.isItemOwned);
			writer.Write(this.totalCount);
			writer.Write(this.limitCount);
			writer.Write(this.originalPrice);
			writer.Write(this.price);
			writer.Write(this.discountRate);
			writer.Write(this.sortNo);
			writer.Write(this.sellCount);
			writer.Write(this.buyCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.masterId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.isItemOwned = reader.ReadBoolean();
			this.totalCount = reader.ReadInt32();
			this.limitCount = reader.ReadInt32();
			this.originalPrice = reader.ReadInt32();
			this.price = reader.ReadInt32();
			this.discountRate = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.sellCount = reader.ReadInt32();
			this.buyCount = reader.ReadInt32();
		}

		public PDLimitedProduct()
		{
		}

		public int productId;

		public int masterId;

		public int itemId;

		public int itemCount;

		public bool isItemOwned;

		public int totalCount;

		public int limitCount;

		public int originalPrice;

		public int price;

		public int discountRate;

		public int sortNo;

		public int sellCount;

		public int buyCount;
	}
}

using System;

namespace WebCommon
{
	public class WPDPickPointExchangeProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.division);
			writer.Write(this.pickPoint);
			writer.Write(this.type);
			writer.Write(this.gearId);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.limitCount);
			writer.Write(this.sortNo);
			writer.Write(this.exchangedCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.division = reader.ReadInt32();
			this.pickPoint = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.limitCount = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.exchangedCount = reader.ReadInt32();
		}

		public WPDPickPointExchangeProduct()
		{
		}

		public int productId;

		public int storeId;

		public int categoryId;

		public int division;

		public int pickPoint;

		public int type;

		public int gearId;

		public int itemId;

		public int itemCount;

		public int limitCount;

		public int sortNo;

		public int exchangedCount;
	}
}

using System;

namespace WebCommon
{
	public class WPDDailyExchangeProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.sourceMoneyType);
			writer.Write(this.sourceMoneyAmount);
			writer.Write(this.limitCount);
			writer.Write(this.exchangedCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.sourceMoneyType = reader.ReadInt32();
			this.sourceMoneyAmount = reader.ReadInt32();
			this.limitCount = reader.ReadInt32();
			this.exchangedCount = reader.ReadInt32();
		}

		public WPDDailyExchangeProduct()
		{
		}

		public int productId;

		public int storeId;

		public int categoryId;

		public int sourceMoneyType;

		public int sourceMoneyAmount;

		public int limitCount;

		public int exchangedCount;
	}
}

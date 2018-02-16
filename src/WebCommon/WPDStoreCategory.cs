using System;

namespace WebCommon
{
	public class WPDStoreCategory : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.descriptionKey);
			writer.Write(this.contentKey);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.contentKey = reader.ReadString();
			this.paymentMoneyType = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public WPDStoreCategory()
		{
		}

		public int storeId;

		public int categoryId;

		public string name;

		public string nameKey;

		public string descriptionKey;

		public string contentKey;

		public int paymentMoneyType;

		public int sortNo;
	}
}

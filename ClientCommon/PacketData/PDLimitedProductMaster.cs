using System;

namespace ClientCommon.PacketData
{
	public class PDLimitedProductMaster : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.masterId);
			writer.Write(this.storeId);
			writer.Write(this.name);
			writer.Write(this.bannerImage);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.limitedProducts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.masterId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.bannerImage = reader.ReadString();
			this.paymentMoneyType = reader.ReadInt32();
			this.startTime = reader.ReadDateTime();
			this.endTime = reader.ReadDateTime();
			this.limitedProducts = reader.ReadPDPacketDatas<PDLimitedProduct>();
		}

		public PDLimitedProductMaster()
		{
		}

		public int masterId;

		public int storeId;

		public string name;

		public string bannerImage;

		public int paymentMoneyType;

		public DateTime startTime;

		public DateTime endTime;

		public PDLimitedProduct[] limitedProducts;
	}
}

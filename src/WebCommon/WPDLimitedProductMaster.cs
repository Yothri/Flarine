using System;

namespace WebCommon
{
	public class WPDLimitedProductMaster : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.masterId);
			writer.Write(this.storeId);
			writer.Write(this.name);
			writer.Write(this.bannerImage);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.masterId = reader.ReadInt32();
			this.storeId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.bannerImage = reader.ReadString();
			this.paymentMoneyType = reader.ReadInt32();
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
		}

		public WPDLimitedProductMaster()
		{
		}

		public int masterId;

		public int storeId;

		public string name;

		public string bannerImage;

		public int paymentMoneyType;

		public string startTime;

		public string endTime;
	}
}

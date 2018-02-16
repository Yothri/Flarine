using System;

namespace WebCommon
{
	public class WPDPurchaseProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.inAppProductId);
			writer.Write(this.type);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.addOwnDia);
			writer.Write(this.discountRate);
			writer.Write(this.eventLimitCount);
			writer.Write(this.tagType);
			writer.Write(this.sortNo);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.inAppProductId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.addOwnDia = reader.ReadInt32();
			this.discountRate = reader.ReadInt32();
			this.eventLimitCount = reader.ReadInt32();
			this.tagType = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
		}

		public WPDPurchaseProduct()
		{
		}

		public int productId;

		public int inAppProductId;

		public int type;

		public string name;

		public string nameKey;

		public int addOwnDia;

		public int discountRate;

		public int eventLimitCount;

		public int tagType;

		public int sortNo;

		public string startTime;

		public string endTime;
	}
}

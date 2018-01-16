using System;

namespace ClientCommon.PacketData
{
	public class PDPurchaseProduct : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.inAppProductId);
			writer.Write(this.type);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.addOwnDia);
			writer.Write(this.addUnOwnDia);
			writer.Write(this.discountRate);
			writer.Write(this.eventLimitCount);
			writer.Write(this.tagType);
			writer.Write(this.sortNo);
			writer.Write(this.saleable);
			writer.Write(this.imgFileName);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.inAppProductId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.addOwnDia = reader.ReadInt32();
			this.addUnOwnDia = reader.ReadInt32();
			this.discountRate = reader.ReadInt32();
			this.eventLimitCount = reader.ReadInt32();
			this.tagType = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.saleable = reader.ReadBoolean();
			this.imgFileName = reader.ReadString();
			this.startTime = reader.ReadDateTime();
			this.endTime = reader.ReadDateTime();
		}

		public PDPurchaseProduct()
		{
		}

		public int productId;

		public int inAppProductId;

		public int type;

		public string name = "";

		public string nameKey = "";

		public int addOwnDia;

		public int addUnOwnDia;

		public int discountRate;

		public int eventLimitCount;

		public int tagType;

		public int sortNo;

		public bool saleable = true;

		public string imgFileName = "";

		public DateTime startTime = DateTime.MinValue;

		public DateTime endTime = DateTime.MinValue;
	}
}

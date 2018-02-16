using System;

namespace WebCommon
{
	public class WPDInAppProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.inAppProductId);
			writer.Write(this.inAppProductKey);
			writer.Write(this.price);
			writer.Write(this.unOwnDia);
			writer.Write(this.isAvailableFirstPurchase);
			writer.Write(this.firstPurchaseOwnDia);
			writer.Write(this.firstPurchaseDiscountRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.inAppProductId = reader.ReadInt32();
			this.inAppProductKey = reader.ReadString();
			this.price = reader.ReadString();
			this.unOwnDia = reader.ReadInt32();
			this.isAvailableFirstPurchase = reader.ReadBoolean();
			this.firstPurchaseOwnDia = reader.ReadInt32();
			this.firstPurchaseDiscountRate = reader.ReadInt32();
		}

		public WPDInAppProduct()
		{
		}

		public int inAppProductId;

		public string inAppProductKey;

		public string price;

		public int unOwnDia;

		public bool isAvailableFirstPurchase;

		public int firstPurchaseOwnDia;

		public int firstPurchaseDiscountRate;
	}
}

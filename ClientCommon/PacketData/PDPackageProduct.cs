using System;

namespace ClientCommon.PacketData
{
	public class PDPackageProduct : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.inAppProductId);
			writer.Write(this.imageName);
			writer.Write(this.buyLimitCount);
			writer.Write(this.inAppProductKey);
			writer.Write(this.priceString);
			writer.Write(this.buyCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.inAppProductId = reader.ReadInt32();
			this.imageName = reader.ReadString();
			this.buyLimitCount = reader.ReadInt32();
			this.inAppProductKey = reader.ReadString();
			this.priceString = reader.ReadString();
			this.buyCount = reader.ReadInt32();
		}

		public PDPackageProduct()
		{
		}

		public int productId;

		public int inAppProductId;

		public string imageName;

		public int buyLimitCount;

		public string inAppProductKey;

		public string priceString;

		public int buyCount;
	}
}

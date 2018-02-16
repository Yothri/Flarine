using System;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductBeginCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.productType);
			writer.Write(this.storeType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.productType = reader.ReadInt32();
			this.storeType = reader.ReadInt32();
		}

		public PurchaseProductBeginCommandBody()
		{
		}

		public int productId;

		public int productType;

		public int storeType;
	}
}

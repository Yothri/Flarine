using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.purchaseProducts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.purchaseProducts = reader.ReadPDPacketDatas<PDPurchaseProduct>();
		}

		public PurchaseProductListResponseBody()
		{
		}

		public PDPurchaseProduct[] purchaseProducts;
	}
}

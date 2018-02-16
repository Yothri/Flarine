using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MarketProductsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.marketProductItems);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.marketProductItems = reader.ReadPDPacketDatas<PDMarketProductItem>();
		}

		public MarketProductsResponseBody()
		{
		}

		public PDMarketProductItem[] marketProductItems;
	}
}

using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.marketProductItem);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.marketProductItem = reader.ReadPDPacketData<PDMarketProductItem>();
		}

		public MarketProductResponseBody()
		{
		}

		public PDMarketProductItem marketProductItem;
	}
}

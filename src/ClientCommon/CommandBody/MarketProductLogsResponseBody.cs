using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MarketProductLogsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.marketProductLogItems);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.marketProductLogItems = reader.ReadPDPacketDatas<PDMarketProductLogItem>();
		}

		public MarketProductLogsResponseBody()
		{
		}

		public PDMarketProductLogItem[] marketProductLogItems;
	}
}

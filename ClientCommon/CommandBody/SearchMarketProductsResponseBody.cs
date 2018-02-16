using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SearchMarketProductsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.searchMarketProductItems);
			writer.Write(this.totalCount);
			writer.Write(this.page);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.searchMarketProductItems = reader.ReadPDPacketDatas<PDSearchMarketProductItem>();
			this.totalCount = reader.ReadInt32();
			this.page = reader.ReadInt32();
		}

		public SearchMarketProductsResponseBody()
		{
		}

		public PDSearchMarketProductItem[] searchMarketProductItems;

		public int totalCount;

		public int page;
	}
}

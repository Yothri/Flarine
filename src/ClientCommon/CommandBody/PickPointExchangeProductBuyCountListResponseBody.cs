using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickPointExchangeProductBuyCountListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.buyCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.buyCounts = reader.ReadPDPacketDatas<PDPickPointExchangeProductBuyCount>();
		}

		public PickPointExchangeProductBuyCountListResponseBody()
		{
		}

		public DateTime date;

		public PDPickPointExchangeProductBuyCount[] buyCounts;
	}
}

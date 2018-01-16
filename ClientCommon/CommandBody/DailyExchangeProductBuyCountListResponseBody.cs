using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyExchangeProductBuyCountListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.dailyExchangeProductBuyCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.dailyExchangeProductBuyCounts = reader.ReadPDPacketDatas<PDDailyExchangeProductBuyCount>();
		}

		public DailyExchangeProductBuyCountListResponseBody()
		{
		}

		public DateTime date;

		public PDDailyExchangeProductBuyCount[] dailyExchangeProductBuyCounts;
	}
}

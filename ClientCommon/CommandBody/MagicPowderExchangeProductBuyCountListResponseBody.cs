using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MagicPowderExchangeProductBuyCountListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.magicPowderExchangeProductBuyCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.magicPowderExchangeProductBuyCounts = reader.ReadPDPacketDatas<PDMagicPowderExchangeProductBuyCount>();
		}

		public MagicPowderExchangeProductBuyCountListResponseBody()
		{
		}

		public DateTime date;

		public PDMagicPowderExchangeProductBuyCount[] magicPowderExchangeProductBuyCounts;
	}
}

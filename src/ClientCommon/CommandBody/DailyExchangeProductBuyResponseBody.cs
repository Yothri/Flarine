using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyExchangeProductBuyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.date);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.date = reader.ReadDateTime();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public DailyExchangeProductBuyResponseBody()
		{
		}

		public int dia;

		public DateTime date;

		public PDAccountHero accountHero;
	}
}

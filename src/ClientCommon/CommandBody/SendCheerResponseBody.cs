using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SendCheerResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.accountHero);
			writer.Write(this.tagetAccountHeroReceivedCheerCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.tagetAccountHeroReceivedCheerCount = reader.ReadInt32();
		}

		public SendCheerResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero accountHero;

		public int tagetAccountHeroReceivedCheerCount;
	}
}

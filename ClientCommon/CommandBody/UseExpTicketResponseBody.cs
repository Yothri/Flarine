using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class UseExpTicketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public UseExpTicketResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero accountHero;
	}
}

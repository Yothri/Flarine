using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MailInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mail);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mail = reader.ReadPDPacketData<PDMail>();
		}

		public MailInfoResponseBody()
		{
		}

		public PDMail mail;
	}
}

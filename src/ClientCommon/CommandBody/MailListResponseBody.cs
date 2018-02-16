using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MailListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mails);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mails = reader.ReadPDPacketDatas<PDMail>();
		}

		public MailListResponseBody()
		{
		}

		public PDMail[] mails;
	}
}

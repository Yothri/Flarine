using System;

namespace ClientCommon.CommandBody
{
	public class MailInfoCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mailId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mailId = reader.ReadGuid();
		}

		public MailInfoCommandBody()
		{
		}

		public Guid mailId;
	}
}

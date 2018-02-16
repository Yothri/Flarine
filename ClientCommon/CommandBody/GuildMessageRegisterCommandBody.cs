using System;

namespace ClientCommon.CommandBody
{
	public class GuildMessageRegisterCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.message);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.message = reader.ReadString();
		}

		public GuildMessageRegisterCommandBody()
		{
		}

		public string message;
	}
}

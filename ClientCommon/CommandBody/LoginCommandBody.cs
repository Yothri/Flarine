using System;

namespace ClientCommon.CommandBody
{
	public class LoginCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accessToken);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accessToken = reader.ReadString();
		}

		public LoginCommandBody()
		{
		}

		public string accessToken;
	}
}

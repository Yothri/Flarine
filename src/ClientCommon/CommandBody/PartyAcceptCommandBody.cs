using System;

namespace ClientCommon.CommandBody
{
	public class PartyAcceptCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.appId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.appId = reader.ReadInt64();
		}

		public PartyAcceptCommandBody()
		{
		}

		public long appId;
	}
}

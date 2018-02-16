using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyApplicationReceivedEventBody : SEBServerEventBody
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

		public SEBPartyApplicationReceivedEventBody()
		{
		}

		public long appId;
	}
}

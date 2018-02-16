using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMemberExitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
			writer.Write(this.reason);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
			this.reason = reader.ReadInt32();
		}

		public SEBPartyMemberExitEventBody()
		{
		}

		public int memberId;

		public int reason;
	}
}

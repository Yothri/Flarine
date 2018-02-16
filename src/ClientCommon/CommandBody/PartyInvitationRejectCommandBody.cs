using System;

namespace ClientCommon.CommandBody
{
	public class PartyInvitationRejectCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
		}

		public PartyInvitationRejectCommandBody()
		{
		}

		public long partyInstanceId;
	}
}
